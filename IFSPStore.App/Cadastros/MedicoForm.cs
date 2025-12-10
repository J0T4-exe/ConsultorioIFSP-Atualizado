using ConsultorioIFSP.App.Base;
using ConsultorioIFSP.App.Models; // Mantido, mas não será usado para a lista
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;

namespace ConsultorioIFSP.App.Cadastros
{
    public partial class MedicoForm : BaseForm
    {
        private readonly IBaseService<Medico> _medicoService;

        // CORREÇÃO: Variável da lista alterada de MedicoModel para a entidade Medico
        // (Isso resolve o erro "medicos não existe")
        private List<Medico>? medicos;

        public MedicoForm(IBaseService<Medico> medicoService)
        {
            _medicoService = medicoService;
            InitializeComponent();
        }

        private void PreencheObjetoEntidade(Medico medico)
        {
            medico.Nome = txtName.Text;
            medico.Crm = txtEmail.Text;
            medico.Login = txtLogin.Text;
            medico.Password = txtPassword.Text;

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
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            // CORREÇÃO: Tipo da busca alterado de MedicoModel para a entidade Medico
            medicos = _medicoService.Get<Medico>().ToList();

            dataGridViewList.DataSource = medicos;

            // As colunas devem ser referenciadas pelo nome das propriedades na entidade Medico
            dataGridViewList.Columns["Password"]!.Visible = false;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value?.ToString() ?? string.Empty;
            txtName.Text = linha?.Cells["Name"].Value?.ToString() ?? string.Empty;
            txtEmail.Text = linha?.Cells["Email"].Value?.ToString() ?? string.Empty;
            txtLogin.Text = linha?.Cells["Login"].Value?.ToString() ?? string.Empty;
            txtPassword.Text = linha?.Cells["Password"].Value?.ToString() ?? string.Empty;

        }
    }
}