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

        //private ReaLTaiizor.Controls.MaterialComboBox cboMedico;
        //private ReaLTaiizor.Controls.MaterialComboBox cboPaciente;

        public ReceitaForm(IBaseService<Receita> receitaService
                  , IBaseService<Medico> medicoService, IBaseService<Paciente> pacienteService) : base()
        {
            _receitaService = receitaService;
            _medicoService = medicoService;
            _pacienteService = pacienteService;

            InitializeComponent();
            CarregarComboBoxes();
        }

        private void CarregarComboBoxes()
        {
            // Carrega médicos
            var medicos = _medicoService.Get<MedicoModel>().ToList();
            cboMedicoId.DataSource = medicos;
            cboMedicoId.DisplayMember = "Nome";
            cboMedicoId.ValueMember = "Id";
            cboMedicoId.SelectedIndex = -1; // Deseleciona

            // Carrega pacientes
            var pacientes = _pacienteService.Get<PacienteModel>().ToList();
            cboPacienteId.DataSource = pacientes;
            cboPacienteId.DisplayMember = "Nome";
            cboPacienteId.ValueMember = "Id";
            cboPacienteId.SelectedIndex = -1;
        }

        private void PreencheObjeto(Receita receita)
        {
            // Validação e Preenchimento de Periodo
            if (DateTime.TryParse(txtPeriodo.Text, out DateTime periodo))
            {
                receita.Periodo = periodo;
            }
            else
            {
                throw new Exception("Data de Período inválida.");
            }

            // Validação e Preenchimento de Quantidade
            if (int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                receita.Quantidade = quantidade;
            }
            else
            {
                throw new Exception("Quantidade inválida.");
            }

            // ----------------------------------------------------------------------
            // CORREÇÃO: Mapeamento de Chaves Estrangeiras (FKs)
            // ----------------------------------------------------------------------

            int medicoId = Convert.ToInt32(cboMedicoId.SelectedValue);
            if (medicoId <= 0)
            {
                throw new Exception("Selecione um Médico para a consulta.");
            }
            receita.MedicoId = medicoId;


            // 2. PacienteId
            int pacienteId = Convert.ToInt32(cboPacienteId.SelectedValue);
            if (pacienteId <= 0)
            {
                throw new Exception("Selecione um Paciente para a consulta.");
            }

            // CORREÇÃO CRÍTICA: Atribuir à Chave Estrangeira PacienteId
            receita.PacienteId = pacienteId;
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
            // Se linha for nula, sai do método
            if (linha == null) return;

            // 1. Carrega campos de texto
            txtId.Text = linha.Cells["Id"].Value?.ToString();
            txtQuantidade.Text = linha.Cells["Quantidade"].Value?.ToString();

            // 2. Carrega a Data do Período
            var periodoValue = linha.Cells["Periodo"].Value;
            if (periodoValue is DateTime periodoDate)
            {
                // Formata a data de volta para o padrão DD/MM/AAAA
                txtPeriodo.Text = periodoDate.ToString("dd/MM/yyyy");
            }
            else
            {
                // Tenta carregar como string
                txtPeriodo.Text = periodoValue?.ToString();
            }

            // 3. Carrega os ComboBoxes pelo ValueMember (Id)
            // Usando os nomes corretos do Designer (cboMedicoId e cboPacienteId)
            cboMedicoId.SelectedValue = linha.Cells["MedicoId"].Value;
            cboPacienteId.SelectedValue = linha.Cells["PacienteId"].Value;
        }

        protected override void Delete(int id)
        {
            _receitaService.Delete(id);
            CarregaGrid();
        }

    }
}