using ConsultorioIFSP.App.Base;
using ConsultorioIFSP.App.Models;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;
using AutoMapper; // Adicionado para resolver o mapeamento

namespace ConsultorioIFSP.App.Cadastros
{
    public partial class MedicoForm : BaseForm
    {
        private readonly IBaseService<Medico> _medicoService;
        private readonly IMapper _mapper; // Injeção do IMapper
        private List<MedicoModel>? medicos; // Variável declarada para resolver CS0103

        public MedicoForm(IBaseService<Medico> medicoService, IMapper mapper) // Construtor modificado
        {
            _medicoService = medicoService;
            _mapper = mapper; // Armazenando o mapper
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
            // medico.Email = txtEmail.Text; // LINHA REMOVIDA/COMENTADA PARA RESOLVER O ERRO "EMAIL CANNOT BE NULL"
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
            // CORREÇÃO CS0029: Mapeamento explícito
            var medicosEntidade = _medicoService.Get<Medico>().ToList();
            medicos = _mapper.Map<List<MedicoModel>>(medicosEntidade); // RESOLVE CS0029

            dataGridViewList.DataSource = medicos;

            if (dataGridViewList.Columns.Contains("Password"))
            {
                dataGridViewList.Columns["Password"]!.Visible = false;
            }
            // Adicionado auto-size para melhor visualização (pode ser ajustado)
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value?.ToString() ?? string.Empty;
            txtName.Text = linha?.Cells["Nome"].Value?.ToString() ?? string.Empty; // Usar "Nome" em vez de "Name"
            txtCrm.Text = linha?.Cells["Crm"].Value?.ToString() ?? string.Empty;
            txtTelefone.Text = linha?.Cells["Telefone"].Value?.ToString() ?? string.Empty;
            txtLogin.Text = linha?.Cells["Login"].Value?.ToString() ?? string.Empty;
            txtPassword.Text = linha?.Cells["Password"].Value?.ToString() ?? string.Empty;
            txtEspecialidade.Text = linha?.Cells["Especialidade"].Value?.ToString() ?? string.Empty;
            txtEmail.Text = linha?.Cells["Email"].Value?.ToString() ?? string.Empty;
        }
    }
}