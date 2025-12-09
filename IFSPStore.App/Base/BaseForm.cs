using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
namespace IFSPStore.App.Base
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
        private void tabControlRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlRegister.SelectedIndex == 0) 
            {
                this.AcceptButton = btnSave;
            }
            else 
            {
                this.AcceptButton = btnNew;
            }
        }

        private void dataGridViewList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
