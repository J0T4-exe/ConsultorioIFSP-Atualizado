using IFSPStore.App.Cadastros;
using IFSPStore.App.Infra;
using IFSPStore.App.Outros;
using IFSPStore.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class MainForm : MaterialForm
    {
        public static User? User { get; set; }
        public MainForm()
        {
            InitializeComponent();
            loadLogin();
        }
        private void loadLogin()
        {
            var login = ConfigureDI.serviceProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUser.Text = $"Usuário: {User?.Name}";
                }
            }
        }
        private void categorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<CategoryForm>();
        }
        void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<ProductForm>();
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<CustomerForm>();
        }
        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<SaleForm>();
        }
        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<CityForm>();
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<UserForm>();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<HelpForm>();
        }

        private void showForm<TFormulario>() where TFormulario : MaterialForm
        {
            //fecha todos os forms abertos dentro do mdi
            foreach (var forms in this.MdiChildren)
            {
                forms.Close();
            }
            var form = ConfigureDI.serviceProvider!.GetService<TFormulario>();
            if (form != null && !form.IsDisposed)
            {
                form.MdiParent = this;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
        }
    }
}

