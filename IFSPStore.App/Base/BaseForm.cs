using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
namespace ConsultaIFSP.App.Base
{
    public partial class BaseForm : MaterialForm
    {
        #region Declarações
        protected bool IsEditMode = false;
        #endregion
        #region Construtor
        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Eventos form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure cancel?", @"IFSP Store",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
                tabControlRegister.SelectedIndex = 1;
            }

        }
        #endregion
        #region Eventos CRUD
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Are you sure want delete?", @"IFSP Store",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewList.SelectedRows[0].Cells["Id"].Value;
                    Delete(id);
                    PopulateList();
                }
            }
            else
            {
                MessageBox.Show(@"Please, select any row!", @"IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabPageList_Enter(object sender, EventArgs e)
        {
            PopulateList();
        }
        private void ClearFields()
        {
            IsEditMode = false;
            foreach (var control in tabControlRegister.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                    textBox.Clear();

                if (control is MaterialMaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
            }
        }

        protected virtual void CarregaGrid()
        {

        }

        protected virtual void New()
        {
            ClearFields();
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Focus();
        }

        protected virtual void Save()
        {

        }

        protected virtual void Edit()
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                IsEditMode = true;
                var record = dataGridViewList.SelectedRows[0];
                GridToForm(record);
                loadList(record);
                tabControlRegister.SelectedIndex = 0;
                tabControlRegister.Focus();
            }
            else
            {
                MessageBox.Show(@"Please, select any row", @"IFSP Store",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        protected virtual void loadList(DataGridViewRow? record)
        {

        }
        protected virtual void GridToForm(DataGridViewRow? record)
        {

        }
        protected virtual void Delete(int id)
        {

        }

        protected virtual void PopulateList()
        {
            CarregaGrid();
        }

        #endregion

        private void dataGridViewList_CellDoubleClick(object sender, EventArgs e)
        {
            Edit();
        }

        // --- Implementação dos Métodos Virtuais de CRUD ---

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao) // IsAlteracao é herdado
                {
                    // Update
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var receita = _receitaService.GetById<Receita>(id);
                        PreencheObjeto(receita);
                        // Chama o serviço de Update com o ReceitaValidator
                        receita = _receitaService.Update<Receita, Receita, ReceitaValidator>(receita);
                    }
                }
                else
                {
                    // Add
                    var receita = new Receita();
                    PreencheObjeto(receita);
                    // Chama o serviço de Add com o ReceitaValidator
                    receita = _receitaService.Add<Receita, Receita, ReceitaValidator>(receita);
                }

                // tabControlCadastro é herdado e setado para a lista
                tabControlCadastro.SelectedIndex = 1;
                CarregaGrid();
                MessageBox.Show("Registro salvo com sucesso!", @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _receitaService.Delete(id);
                MessageBox.Show("Registro excluído com sucesso!", @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ConsultorioIFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            // Mapeia os dados da linha selecionada para os campos do formulário para o modo "Editar"
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtLogin.Text = linha?.Cells["Login"].Value.ToString();
            txtPassword.Text = linha?.Cells["Password"].Value.ToString();
            txtEspecialidade.Text = linha?.Cells["Especialidade"].Value.ToString();
            txtCrm.Text = linha?.Cells["Crm"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
        }
    }
}
