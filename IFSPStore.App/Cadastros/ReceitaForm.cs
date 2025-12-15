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

        public ReceitaForm(IBaseService<Receita> receitaService,
                            IBaseService<Medico> medicoService,
                            IBaseService<Paciente> pacienteService) : base()
        {
            _receitaService = receitaService;
            _medicoService = medicoService;
            _pacienteService = pacienteService;
            InitializeComponent();
            CarregarComboBoxes();
        }

        private void CarregarComboBoxes()
        {
            var medicos = _medicoService.Get<MedicoModel>().ToList();
            cboMedicoId.DataSource = medicos;
            cboMedicoId.DisplayMember = "Nome";
            cboMedicoId.ValueMember = "Id";
            cboMedicoId.SelectedIndex = -1;

            var pacientes = _pacienteService.Get<PacienteModel>().ToList();
            cboPacienteId.DataSource = pacientes;
            cboPacienteId.DisplayMember = "Nome";
            cboPacienteId.ValueMember = "Id";
            cboPacienteId.SelectedIndex = -1;
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

            int medicoId = Convert.ToInt32(cboMedicoId.SelectedValue);
            if (medicoId <= 0)
            {
                throw new Exception("Selecione um Médico para a receita.");
            }
            receita.MedicoId = medicoId;

            int pacienteId = Convert.ToInt32(cboPacienteId.SelectedValue);
            if (pacienteId <= 0)
            {
                throw new Exception("Selecione um Paciente para a receita.");
            }
            receita.PacienteId = pacienteId;
        }

        protected override void Save()
        {
            try
            {
                Receita receita = IsEditMode && int.TryParse(txtId.Text, out var id) ?
                                  _receitaService.GetById<Receita>(id) ?? new Receita() : new Receita();

                PreencheObjeto(receita);

                if (IsEditMode)
                {
                    _receitaService.Update<Receita, Receita, ReceitaValidator>(receita);
                }
                else
                {
                    _receitaService.Add<Receita, Receita, ReceitaValidator>(receita);
                }

                CarregaGrid();
                tabControlRegister.SelectedIndex = 1;
                MessageBox.Show("Registro salvo com sucesso!", @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _receitaService.Delete(id);
                CarregaGrid();
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
                receitas = _receitaService.Get<ReceitaModel>().ToList();
                dataGridViewList.DataSource = receitas;

                if (dataGridViewList.Columns.Count > 0)
                {
                    foreach (DataGridViewColumn column in dataGridViewList.Columns)
                    {
                        column.Visible = false;

                        switch (column.Name)
                        {
                            case "Id":
                            case "MedicoId":
                            case "PacienteId":
                            case "Periodo":
                            case "Quantidade":
                                column.Visible = true;
                                column.HeaderText = column.Name switch
                                {
                                    "Id" => "ID",
                                    "MedicoId" => "ID Médico",
                                    "PacienteId" => "ID Paciente",
                                    "Periodo" => "Data Receita",
                                    "Quantidade" => "Quantidade",
                                    _ => column.HeaderText
                                };
                                column.AutoSizeMode = column.Name == "Quantidade" ?
                                    DataGridViewAutoSizeColumnMode.Fill : DataGridViewAutoSizeColumnMode.AllCells;

                                if (column.Name == "Periodo")
                                {
                                    column.DefaultCellStyle.Format = "dd/MM/yyyy";
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ConsultorioIFSP - Erro ao Carregar Grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            if (linha == null) return;

            txtId.Text = linha.Cells["Id"].Value?.ToString();
            txtQuantidade.Text = linha.Cells["Quantidade"].Value?.ToString();

            var periodoValue = linha.Cells["Periodo"].Value;
            if (periodoValue is DateTime periodoDate)
            {
                txtPeriodo.Text = periodoDate.ToString("dd/MM/yyyy");
            }
            else
            {
                txtPeriodo.Text = periodoValue?.ToString();
            }

            try
            {
                cboMedicoId.SelectedValue = linha.Cells["MedicoId"].Value;
                cboPacienteId.SelectedValue = linha.Cells["PacienteId"].Value;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Erro de Edição: A coluna {ex.ParamName} não foi encontrada. Verifique o nome da propriedade no seu ReceitaModel.", "Erro Crítico de Mapeamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}