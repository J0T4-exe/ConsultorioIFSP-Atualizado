namespace ConsultorioIFSP.App.Cadastros
{
    // A classe é PacienteForm e herda do seu BaseForm
    partial class PacienteForm
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
            // TextBoxes específicos do Paciente
            this.txtTelefone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDataNascimento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtSexo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();

            // TextBoxes Comuns
            this.txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();

            // Campos que NÃO serão usados, mas devem ser declarados como place holders 
            // se o BaseForm os exigir ou se você optar por colocá-los no designer.
            // Eles foram removidos para simplificar o formulário do Paciente.
            // this.txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            // this.txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            // this.chkActive = new ReaLTaiizor.Controls.MaterialCheckBox();
            // this.txtRegistrationDate = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            // this.txtLastLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();

            this.tabControlRegister.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            // Adicionando os controles de Paciente à primeira página de cadastro
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.txtDataNascimento);
            this.tabPage1.Controls.Add(this.txtSexo);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.txtName);

            // Removendo referências a controles que não são usados no paciente
            // Ex: tabPage1.Controls.Remove(txtLogin);

            // Reajuste a ordem de tabulação se necessário
            this.tabPage1.Controls.SetChildIndex(this.txtName, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtId, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtEmail, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtTelefone, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtDataNascimento, 0);
            this.tabPage1.Controls.SetChildIndex(this.txtSexo, 0);

            // ----------------------------------------------------------------------
            // txtName (Mantém a posição no topo)
            // ----------------------------------------------------------------------
            this.txtName.AnimateReadOnly = false;
            // ... (propriedades)
            this.txtName.Hint = "Nome Completo";
            this.txtName.Location = new System.Drawing.Point(6, 6);
            // ... (outras propriedades)
            this.txtName.TabIndex = 1;

            // ----------------------------------------------------------------------
            // txtId (Mantém a posição no topo direito)
            // ----------------------------------------------------------------------
            this.txtId.AnimateReadOnly = false;
            // ... (propriedades)
            this.txtId.Hint = "Id";
            this.txtId.Location = new System.Drawing.Point(622, 6);
            // ... (outras propriedades)
            this.txtId.TabIndex = 2;
            this.txtId.ReadOnly = true;

            // ----------------------------------------------------------------------
            // txtEmail (Mantém a posição abaixo de Name)
            // ----------------------------------------------------------------------
            this.txtEmail.AnimateReadOnly = false;
            // ... (propriedades)
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(6, 60);
            // ... (outras propriedades)
            this.txtEmail.TabIndex = 3;

            // ----------------------------------------------------------------------
            // NOVO: txtTelefone
            // ----------------------------------------------------------------------
            this.txtTelefone.AnimateReadOnly = false;
            // ... (propriedades)
            this.txtTelefone.Hint = "Telefone";
            this.txtTelefone.Location = new System.Drawing.Point(6, 114);
            this.txtTelefone.Size = new System.Drawing.Size(300, 48);
            this.txtTelefone.TabIndex = 4;

            // ----------------------------------------------------------------------
            // NOVO: txtDataNascimento
            // ----------------------------------------------------------------------
            this.txtDataNascimento.AnimateReadOnly = false;
            // ... (propriedades)
            this.txtDataNascimento.Hint = "Data Nascimento (dd/mm/aaaa)";
            this.txtDataNascimento.Location = new System.Drawing.Point(312, 114);
            this.txtDataNascimento.Size = new System.Drawing.Size(250, 48);
            this.txtDataNascimento.TabIndex = 5;

            // ----------------------------------------------------------------------
            // NOVO: txtSexo
            // ----------------------------------------------------------------------
            this.txtSexo.AnimateReadOnly = false;
            // ... (propriedades)
            this.txtSexo.Hint = "Sexo (M/F)";
            this.txtSexo.Location = new System.Drawing.Point(6, 168);
            this.txtSexo.Size = new System.Drawing.Size(150, 48);
            this.txtSexo.TabIndex = 6;

            // ----------------------------------------------------------------------
            // Configurações Finais
            // ----------------------------------------------------------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 556);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PacienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Paciente"; // Título ajustado
            this.tabControlRegister.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // ----------------------------------------------------------------------
        // DECLARAÇÕES DOS CONTROLES
        // ----------------------------------------------------------------------
        // Controles Comuns
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;

        // Controles Específicos do Paciente
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTelefone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDataNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSexo;

        // NOTA: Se você precisa de txtRegistrationDate ou txtLastLogin 
        // em um formulário herdado, declare-os aqui:
        // private ReaLTaiizor.Controls.MaterialTextBoxEdit txtRegistrationDate;
        // private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLastLogin;
    }
}