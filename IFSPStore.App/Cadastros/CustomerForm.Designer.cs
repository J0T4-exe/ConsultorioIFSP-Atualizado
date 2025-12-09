namespace IFSPStore.App.Cadastros
{
    partial class CustomerForm
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
            txtAdress = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDistrict = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCity = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDocument = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtDocument);
            tabPage1.Controls.Add(cboCity);
            tabPage1.Controls.Add(txtDistrict);
            tabPage1.Controls.Add(txtAdress);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.SetChildIndex(txtName, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtAdress, 0);
            tabPage1.Controls.SetChildIndex(txtDistrict, 0);
            tabPage1.Controls.SetChildIndex(cboCity, 0);
            tabPage1.Controls.SetChildIndex(txtDocument, 0);
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
            txtName.Hint = "Name";
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
            txtName.Size = new Size(564, 48);
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
            txtId.Location = new Point(576, 6);
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
            txtId.Size = new Size(208, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtAdress
            // 
            txtAdress.AnimateReadOnly = false;
            txtAdress.AutoCompleteMode = AutoCompleteMode.None;
            txtAdress.AutoCompleteSource = AutoCompleteSource.None;
            txtAdress.BackgroundImageLayout = ImageLayout.None;
            txtAdress.CharacterCasing = CharacterCasing.Normal;
            txtAdress.Depth = 0;
            txtAdress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAdress.HideSelection = true;
            txtAdress.Hint = "Adress";
            txtAdress.LeadingIcon = null;
            txtAdress.Location = new Point(6, 60);
            txtAdress.MaxLength = 32767;
            txtAdress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAdress.Name = "txtAdress";
            txtAdress.PasswordChar = '\0';
            txtAdress.PrefixSuffixText = null;
            txtAdress.ReadOnly = false;
            txtAdress.RightToLeft = RightToLeft.No;
            txtAdress.SelectedText = "";
            txtAdress.SelectionLength = 0;
            txtAdress.SelectionStart = 0;
            txtAdress.ShortcutsEnabled = true;
            txtAdress.Size = new Size(778, 48);
            txtAdress.TabIndex = 5;
            txtAdress.TabStop = false;
            txtAdress.TextAlign = HorizontalAlignment.Left;
            txtAdress.TrailingIcon = null;
            txtAdress.UseSystemPasswordChar = false;
            // 
            // txtDistrict
            // 
            txtDistrict.AnimateReadOnly = false;
            txtDistrict.AutoCompleteMode = AutoCompleteMode.None;
            txtDistrict.AutoCompleteSource = AutoCompleteSource.None;
            txtDistrict.BackgroundImageLayout = ImageLayout.None;
            txtDistrict.CharacterCasing = CharacterCasing.Normal;
            txtDistrict.Depth = 0;
            txtDistrict.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDistrict.HideSelection = true;
            txtDistrict.Hint = "District";
            txtDistrict.LeadingIcon = null;
            txtDistrict.Location = new Point(6, 114);
            txtDistrict.MaxLength = 32767;
            txtDistrict.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDistrict.Name = "txtDistrict";
            txtDistrict.PasswordChar = '\0';
            txtDistrict.PrefixSuffixText = null;
            txtDistrict.ReadOnly = false;
            txtDistrict.RightToLeft = RightToLeft.No;
            txtDistrict.SelectedText = "";
            txtDistrict.SelectionLength = 0;
            txtDistrict.SelectionStart = 0;
            txtDistrict.ShortcutsEnabled = true;
            txtDistrict.Size = new Size(778, 48);
            txtDistrict.TabIndex = 6;
            txtDistrict.TabStop = false;
            txtDistrict.TextAlign = HorizontalAlignment.Left;
            txtDistrict.TrailingIcon = null;
            txtDistrict.UseSystemPasswordChar = false;
            // 
            // cboCity
            // 
            cboCity.AutoResize = false;
            cboCity.BackColor = Color.FromArgb(255, 255, 255);
            cboCity.Depth = 0;
            cboCity.DrawMode = DrawMode.OwnerDrawVariable;
            cboCity.DropDownHeight = 174;
            cboCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCity.DropDownWidth = 121;
            cboCity.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCity.FormattingEnabled = true;
            cboCity.Hint = "City";
            cboCity.IntegralHeight = false;
            cboCity.ItemHeight = 43;
            cboCity.Location = new Point(6, 222);
            cboCity.MaxDropDownItems = 4;
            cboCity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCity.Name = "cboCity";
            cboCity.Size = new Size(778, 49);
            cboCity.StartIndex = 0;
            cboCity.TabIndex = 7;
            // 
            // txtDocument
            // 
            txtDocument.AnimateReadOnly = false;
            txtDocument.AutoCompleteMode = AutoCompleteMode.None;
            txtDocument.AutoCompleteSource = AutoCompleteSource.None;
            txtDocument.BackgroundImageLayout = ImageLayout.None;
            txtDocument.CharacterCasing = CharacterCasing.Normal;
            txtDocument.Depth = 0;
            txtDocument.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDocument.HideSelection = true;
            txtDocument.Hint = "Document";
            txtDocument.LeadingIcon = null;
            txtDocument.Location = new Point(6, 168);
            txtDocument.MaxLength = 32767;
            txtDocument.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDocument.Name = "txtDocument";
            txtDocument.PasswordChar = '\0';
            txtDocument.PrefixSuffixText = null;
            txtDocument.ReadOnly = false;
            txtDocument.RightToLeft = RightToLeft.No;
            txtDocument.SelectedText = "";
            txtDocument.SelectionLength = 0;
            txtDocument.SelectionStart = 0;
            txtDocument.ShortcutsEnabled = true;
            txtDocument.Size = new Size(777, 48);
            txtDocument.TabIndex = 8;
            txtDocument.TabStop = false;
            txtDocument.TextAlign = HorizontalAlignment.Left;
            txtDocument.TrailingIcon = null;
            txtDocument.UseSystemPasswordChar = false;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 558);
            Location = new Point(0, 0);
            Name = "CustomerForm";
            Text = "Customer ​​registration";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDistrict;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAdress;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialComboBox cboCity;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDocument;
    }
}