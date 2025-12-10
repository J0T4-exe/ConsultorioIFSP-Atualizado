using ConsultorioIFSP.App.Base;
using ConsultorioIFSP.App.Models;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;

namespace ConsultorioIFSP.App.Cadastros
{
    public partial class ConsultaForm : BaseForm
    {
        // 1. Serviços específicos injetados
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
            // Data da Consulta
            if (!DateTime.TryParse(txtDataConsulta.Text, out DateTime dataConsulta))
            {
                throw new Exception("Data da Consulta inválida.");
            }
            consulta.DataConsulta = dataConsulta;

            // Horário da Consulta (TimeOnly)
            if (!TimeOnly.TryParse(txtHorario.Text, out TimeOnly horario))
            {
                throw new Exception("Horário inválido. Use o formato HH:MM.");
            }
            consulta.Horario = horario;

            // Chaves Estrangeiras

            int medicoId = Convert.ToInt32(cboMedico.SelectedValue);
            if (medicoId <= 0)
            {
                throw new Exception("Selecione um Médico para a consulta.");
            }
            consulta.MedicoId = medicoId;


            int pacienteId = Convert.ToInt32(cboPaciente.SelectedValue);
            if (pacienteId <= 0)
            {
                throw new Exception("Selecione um Paciente para a consulta.");
            }
            consulta.Paciente = pacienteId;
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
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtDataConsulta.Text = linha?.Cells["DataConsulta"].Value.ToString();

            // Tratamento de Horário (TimeOnly ou TimeSpan)
            if (linha?.Cells["Horario"].Value is TimeOnly horarioTimeOnly)
            {
                txtHorario.Text = horarioTimeOnly.ToString("HH\\:mm");
            }
            else if (linha?.Cells["Horario"].Value is TimeSpan horarioTimeSpan)
            {
                txtHorario.Text = TimeOnly.FromTimeSpan(horarioTimeSpan).ToString("HH\\:mm");
            }
            else
            {
                txtHorario.Text = linha?.Cells["Horario"].Value?.ToString();
            }

            // Carrega os ComboBoxes pelo ValueMember (Id)
            cboMedico.SelectedValue = linha?.Cells["MedicoId"].Value;
            cboPaciente.SelectedValue = linha?.Cells["PacienteId"].Value;
        }
    }
}