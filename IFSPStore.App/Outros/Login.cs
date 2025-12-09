using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Service.Validator;
using ReaLTaiizor.Forms;
using System.Data;
using System.Linq;

namespace IFSPStore.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<User> _userService;
        public Login(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User? user = searchUser(txtUser.Text, txtPassword.Text);
            if (user != null)
            {
                MainForm.User = user; 
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }
        private User? searchUser(string login, string password)
        {
            checkValidUser();
            var user = _userService.Get<User>().Where(u => u.Login == login && u.Password == password)
                .FirstOrDefault();
            /*if (user != null)
            {
                return null;
            }*/
            return user;
        }
        private void checkValidUser()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any(u => u.Login == "admin"))
            {
                var user = new User
                {
                    Login = "admin",
                    Password = "admin",
                    Name = "Administrator do sistema",
                    IsActive = true,
                    RegisterDate = DateTime.Now,
                    LoginDate = DateTime.Now,
                    Email = "admin@gmail.com",
                };
                _userService.Add<User, User, UserValidator>(user);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
