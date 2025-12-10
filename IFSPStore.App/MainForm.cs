using ConsultorioIFSP.App.Cadastros;
using ConsultorioIFSP.App.Infra;
using ConsultorioIFSP.App.Outros;
using ConsultorioIFSP.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace ConsultorioIFSP.App
{
    public partial class MainForm : MaterialForm
    {
        public static Medico? Medico { get; set; }
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
                    lblUser.Text = $"Usuário: {Medico?.Nome}";
                }
            }
        }
        private void categorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<ConsultaForm>();
        }
        void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<MedicamentoForm>();
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<MedicoForm>();
        }
        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<PacienteForm>();
        }
        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm<ReceitaForm>();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

