using ConsultorioIFSP.App.Base;
using ConsultorioIFSP.App.Models;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace ConsultorioIFSP.App.Cadastros
{
    public partial class MedicamentoForm : BaseForm
    {
        private readonly IBaseService<Medicamento> _medicamentoService;
        private List<MedicamentoModel>? medicamentos;

        public MedicamentoForm(IBaseService<Medicamento> medicamentoService)
        {
            _medicamentoService = medicamentoService;
            InitializeComponent();
        }

        private void PreencheObjetoEntidade(Medicamento medicamento)
        {
            // Mapeamento dos campos string
            medicamento.Nome = txtName.Text;
            medicamento.Nome_Generico = txtNomeGenerico.Text;

        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var medicamento = _medicamentoService.GetById<Medicamento>(id);

                        // Chamada para o método de preenchimento
                        PreencheObjetoEntidade(medicamento);

                        medicamento = _medicamentoService.Update<Medicamento, Medicamento, MedicamentoValidator>(medicamento);
                    }
                }
                else
                {
                    var medicamento = new Medicamento();

                    // Chamada para o método de preenchimento
                    PreencheObjetoEntidade(medicamento);

                    _medicamentoService.Add<Medicamento, Medicamento, MedicamentoValidator>(medicamento);

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
                _medicamentoService.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultorio IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            // Assumindo que você tem um DTO MedicamentoModel para exibir no grid
            medicamentos = _medicamentoService.Get<MedicamentoModel>().ToList();
            dataGridViewList.DataSource = medicamentos;

            // Ajuste de colunas
            if (dataGridViewList.Columns.Contains("Nome_Generico"))
            {
                dataGridViewList.Columns["Nome_Generico"]!.HeaderText = "Nome Genérico";
            }
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Nome"].Value.ToString();
            txtNomeGenerico.Text = linha?.Cells["Nome_Generico"].Value.ToString();
        }
    }
}