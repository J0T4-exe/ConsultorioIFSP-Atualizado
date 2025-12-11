namespace ConsultorioIFSP.App.Cadastros
{
    partial class ReceitaForm
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
            txtPeriodo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMedicoId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPacienteId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabControlRegister.Location = new Point(6, 72);
            tabControlRegister.Margin = new Padding(3, 5, 3, 5);
            tabControlRegister.Size = new Size(1003, 501);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtPacienteId);
            tabPage1.Controls.Add(txtMedicoId);
            tabPage1.Controls.Add(txtQuantidade);
            tabPage1.Controls.Add(txtPeriodo);
            tabPage1.Controls.Add(txtId);
            tabPage1.Margin = new Padding(3, 5, 3, 5);
            tabPage1.Padding = new Padding(3, 5, 3, 5);
            tabPage1.Size = new Size(995, 466);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtPeriodo, 0);
            tabPage1.Controls.SetChildIndex(txtQuantidade, 0);
            tabPage1.Controls.SetChildIndex(txtMedicoId, 0);
            tabPage1.Controls.SetChildIndex(txtPacienteId, 0);
            // 
            // txtPeriodo
            // 
            txtPeriodo.AnimateReadOnly = false;
            txtPeriodo.AutoCompleteMode = AutoCompleteMode.None;
            txtPeriodo.AutoCompleteSource = AutoCompleteSource.None;
            txtPeriodo.BackgroundImageLayout = ImageLayout.None;
            txtPeriodo.CharacterCasing = CharacterCasing.Normal;
            txtPeriodo.Depth = 0;
            txtPeriodo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPeriodo.HideSelection = true;
            txtPeriodo.Hint = "Período (dd/mm/aaaa)";
            txtPeriodo.LeadingIcon = null;
            txtPeriodo.Location = new Point(7, 8);
            txtPeriodo.Margin = new Padding(3, 4, 3, 4);
            txtPeriodo.MaxLength = 32767;
            txtPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.PasswordChar = '\0';
            txtPeriodo.PrefixSuffixText = null;
            txtPeriodo.ReadOnly = false;
            txtPeriodo.RightToLeft = RightToLeft.No;
            txtPeriodo.SelectedText = "";
            txtPeriodo.SelectionLength = 0;
            txtPeriodo.SelectionStart = 0;
            txtPeriodo.ShortcutsEnabled = true;
            txtPeriodo.Size = new Size(343, 48);
            txtPeriodo.TabIndex = 2;
            txtPeriodo.TabStop = false;
            txtPeriodo.TextAlign = HorizontalAlignment.Left;
            txtPeriodo.TrailingIcon = null;
            txtPeriodo.UseSystemPasswordChar = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Quantidade";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(357, 8);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(343, 48);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtMedicoId
            // 
            txtMedicoId.AnimateReadOnly = false;
            txtMedicoId.AutoCompleteMode = AutoCompleteMode.None;
            txtMedicoId.AutoCompleteSource = AutoCompleteSource.None;
            txtMedicoId.BackgroundImageLayout = ImageLayout.None;
            txtMedicoId.CharacterCasing = CharacterCasing.Normal;
            txtMedicoId.Depth = 0;
            txtMedicoId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMedicoId.HideSelection = true;
            txtMedicoId.Hint = "ID do Médico";
            txtMedicoId.LeadingIcon = null;
            txtMedicoId.Location = new Point(7, 80);
            txtMedicoId.Margin = new Padding(3, 4, 3, 4);
            txtMedicoId.MaxLength = 32767;
            txtMedicoId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMedicoId.Name = "txtMedicoId";
            txtMedicoId.PasswordChar = '\0';
            txtMedicoId.PrefixSuffixText = null;
            txtMedicoId.ReadOnly = false;
            txtMedicoId.RightToLeft = RightToLeft.No;
            txtMedicoId.SelectedText = "";
            txtMedicoId.SelectionLength = 0;
            txtMedicoId.SelectionStart = 0;
            txtMedicoId.ShortcutsEnabled = true;
            txtMedicoId.Size = new Size(343, 48);
            txtMedicoId.TabIndex = 4;
            txtMedicoId.TabStop = false;
            txtMedicoId.TextAlign = HorizontalAlignment.Left;
            txtMedicoId.TrailingIcon = null;
            txtMedicoId.UseSystemPasswordChar = false;
            // 
            // txtPacienteId
            // 
            txtPacienteId.AnimateReadOnly = false;
            txtPacienteId.AutoCompleteMode = AutoCompleteMode.None;
            txtPacienteId.AutoCompleteSource = AutoCompleteSource.None;
            txtPacienteId.BackgroundImageLayout = ImageLayout.None;
            txtPacienteId.CharacterCasing = CharacterCasing.Normal;
            txtPacienteId.Depth = 0;
            txtPacienteId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPacienteId.HideSelection = true;
            txtPacienteId.Hint = "ID do Paciente";
            txtPacienteId.LeadingIcon = null;
            txtPacienteId.Location = new Point(357, 80);
            txtPacienteId.Margin = new Padding(3, 4, 3, 4);
            txtPacienteId.MaxLength = 32767;
            txtPacienteId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPacienteId.Name = "txtPacienteId";
            txtPacienteId.PasswordChar = '\0';
            txtPacienteId.PrefixSuffixText = null;
            txtPacienteId.ReadOnly = false;
            txtPacienteId.RightToLeft = RightToLeft.No;
            txtPacienteId.SelectedText = "";
            txtPacienteId.SelectionLength = 0;
            txtPacienteId.SelectionStart = 0;
            txtPacienteId.ShortcutsEnabled = true;
            txtPacienteId.Size = new Size(343, 48);
            txtPacienteId.TabIndex = 5;
            txtPacienteId.TabStop = false;
            txtPacienteId.TextAlign = HorizontalAlignment.Left;
            txtPacienteId.TrailingIcon = null;
            txtPacienteId.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(171, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // ReceitaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 568);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "ReceitaForm";
            Padding = new Padding(3, 113, 3, 5);
            Text = "Cadastro de Receita";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ----------------------------------------------------------------------
        // DECLARAÇÕES DOS CONTROLES ESPECÍFICOS DO RECEITAFORM
        // ----------------------------------------------------------------------
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeriodo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMedicoId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPacienteId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId; // Necessário para acessar o Id na classe .cs
    }
}