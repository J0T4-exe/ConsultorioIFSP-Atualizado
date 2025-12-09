namespace ConsultorioIFSP.App.Cadastros
{
    partial class MedicamentoForm
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
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNomeGenerico = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtNomeGenerico);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtName);
            // Removendo referências a antigos campos de Produto/Venda
            // tabPage1.Controls.Remove(txtQuantity);
            // tabPage1.Controls.Remove(cboCategory);
            // tabPage1.Controls.Remove(txtSaleDate);
            // tabPage1.Controls.Remove(txtPrice);
            // tabPage1.Controls.Remove(txtSaleUnit);

            tabPage1.Controls.SetChildIndex(txtName, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtNomeGenerico, 0);
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
            txtName.Hint = "Nome do Medicamento";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(6, 6);
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
            txtName.Size = new Size(597, 48);
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
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(609, 6);
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
            txtId.Size = new Size(176, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtNomeGenerico
            // 
            txtNomeGenerico.AnimateReadOnly = false;
            txtNomeGenerico.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeGenerico.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeGenerico.BackgroundImageLayout = ImageLayout.None;
            txtNomeGenerico.CharacterCasing = CharacterCasing.Normal;
            txtNomeGenerico.Depth = 0;
            txtNomeGenerico.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeGenerico.HideSelection = true;
            txtNomeGenerico.Hint = "Nome Genérico";
            txtNomeGenerico.LeadingIcon = null;
            txtNomeGenerico.Location = new Point(6, 60);
            txtNomeGenerico.MaxLength = 32767;
            txtNomeGenerico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeGenerico.Name = "txtNomeGenerico";
            txtNomeGenerico.PasswordChar = '\0';
            txtNomeGenerico.PrefixSuffixText = null;
            txtNomeGenerico.ReadOnly = false;
            txtNomeGenerico.RightToLeft = RightToLeft.No;
            txtNomeGenerico.SelectedText = "";
            txtNomeGenerico.SelectionLength = 0;
            txtNomeGenerico.SelectionStart = 0;
            txtNomeGenerico.ShortcutsEnabled = true;
            txtNomeGenerico.Size = new Size(779, 48);
            txtNomeGenerico.TabIndex = 5;
            txtNomeGenerico.TabStop = false;
            txtNomeGenerico.TextAlign = HorizontalAlignment.Left;
            txtNomeGenerico.TrailingIcon = null;
            txtNomeGenerico.UseSystemPasswordChar = false;
            // 
            // MedicamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 562);
            Location = new Point(0, 0);
            Name = "MedicamentoForm";
            Text = "Cadastro de Medicamento";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Declaração dos controles:
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeGenerico;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
    }
}