using ConsultorioIFSP.App.Base;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;

namespace ConsultorioIFSP.App.Cadastros
{
    public partial class MedicoForm : BaseForm
    {
        private readonly IBaseService<Medico> _medicoService;
        private List<Medico> medicos;

        public MedicoForm(IBaseService<Medico> medicoService)
        {
            _medicoService = medicoService;
            InitializeComponent();
        }

        private void PreencheObjetoEntidade(Medico medico)
        {
            medico.Nome = txtName.Text;
            medico.Crm = txtCrm.Text;
            medico.Especialidade = txtEspecialidade.Text;
            medico.Login = txtLogin.Text;
            medico.Password = txtPassword.Text;
            medico.Telefone = txtTelefone.Text;

        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var medico = _medicoService.GetById<Medico>(id);
                        if (medico != null)
                        {
                            PreencheObjetoEntidade(medico);
                            medico = _medicoService.Update<Medico, Medico, MedicoValidator>(medico);
                        }
                        else
                        {
                            MessageBox.Show("Médico não encontrado no banco de dados.");
                        }
                    }
                }
                else
                {
                    var medico = new Medico();
                    PreencheObjetoEntidade(medico);
                    _medicoService.Add<Medico, Medico, MedicoValidator>(medico);
                }

                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultorio IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _medicoService.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultorio IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            medicos = _medicoService.Get<Medico>().ToList();

            dataGridViewList.DataSource = medicos;
            dataGridViewList.Columns["Password"]!.Visible = false;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value?.ToString() ?? string.Empty;
            txtName.Text = linha?.Cells["Name"].Value?.ToString() ?? string.Empty;
            txtCrm.Text = linha?.Cells["Crm"].Value?.ToString() ?? string.Empty;
            txtTelefone.Text = linha?.Cells["Telefone"].Value?.ToString() ?? string.Empty;
            txtLogin.Text = linha?.Cells["Login"].Value?.ToString() ?? string.Empty;
            txtPassword.Text = linha?.Cells["Password"].Value?.ToString() ?? string.Empty;
            txtEspecialidade.Text = linha?.Cells["Especialidade"].Value?.ToString() ?? string.Empty;

        }
    }
}