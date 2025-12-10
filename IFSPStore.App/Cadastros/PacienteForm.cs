using ConsultorioIFSP.App.Base;
using ConsultorioIFSP.App.Models; // Assumindo que PacienteModel está aqui
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators; // Assumindo que PacienteValidator está aqui


namespace ConsultorioIFSP.App.Cadastros
{
    // Classe de formulário específica para Paciente, herdando a estrutura base
    public partial class PacienteForm : BaseForm
    {
        private readonly IBaseService<Paciente> _pacienteService;
        private List<PacienteModel>? pacientes; // Lista de modelos para o grid (Mude para Paciente se o Model não existir)

        // Construtor: Injeção de dependência do serviço de Paciente
        public PacienteForm(IBaseService<Paciente> pacienteService)
        {
            _pacienteService = pacienteService;
            InitializeComponent();

            // NOTE: txtRegistrationDate não existe na entidade Paciente (usando DataNascimento)
            // Se você mantiver este campo no designer, ele precisa ser mapeado ou removido.
            // Vou comentar por enquanto:
            // txtRegistrationDate.Text = DateTime.Now.ToString("g"); 
        }

        // --------------------------------------------------------------------------------
        // MÉTODOS DE PREENCHIMENTO E PERSISTÊNCIA
        // --------------------------------------------------------------------------------

        // Método auxiliar para preencher a entidade Paciente a partir dos TextBoxes
        private void PreencheObjetoEntidade(Paciente paciente)
        {
            // Campos baseados na sua entidade Paciente.cs:
            paciente.Nome = txtName.Text;
            paciente.Email = txtEmail.Text;
            paciente.Telefone = txtTelefone.Text;

            // Campos específicos
            // Assumindo que você tem um controle para DataNascimento (e.g., dtpDataNascimento)
            // paciente.DataNascimento = dtpDataNascimento.Value; 

            // Assumindo que você tem um controle para Sexo (e.g., cmbSexo)
            // paciente.Sexo = cmbSexo.SelectedItem?.ToString() ?? string.Empty; 

            // Se DataNascimento e Sexo vierem de TextBoxes:
            if (DateTime.TryParse(txtDataNascimento.Text, out var dataNasc))
            {
                paciente.DataNascimento = dataNasc;
            }
            paciente.Sexo = txtSexo.Text; // Usando txtSexo, se for um TextBox
        }

        // Sobrescreve public virtual void Salvar() na BaseForm
        protected override void Save()
        {
            try
            {
                Paciente paciente;
                if (IsEditMode)
                {
                    // MODO EDIÇÃO
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        paciente = _pacienteService.GetById<Paciente>(id);
                        if (paciente != null)
                        {
                            PreencheObjetoEntidade(paciente);
                            paciente = _pacienteService.Update<Paciente, Paciente, PacienteValidator>(paciente);
                        }
                        else
                        {
                            MessageBox.Show("Paciente não encontrado no banco de dados.");
                        }
                    }
                }
                else
                {
                    // MODO NOVO
                    paciente = new Paciente();
                    PreencheObjetoEntidade(paciente);
                    _pacienteService.Add<Paciente, Paciente, PacienteValidator>(paciente);
                }

                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultório IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sobrescreve public virtual void Deletar(int id) na BaseForm
        protected override void Delete(int id)
        {
            try
            {
                _pacienteService.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultório IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sobrescreve public virtual void CarregaGrid() na BaseForm
        protected override void CarregaGrid()
        {
            // Busca PacienteModel (ou Paciente, se não houver Model)
            pacientes = _pacienteService.Get<PacienteModel>().ToList();
            dataGridViewList.DataSource = pacientes;

            // Campos específicos para ocultar no grid (se existirem no Model)
            // dataGridViewList.Columns["Sexo"]!.Visible = false; 
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // Sobrescreve public virtual void CarregaRegistro(DataGridViewRow? linha) na BaseForm
        protected override void loadList(DataGridViewRow? linha)
        {
            // Este método carrega os campos na UI.

            txtId.Text = linha?.Cells["Id"].Value?.ToString() ?? string.Empty;
            txtName.Text = linha?.Cells["Nome"].Value?.ToString() ?? string.Empty;
            txtEmail.Text = linha?.Cells["Email"].Value?.ToString() ?? string.Empty;

            // Campos específicos do Paciente
            // Assumindo que você tem um txtTelefone e txtSexo no Designer
            txtTelefone.Text = linha?.Cells["Telefone"].Value?.ToString() ?? string.Empty;
            txtSexo.Text = linha?.Cells["Sexo"].Value?.ToString() ?? string.Empty;

            // Tratamento da Data de Nascimento
            string dataNascString = linha?.Cells["DataNascimento"].Value?.ToString() ?? string.Empty;
            if (DateTime.TryParse(dataNascString, out var dataNasc))
            {
                txtDataNascimento.Text = dataNasc.ToString("d"); // Formato de data curta
            }
            else
            {
                txtDataNascimento.Text = string.Empty;
            }

            // Se você tem campos de Data de Login/Registro herdados do BaseForm (User) que não se aplicam,
            // você deve removê-los ou ignorá-los no PacienteForm.Designer.cs
        }
    }
}