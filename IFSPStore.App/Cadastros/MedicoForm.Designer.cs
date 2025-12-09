using ReaLTaiizor.Controls;

namespace ConsultorioIFSP.App.Cadastros
{
    partial class MedicoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // Declaração e Inicialização dos componentes necessários para o Medico
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEspecialidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtCrm = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtTelefone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Text = "Cadastro de Médico";

            // --- Configuração dos controles (Posicionamento Básico) ---

            // txtId (Oculto)
            this.txtId.Location = new System.Drawing.Point(10, 10);
            this.txtId.Size = new System.Drawing.Size(50, 48);
            this.txtId.Text = "ID";
            this.txtId.ReadOnly = true;
            this.txtId.Visible = false;

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(70, 50);
            this.txtNome.Size = new System.Drawing.Size(300, 48);
            this.txtNome.Text = "Nome Completo";

            // txtEspecialidade
            this.txtEspecialidade.Location = new System.Drawing.Point(70, 120);
            this.txtEspecialidade.Size = new System.Drawing.Size(200, 48);
            this.txtEspecialidade.Text = "Especialidade";

            // txtCrm
            this.txtCrm.Location = new System.Drawing.Point(300, 120);
            this.txtCrm.Size = new System.Drawing.Size(150, 48);
            this.txtCrm.Text = "CRM";

            // txtTelefone
            this.txtTelefone.Location = new System.Drawing.Point(70, 190);
            this.txtTelefone.Size = new System.Drawing.Size(200, 48);
            this.txtTelefone.Text = "Telefone";

            // txtLogin
            this.txtLogin.Location = new System.Drawing.Point(70, 260);
            this.txtLogin.Size = new System.Drawing.Size(200, 48);
            this.txtLogin.Text = "Login";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(300, 260);
            this.txtPassword.Size = new System.Drawing.Size(150, 48);
            this.txtPassword.Text = "Senha";
            this.txtPassword.UseSystemPasswordChar = true; // Oculta a senha

            // Adicionar os controles
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEspecialidade);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPassword);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        #region Declarações dos Componentes de Medico
        // Declarações dos controles
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCrm;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefone;
        #endregion
    }
}