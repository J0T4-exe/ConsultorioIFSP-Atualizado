using IFSPStore.App.Base;
using IFSPStore.App.Models;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;

namespace IFSPStore.App.Cadastros
{
    public partial class UserForm : BaseForm
    {
        private readonly IBaseService<User> _userService;
        private List<UserModel>? users;
        public UserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
            txtRegistrationDate.Text = DateTime.Now.ToString("g");
        }
        private void PreencheObjeto(User user)
        {
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            user.IsActive = chkActive.Checked;
            if (user.Id == 0)
            {
                user.RegisterDate = DateTime.Now;
                user.LoginDate = DateTime.Now; // Valor inicial
            }
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    // MODO EDIÇÃO
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var user = _userService.GetById<User>(id);
                        if (user != null)
                        {
                            PreencheObjeto(user);
                            user = _userService.Update<User, User, UserValidator>(user);
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado no banco de dados.");
                        }
                    }
                }
                else
                {
                    // MODO NOVO
                    var user = new User();
                    PreencheObjeto(user);
                    _userService.Add<User, User, UserValidator>(user);
                }
                CarregaGrid();
                tabControlRegister.SelectedIndex = 1; // Volta para a lista
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _userService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            users = _userService.Get<UserModel>().ToList();
            dataGridViewList.DataSource = users;
            dataGridViewList.Columns["Password"]!.Visible = false;
            dataGridViewList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected override void loadList(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtName.Text = linha?.Cells["Name"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtLogin.Text = linha?.Cells["Login"].Value.ToString();
            txtPassword.Text = linha?.Cells["Password"].Value.ToString();
            chkActive.Checked = (bool)(linha?.Cells["IsActive"].Value ?? false);

            txtRegistrationDate.Text = DateTime.TryParse(linha?.Cells["RegisterDate"].Value.ToString(), out var dataC)
                ? dataC.ToString("g")
                : "";

            txtLastLogin.Text = DateTime.TryParse(linha?.Cells["LoginDate"].Value.ToString(), out var dataL)
                ? dataL.ToString("g")
                : "";
        }
        protected override void GridToForm(DataGridViewRow? row)
        {
            if (row != null)
            {
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtLogin.Text = row.Cells["login"].Value.ToString();

                if (row.Cells["IsActive"].Value != null)
                {
                    chkActive.Checked = (bool)row.Cells["IsActive"].Value;
                }
            }
        }
    }
}
