using ConsultaIFSP.App.Base;
using ConsultorioIFSP.App.Models;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;

namespace ConsultorioIFSP.App.Cadastros
{
    // Herda a classe base não genérica
    public partial class PacienteForm : BaseForm
    {
        // 1. Serviço e Lista específicos injetados
        private readonly IBaseService<Paciente> _pacienteService;
        private List<PacienteModel>? pacientes; // Usa PacienteModel para o grid

        // 2. Construtor para Injeção de Dependência
        public PacienteForm(IBaseService<Paciente> pacienteService) : base()
        {
            _pacienteService = pacienteService;
            InitializeComponent();
            CarregaGrid(); // Garante que a grade carregue na inicialização
        }

        // Método auxiliar para mapear UI -> Objeto
        private void PreencheObjeto(Paciente paciente)
        {
            // Mapeamento dos campos da UI para a entidade Paciente
            paciente.Nome = txtNome.Text;
            paciente.Email = txtEmail.Text;
            paciente.Sexo = txtSexo.Text;
            paciente.Telefone = txtTelefone.Text;

            if (DateTime.TryParse(txtDataNascimento.Text, out DateTime dataNascimento))
            {
                paciente.DataNascimento = dataNascimento;
            }
            else
            {
                throw new Exception("Data de Nascimento inválida.");
            }
        }

        // --- Implementação dos Métodos Virtuais de CRUD ---

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode) // IsAlteracao é herdado
                {
                    // Update
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var paciente = _pacienteService.GetById<Paciente>(id);
                        PreencheObjeto(paciente);
                        // Chama o serviço de Update com o PacienteValidator
                        paciente = _pacienteService.Update<Paciente, Paciente, PacienteValidator>(paciente);
                    }
                }
                else
                {
                    // Add
                    var paciente = new Paciente();
                    PreencheObjeto(paciente);
                    // Chama o serviço de Add com o PacienteValidator
                    paciente = _pacienteService.Add<Paciente, Paciente, PacienteValidator>(paciente);
                }

                // Ajuste de UI após salvar
                // tabControlCadastro é o nome que você usou, vamos mantê-lo.
                tabControlCadastro.SelectedIndex = 1;
                CarregaGrid();
                MessageBox.Show("Registro salvo com sucesso!", @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _pacienteService.Delete(id);
                CarregaGrid(); // Recarrega a grade após deletar
                MessageBox.Show("Registro excluído com sucesso!", @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -----------------------------------------------------------------
        // Método de Consulta (CarregaGrid) - ADAPTADO para Filtros
        // -----------------------------------------------------------------

        protected override void CarregaGrid()
        {
            try
            {
                // 1. Coleta os Filtros da UI (Assumindo txtNomeFilter e txtEmailFilter no designer)
                string nomeFiltro = txtNomeFilter.Text.Trim();
                string emailFiltro = txtEmailFilter.Text.Trim();

                // 2. Executa a busca filtrada
                pacientes = BuscarPacientesFiltrados(nomeFiltro, emailFiltro).ToList();

                // 3. Exibe os Resultados
                // O nome da grade no seu código é dataGridViewConsulta
                dataGridViewConsulta.DataSource = pacientes;

                // Ajuste de coluna
                if (dataGridViewConsulta.Columns.Contains("Nome"))
                {
                    dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método auxiliar para aplicar a lógica de filtragem via Linq
        private IEnumerable<PacienteModel> BuscarPacientesFiltrados(string nome, string email)
        {
            // Busca todos os pacientes models
            var query = _pacienteService.Get<PacienteModel>().AsQueryable();

            if (!string.IsNullOrEmpty(nome))
            {
                // Filtra por Nome (case-insensitive)
                query = query.Where(p => p.Nome.ToLower().Contains(nome.ToLower()));
            }

            if (!string.IsNullOrEmpty(email))
            {
                // Filtra por Email (case-insensitive)
                query = query.Where(p => p.Email.ToLower().Contains(email.ToLower()));
            }

            return query;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            // Mapeia os dados da linha selecionada para os campos do formulário para o modo "Editar"
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtSexo.Text = linha?.Cells["Sexo"].Value.ToString();

            // Certifique-se de formatar a data corretamente ao carregar
            if (DateTime.TryParse(linha?.Cells["DataNascimento"].Value?.ToString(), out DateTime dataNasc))
            {
                txtDataNascimento.Text = dataNasc.ToString("d"); // Exibe apenas a data (sem hora)
            }
            else
            {
                txtDataNascimento.Text = linha?.Cells["DataNascimento"].Value?.ToString();
            }

            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
        }

        // -----------------------------------------------------------------
        // Manipuladores de Eventos (Botões de Filtro)
        // -----------------------------------------------------------------

        // Este método deve ser ligado ao Click do botão de consulta no designer (btnConsultar)
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        // Este método deve ser ligado ao Click do botão de limpeza no designer (btnLimparFiltros)
        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            txtNomeFilter.Clear();
            txtEmailFilter.Clear();
            CarregaGrid();
        }
    }
}