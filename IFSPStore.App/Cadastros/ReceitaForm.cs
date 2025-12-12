using ConsultorioIFSP.App.Base;
using ConsultorioIFSP.App.Models; 
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;


namespace ConsultorioIFSP.App.Cadastros
{
    public partial class ReceitaForm : BaseForm
    {

        private readonly IBaseService<Receita> _receitaService;
        private List<ReceitaModel>? receitas;
        private readonly IBaseService<Medico> _medicoService; 
        private readonly IBaseService<Paciente> _pacienteService; 

        public ReceitaForm(IBaseService<Receita> receitaService
                            , IBaseService<Medico> medicoService, IBaseService<Paciente> pacienteService ) : base()
        {
            _receitaService = receitaService;
             _medicoService = medicoService;
             _pacienteService = pacienteService;

            InitializeComponent();
        }

        private void PreencheObjeto(Receita receita)
        {
            if (DateTime.TryParse(txtPeriodo.Text, out DateTime periodo))
            {
                receita.Periodo = periodo;
            }
            else
            {
                throw new Exception("Data de Período inválida.");
            }

            if (int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                receita.Quantidade = quantidade;
            }
            else
            {
                throw new Exception("Quantidade inválida.");
            }

             if (int.TryParse(cboMedicoId.Text, out int medicoId)) 
             {
                 receita.MedicoId = medicoId;
             }
             else 
             { 
                 throw new Exception("Médico deve ser selecionado."); 
             }
             if (int.TryParse(cboPacienteId.Text, out int pacienteId)) 
             {
                 receita.PacienteId = pacienteId;
             } 
             else 
            { 
                 throw new Exception("Paciente deve ser selecionado."); 
             }
        }

        protected override void Save()
        {
            try
            {
                Receita receita;
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        receita = _receitaService.GetById<Receita>(id);
                        if (receita != null)
                        {
                            PreencheObjeto(receita);
                            _receitaService.Update<Receita, Receita, ReceitaValidator>(receita);
                        }
                    }
                }
                else
                {
                    receita = new Receita();
                    PreencheObjeto(receita);
                    _receitaService.Add<Receita, Receita, ReceitaValidator>(receita);
                }

                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            try
            {
                receitas = _receitaService.Get<ReceitaModel>().ToList();
                dataGridViewList.DataSource = receitas;
                dataGridViewList.Columns["Periodo"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtPeriodo.Text = linha?.Cells["Periodo"].Value.ToString();
            txtQuantidade.Text = linha?.Cells["Quantidade"].Value.ToString();
            cboMedicoId.Text = linha?.Cells["MedicoId"].Value.ToString();
            cboPacienteId.Text = linha?.Cells["PacienteId"].Value.ToString();
        }

        protected override void Delete(int id)
        {
            _receitaService.Delete(id);
            CarregaGrid();
        }
        
    }
}