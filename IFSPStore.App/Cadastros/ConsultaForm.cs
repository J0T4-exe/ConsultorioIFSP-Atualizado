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
            cboMedico.SelectedIndex = -1; 

            // Carrega pacientes
            var pacientes = _pacienteService.Get<PacienteModel>().ToList();
            cboPaciente.DataSource = pacientes;
            cboPaciente.DisplayMember = "Nome";
            cboPaciente.ValueMember = "Id";
            cboPaciente.SelectedIndex = -1;
        }

        private void PreencheObjeto(Consulta consulta)
        {
            if (DateTime.TryParse(txtDataConsulta.Text, out DateTime dataConsulta))
            {
                consulta.DataConsulta = dataConsulta;
            }
            if (TimeSpan.TryParse(txtHorario.Text, out TimeSpan horarioTimeSpan))
            {
                // Converte explicitamente TimeSpan para TimeOnly
                consulta.Horario = TimeOnly.FromTimeSpan(horarioTimeSpan);
            }
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

            consulta.PacienteId = pacienteId;
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

                if (dataGridViewList.Columns.Count > 0)
                {
                    foreach (DataGridViewColumn column in dataGridViewList.Columns)
                    {
                        column.Visible = false;

                        switch (column.Name)
                        {
                            case "Id":
                                column.Visible = true;
                                column.HeaderText = "ID";
                                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;

                            case "MedicoId":
                            case "Medicold":
                                column.Visible = true;
                                column.HeaderText = "ID Médico";
                                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;

                            case "PacienteId":
                                column.Visible = true;
                                column.HeaderText = "ID Paciente";
                                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;

                            case "DataConsulta":
                                column.Visible = true;
                                column.HeaderText = "Data";
                                column.DefaultCellStyle.Format = "dd/MM/yyyy"; 
                                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                break;
                            case "Horario":
                                column.Visible = true;
                                column.HeaderText = "Horário";
                                column.DefaultCellStyle.Format = "HH:mm";
                                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            if (linha == null) return;

            txtId.Text = linha.Cells["Id"].Value?.ToString();

            var dataConsultaValue = linha.Cells["DataConsulta"].Value;
            if (dataConsultaValue is DateTime dataConsultaDate && dataConsultaDate > DateTime.MinValue)
            {
                txtDataConsulta.Text = dataConsultaDate.ToString("dd/MM/yyyy");
            }
            else
            {
                txtDataConsulta.Text = string.Empty;
            }
            var horarioValue = linha.Cells["Horario"].Value;
            if (horarioValue != null)
            {
                if (horarioValue is TimeSpan horarioTimeSpan)
                {
                    txtHorario.Text = TimeOnly.FromTimeSpan(horarioTimeSpan).ToString("HH\\:mm");
                }
                else if (horarioValue is DateTime horarioDateTime && horarioDateTime > DateTime.MinValue)
                {                    txtHorario.Text = horarioDateTime.ToString("HH\\:mm");
                }
                else
                {
                    txtHorario.Text = string.Empty;
                }
            }
            else
            {
                txtHorario.Text = string.Empty;
            }

            cboMedico.SelectedValue = linha.Cells["MedicoId"].Value;
            cboPaciente.SelectedValue = linha.Cells["PacienteId"].Value;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}