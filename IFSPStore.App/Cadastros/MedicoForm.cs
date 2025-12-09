using ConsultaIFSP.App.Base;
using ConsultorioIFSP.App.Models; // Para MedicoModel
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;


namespace ConsultorioIFSP.App.Cadastros
{
    // Herda a classe base não genérica
    public partial class MedicoForm : BaseForm
    {
        // 1. Serviço e Lista específicos injetados
        private readonly IBaseService<Medico> _medicoService;
        private List<MedicoModel>? medicos; // Usa MedicoModel para o grid

        // 2. Construtor para Injeção de Dependência
        public MedicoForm(IBaseService<Medico> medicoService) : base()
        {
            _medicoService = medicoService;
            InitializeComponent();
        }

        // Método auxiliar para mapear UI -> Objeto
        private void PreencheObjeto(Medico medico)
        {
            // Mapeamento dos campos da UI para a entidade Medico
            medico.Nome = txtNome.Text;
            medico.Login = txtLogin.Text;
            medico.Password = txtPassword.Text;
            medico.Especialidade = txtEspecialidade.Text;
            medico.Crm = txtCrm.Text;
            medico.Telefone = txtTelefone.Text;
        }

        // --- Implementação dos Métodos Virtuais de CRUD ---

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode) 
                {
                    // Update
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var medico = _medicoService.GetById<Medico>(id);
                        PreencheObjeto(medico);
                        // Chama o serviço de Update com o MedicoValidator
                        medico = _medicoService.Update<Medico, Medico, MedicoValidator>(medico);
                    }
                }
                else
                {
                    // Add
                    var medico = new Medico();
                    PreencheObjeto(medico);
                    // Chama o serviço de Add com o MedicoValidator
                    medico = _medicoService.Add<Medico, Medico, MedicoValidator>(medico);
                }

                tabControlRegister.SelectedIndex = 1;
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
                _medicoService.Delete(id);
                MessageBox.Show("Registro excluído com sucesso!", @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            try
            {
                // Carrega MedicoModel para exibição (depende do AutoMapper)
                medicos = _medicoService.Get<MedicoModel>().ToList();
                dataGridViewList.DataSource = medicos;

                // Ajuste de coluna (assumindo dataGridViewConsulta)
                dataGridViewList.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}