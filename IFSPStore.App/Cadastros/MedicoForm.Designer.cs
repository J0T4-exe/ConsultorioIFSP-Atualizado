namespace ConsultorioIFSP.App.Cadastros
{
    // A classe é renomeada para MedicoForm e deve herdar do seu BaseForm
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
            txtCrm = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEspecialidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Margin = new Padding(3, 5, 3, 5);
            tabPage2.Padding = new Padding(3, 5, 3, 5);
            tabPage2.Size = new Size(1034, 828);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(6, 71);
            tabControlRegister.Margin = new Padding(3, 5, 3, 5);
            tabControlRegister.Size = new Size(910, 578);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(txtLogin);
            tabPage1.Controls.Add(txtEspecialidade);
            tabPage1.Controls.Add(txtCrm);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtName);
            tabPage1.Margin = new Padding(3, 5, 3, 5);
            tabPage1.Padding = new Padding(3, 5, 3, 5);
            tabPage1.Size = new Size(902, 543);
            tabPage1.Controls.SetChildIndex(txtName, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtCrm, 0);
            tabPage1.Controls.SetChildIndex(txtEspecialidade, 0);
            tabPage1.Controls.SetChildIndex(txtLogin, 0);
            tabPage1.Controls.SetChildIndex(txtPassword, 0);
            tabPage1.Controls.SetChildIndex(txtEmail, 0);
            // 
            // txtCrm
            // 
            txtCrm.AnimateReadOnly = false;
            txtCrm.AutoCompleteMode = AutoCompleteMode.None;
            txtCrm.AutoCompleteSource = AutoCompleteSource.None;
            txtCrm.BackgroundImageLayout = ImageLayout.None;
            txtCrm.CharacterCasing = CharacterCasing.Normal;
            txtCrm.Depth = 0;
            txtCrm.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCrm.HideSelection = true;
            txtCrm.Hint = "CRM";
            txtCrm.LeadingIcon = null;
            txtCrm.Location = new Point(7, 80);
            txtCrm.Margin = new Padding(3, 4, 3, 4);
            txtCrm.MaxLength = 32767;
            txtCrm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCrm.Name = "txtCrm";
            txtCrm.PasswordChar = '\0';
            txtCrm.PrefixSuffixText = null;
            txtCrm.ReadOnly = false;
            txtCrm.RightToLeft = RightToLeft.No;
            txtCrm.SelectedText = "";
            txtCrm.SelectionLength = 0;
            txtCrm.SelectionStart = 0;
            txtCrm.ShortcutsEnabled = true;
            txtCrm.Size = new Size(343, 48);
            txtCrm.TabIndex = 4;
            txtCrm.TabStop = false;
            txtCrm.TextAlign = HorizontalAlignment.Left;
            txtCrm.TrailingIcon = null;
            txtCrm.UseSystemPasswordChar = false;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.AnimateReadOnly = false;
            txtEspecialidade.AutoCompleteMode = AutoCompleteMode.None;
            txtEspecialidade.AutoCompleteSource = AutoCompleteSource.None;
            txtEspecialidade.BackgroundImageLayout = ImageLayout.None;
            txtEspecialidade.CharacterCasing = CharacterCasing.Normal;
            txtEspecialidade.Depth = 0;
            txtEspecialidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEspecialidade.HideSelection = true;
            txtEspecialidade.Hint = "Especialidade";
            txtEspecialidade.LeadingIcon = null;
            txtEspecialidade.Location = new Point(357, 80);
            txtEspecialidade.Margin = new Padding(3, 4, 3, 4);
            txtEspecialidade.MaxLength = 32767;
            txtEspecialidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.PasswordChar = '\0';
            txtEspecialidade.PrefixSuffixText = null;
            txtEspecialidade.ReadOnly = false;
            txtEspecialidade.RightToLeft = RightToLeft.No;
            txtEspecialidade.SelectedText = "";
            txtEspecialidade.SelectionLength = 0;
            txtEspecialidade.SelectionStart = 0;
            txtEspecialidade.ShortcutsEnabled = true;
            txtEspecialidade.Size = new Size(343, 48);
            txtEspecialidade.TabIndex = 5;
            txtEspecialidade.TabStop = false;
            txtEspecialidade.TextAlign = HorizontalAlignment.Left;
            txtEspecialidade.TrailingIcon = null;
            txtEspecialidade.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "NOME";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(7, 8);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(697, 48);
            txtName.TabIndex = 3;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(711, 8);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(185, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtLogin.BackgroundImageLayout = ImageLayout.None;
            txtLogin.CharacterCasing = CharacterCasing.Normal;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.HideSelection = true;
            txtLogin.Hint = "LOGIN";
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(7, 152);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.MaxLength = 32767;
            txtLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PrefixSuffixText = null;
            txtLogin.ReadOnly = false;
            txtLogin.RightToLeft = RightToLeft.No;
            txtLogin.SelectedText = "";
            txtLogin.SelectionLength = 0;
            txtLogin.SelectionStart = 0;
            txtLogin.ShortcutsEnabled = true;
            txtLogin.Size = new Size(286, 48);
            txtLogin.TabIndex = 6;
            txtLogin.TabStop = false;
            txtLogin.TextAlign = HorizontalAlignment.Left;
            txtLogin.TrailingIcon = null;
            txtLogin.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "PASSWORD";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(457, 152);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(286, 48);
            txtPassword.TabIndex = 7;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "EMAIL";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(7, 224);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(686, 48);
            txtEmail.TabIndex = 8;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // MedicoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 649);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "MedicoForm";
            Padding = new Padding(3, 113, 3, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medical registration";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ----------------------------------------------------------------------
        // DECLARAÇÕES DOS CONTROLES
        // ----------------------------------------------------------------------
        // Novos controles específicos do Medico
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCrm;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEspecialidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
    }
}