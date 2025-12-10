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
            txtTelefone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataNascimento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSexo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabControlRegister.Location = new Point(-3, 66);
            tabControlRegister.Margin = new Padding(3, 5, 3, 5);
            tabControlRegister.Size = new Size(940, 415);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtSexo);
            tabPage1.Controls.Add(txtDataNascimento);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtName);
            tabPage1.Margin = new Padding(3, 5, 3, 5);
            tabPage1.Padding = new Padding(3, 5, 3, 5);
            tabPage1.Size = new Size(932, 380);
            tabPage1.Controls.SetChildIndex(txtName, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtEmail, 0);
            tabPage1.Controls.SetChildIndex(txtTelefone, 0);
            tabPage1.Controls.SetChildIndex(txtDataNascimento, 0);
            tabPage1.Controls.SetChildIndex(txtSexo, 0);
            // 
            // txtTelefone
            // 
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AutoCompleteMode = AutoCompleteMode.None;
            txtTelefone.AutoCompleteSource = AutoCompleteSource.None;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.CharacterCasing = CharacterCasing.Normal;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(7, 152);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.ReadOnly = false;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(394, 48);
            txtTelefone.TabIndex = 4;
            txtTelefone.TabStop = false;
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.AnimateReadOnly = false;
            txtDataNascimento.AutoCompleteMode = AutoCompleteMode.None;
            txtDataNascimento.AutoCompleteSource = AutoCompleteSource.None;
            txtDataNascimento.BackgroundImageLayout = ImageLayout.None;
            txtDataNascimento.CharacterCasing = CharacterCasing.Normal;
            txtDataNascimento.Depth = 0;
            txtDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataNascimento.HideSelection = true;
            txtDataNascimento.Hint = "Data Nascimento (dd/mm/aaaa)";
            txtDataNascimento.LeadingIcon = null;
            txtDataNascimento.Location = new Point(419, 152);
            txtDataNascimento.Margin = new Padding(3, 4, 3, 4);
            txtDataNascimento.MaxLength = 32767;
            txtDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PasswordChar = '\0';
            txtDataNascimento.PrefixSuffixText = null;
            txtDataNascimento.ReadOnly = false;
            txtDataNascimento.RightToLeft = RightToLeft.No;
            txtDataNascimento.SelectedText = "";
            txtDataNascimento.SelectionLength = 0;
            txtDataNascimento.SelectionStart = 0;
            txtDataNascimento.ShortcutsEnabled = true;
            txtDataNascimento.Size = new Size(286, 48);
            txtDataNascimento.TabIndex = 5;
            txtDataNascimento.TabStop = false;
            txtDataNascimento.TextAlign = HorizontalAlignment.Left;
            txtDataNascimento.TrailingIcon = null;
            txtDataNascimento.UseSystemPasswordChar = false;
            // 
            // txtSexo
            // 
            txtSexo.AnimateReadOnly = false;
            txtSexo.AutoCompleteMode = AutoCompleteMode.None;
            txtSexo.AutoCompleteSource = AutoCompleteSource.None;
            txtSexo.BackgroundImageLayout = ImageLayout.None;
            txtSexo.CharacterCasing = CharacterCasing.Normal;
            txtSexo.Depth = 0;
            txtSexo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSexo.HideSelection = true;
            txtSexo.Hint = "Sexo (M/F)";
            txtSexo.LeadingIcon = null;
            txtSexo.Location = new Point(7, 224);
            txtSexo.Margin = new Padding(3, 4, 3, 4);
            txtSexo.MaxLength = 32767;
            txtSexo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSexo.Name = "txtSexo";
            txtSexo.PasswordChar = '\0';
            txtSexo.PrefixSuffixText = null;
            txtSexo.ReadOnly = false;
            txtSexo.RightToLeft = RightToLeft.No;
            txtSexo.SelectedText = "";
            txtSexo.SelectionLength = 0;
            txtSexo.SelectionStart = 0;
            txtSexo.ShortcutsEnabled = true;
            txtSexo.Size = new Size(171, 48);
            txtSexo.TabIndex = 6;
            txtSexo.TabStop = false;
            txtSexo.TextAlign = HorizontalAlignment.Left;
            txtSexo.TrailingIcon = null;
            txtSexo.UseSystemPasswordChar = false;
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
            txtName.Hint = "Nome Completo";
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
            txtName.Size = new Size(698, 48);
            txtName.TabIndex = 1;
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
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(725, 8);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(172, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
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
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(7, 80);
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
            txtEmail.Size = new Size(698, 48);
            txtEmail.TabIndex = 3;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // PacienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 480);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "PacienteForm";
            Padding = new Padding(3, 113, 3, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Paciente";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
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