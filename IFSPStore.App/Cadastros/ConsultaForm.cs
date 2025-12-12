using ConsultorioIFSP.App.Base;
using ConsultorioIFSP.App.Models;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;

namespace ConsultorioIFSP.App.Cadastros
{
    public partial class ConsultaForm : BaseForm
    {
        private readonly IBaseService<Consulta> _consultaService;
        private readonly IBaseService<Medico> _medicoService;
        private readonly IBaseService<Paciente> _pacienteService;
        private List<ConsultaModel>? consultas;

        // 2. Construtor para Injeção de Dependência
        public ConsultaForm(IBaseService<Consulta> consultaService,
                            IBaseService<Medico> medicoService,
                            IBaseService<Paciente> pacienteService) : base()
        {
            _consultaService = consultaService;
            _medicoService = medicoService;
            _pacienteService = pacienteService;
            InitializeComponent();
            CarregarComboBoxes();
        }

        private void CarregarComboBoxes()
        {
            // Carrega médicos
            var medicos = _medicoService.Get<MedicoModel>().ToList();
            cboMedico.DataSource = medicos;
            cboMedico.DisplayMember = "Nome";
            cboMedico.ValueMember = "Id";
            cboMedico.SelectedIndex = -1; // Deseleciona

            // Carrega pacientes
            var pacientes = _pacienteService.Get<PacienteModel>().ToList();
            cboPaciente.DataSource = pacientes;
            cboPaciente.DisplayMember = "Nome";
            cboPaciente.ValueMember = "Id";
            cboPaciente.SelectedIndex = -1;
        }

        private void PreencheObjeto(Consulta consulta)
        {
            // ... (Data da Consulta e Horário da Consulta) ...

            // Chaves Estrangeiras

            // 1. MedicoId (Correto)
            int medicoId = Convert.ToInt32(cboMedico.SelectedValue);
            if (medicoId <= 0)
            {
                throw new Exception("Selecione um Médico para a consulta.");
            }
            consulta.MedicoId = medicoId;


            // 2. PacienteId
            int pacienteId = Convert.ToInt32(cboPaciente.SelectedValue);
            if (pacienteId <= 0)
            {
                throw new Exception("Selecione um Paciente para a consulta.");
            }

            // CORREÇÃO CRÍTICA: Atribuir à Chave Estrangeira PacienteId
            consulta.PacienteId = pacienteId; // <--- CORREÇÃO FEITA AQUI
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var consulta = _consultaService.GetById<Consulta>(id);
                        PreencheObjeto(consulta);
                        _consultaService.Update<Consulta, Consulta, ConsultaValidator>(consulta);
                    }
                }
                else
                {
                    var consulta = new Consulta();
                    PreencheObjeto(consulta);
                    _consultaService.Add<Consulta, Consulta, ConsultaValidator>(consulta);
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

        protected override void Delete(int id)
        {
            try
            {
                _consultaService.Delete(id);
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
                consultas = _consultaService.Get<ConsultaModel>().ToList();
                dataGridViewList.DataSource = consultas;
                dataGridViewList.Columns["DataConsulta"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
            txtDataConsulta.Text = linha.Cells["DataConsulta"].Value?.ToString();

            // 2. Tratamento de Horário (TimeOnly ou TimeSpan)
            var horarioValue = linha.Cells["Horario"].Value;
            if (horarioValue is TimeOnly horarioTimeOnly)
            {
                // Se o valor já é TimeOnly (ideal)
                txtHorario.Text = horarioTimeOnly.ToString("HH\\:mm");
            }
            else if (horarioValue is TimeSpan horarioTimeSpan)
            {
                // Se o valor é TimeSpan (comum no MySQL)
                txtHorario.Text = TimeOnly.FromTimeSpan(horarioTimeSpan).ToString("HH\\:mm");
            }
            else
            {
                // Tenta converter o string bruto (fallback)
                txtHorario.Text = horarioValue?.ToString();
            }

            // 3. Carrega os ComboBoxes pelo ValueMember (Id)
            // O 'SelectedValue' define o item selecionado usando o 'ValueMember' (Id)
            cboMedico.SelectedValue = linha.Cells["MedicoId"].Value;
            cboPaciente.SelectedValue = linha.Cells["PacienteId"].Value;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}