using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;
using ReaLTaiizor.Forms;

namespace ConsultorioIFSP.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<Medico> _medicoService;

        public Login(IBaseService<Medico> medicoService)
        {
            _medicoService = medicoService;
            InitializeComponent();
            this.AcceptButton = btnLogin;
            checkValidUser(); 
        }
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Medico? medico = searchUser(txtUser.Text, txtPassword.Text);

            if (medico != null)
            {
                MainForm.Medico = medico;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        private Medico? searchUser(string login, string password)
        {
            var medico = _medicoService.Get<Medico>()
                .Where(u => u.Login == login && u.Password == password)
                .FirstOrDefault();

            return medico;
        }

        private void checkValidUser()
        {
            var medicosCadastrados = _medicoService.Get<Medico>().ToList();

            if (!medicosCadastrados.Any(u => u.Login == "admin"))
            {
                var medico = new Medico
                {
                    Login = "admin",
                    Password = "admin99",
                    Nome = "Administrator do sistema",
                    Crm = "99999", 
                    Telefone = "11999998888",
                    Especialidade = "Administracao",
                    Email = "Email@gmail.com"
                };

                _medicoService.Add<Medico, Medico, MedicoValidator>(medico);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}