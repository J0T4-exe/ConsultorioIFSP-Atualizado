namespace IFSPStore.App.Cadastros
{
    partial class ProductForm
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
            txtSaleUnit = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtSaleDate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboCategory = new ReaLTaiizor.Controls.MaterialComboBox();
            txtQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtQuantity);
            tabPage1.Controls.Add(cboCategory);
            tabPage1.Controls.Add(txtSaleDate);
            tabPage1.Controls.Add(txtPrice);
            tabPage1.Controls.Add(txtSaleUnit);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.SetChildIndex(txtName, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtSaleUnit, 0);
            tabPage1.Controls.SetChildIndex(txtPrice, 0);
            tabPage1.Controls.SetChildIndex(txtSaleDate, 0);
            tabPage1.Controls.SetChildIndex(cboCategory, 0);
            tabPage1.Controls.SetChildIndex(txtQuantity, 0);
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
            // txtSaleUnit
            // 
            txtSaleUnit.AnimateReadOnly = false;
            txtSaleUnit.AutoCompleteMode = AutoCompleteMode.None;
            txtSaleUnit.AutoCompleteSource = AutoCompleteSource.None;
            txtSaleUnit.BackgroundImageLayout = ImageLayout.None;
            txtSaleUnit.CharacterCasing = CharacterCasing.Normal;
            txtSaleUnit.Depth = 0;
            txtSaleUnit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSaleUnit.HideSelection = true;
            txtSaleUnit.Hint = "SaleUnit";
            txtSaleUnit.LeadingIcon = null;
            txtSaleUnit.Location = new Point(262, 60);
            txtSaleUnit.MaxLength = 32767;
            txtSaleUnit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSaleUnit.Name = "txtSaleUnit";
            txtSaleUnit.PasswordChar = '\0';
            txtSaleUnit.PrefixSuffixText = null;
            txtSaleUnit.ReadOnly = false;
            txtSaleUnit.RightToLeft = RightToLeft.No;
            txtSaleUnit.SelectedText = "";
            txtSaleUnit.SelectionLength = 0;
            txtSaleUnit.SelectionStart = 0;
            txtSaleUnit.ShortcutsEnabled = true;
            txtSaleUnit.Size = new Size(341, 48);
            txtSaleUnit.TabIndex = 6;
            txtSaleUnit.TabStop = false;
            txtSaleUnit.TextAlign = HorizontalAlignment.Left;
            txtSaleUnit.TrailingIcon = null;
            txtSaleUnit.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            txtPrice.AllowPromptAsInput = true;
            txtPrice.AnimateReadOnly = false;
            txtPrice.AsciiOnly = false;
            txtPrice.BackgroundImageLayout = ImageLayout.None;
            txtPrice.BeepOnError = false;
            txtPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrice.Depth = 0;
            txtPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrice.HidePromptOnLeave = false;
            txtPrice.HideSelection = true;
            txtPrice.Hint = "Price";
            txtPrice.InsertKeyMode = InsertKeyMode.Default;
            txtPrice.LeadingIcon = null;
            txtPrice.Location = new Point(6, 60);
            txtPrice.Mask = "999999.99";
            txtPrice.MaxLength = 32767;
            txtPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PrefixSuffixText = null;
            txtPrice.PromptChar = '_';
            txtPrice.ReadOnly = false;
            txtPrice.RejectInputOnFirstFailure = false;
            txtPrice.ResetOnPrompt = true;
            txtPrice.ResetOnSpace = true;
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.SelectedText = "";
            txtPrice.SelectionLength = 0;
            txtPrice.SelectionStart = 0;
            txtPrice.ShortcutsEnabled = true;
            txtPrice.Size = new Size(250, 48);
            txtPrice.SkipLiterals = true;
            txtPrice.TabIndex = 7;
            txtPrice.TabStop = false;
            txtPrice.Text = "      ,";
            txtPrice.TextAlign = HorizontalAlignment.Left;
            txtPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrice.TrailingIcon = null;
            txtPrice.UseSystemPasswordChar = false;
            txtPrice.ValidatingType = null;
            // 
            // txtSaleDate
            // 
            txtSaleDate.AllowPromptAsInput = true;
            txtSaleDate.AnimateReadOnly = false;
            txtSaleDate.AsciiOnly = false;
            txtSaleDate.BackgroundImageLayout = ImageLayout.None;
            txtSaleDate.BeepOnError = false;
            txtSaleDate.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtSaleDate.Depth = 0;
            txtSaleDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSaleDate.HidePromptOnLeave = false;
            txtSaleDate.HideSelection = true;
            txtSaleDate.Hint = "Sale Date";
            txtSaleDate.InsertKeyMode = InsertKeyMode.Default;
            txtSaleDate.LeadingIcon = null;
            txtSaleDate.Location = new Point(609, 60);
            txtSaleDate.Mask = "99/99/9999";
            txtSaleDate.MaxLength = 32767;
            txtSaleDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSaleDate.Name = "txtSaleDate";
            txtSaleDate.PasswordChar = '\0';
            txtSaleDate.PrefixSuffixText = null;
            txtSaleDate.PromptChar = '_';
            txtSaleDate.ReadOnly = false;
            txtSaleDate.RejectInputOnFirstFailure = false;
            txtSaleDate.ResetOnPrompt = true;
            txtSaleDate.ResetOnSpace = true;
            txtSaleDate.RightToLeft = RightToLeft.No;
            txtSaleDate.SelectedText = "";
            txtSaleDate.SelectionLength = 0;
            txtSaleDate.SelectionStart = 0;
            txtSaleDate.ShortcutsEnabled = true;
            txtSaleDate.Size = new Size(175, 48);
            txtSaleDate.SkipLiterals = true;
            txtSaleDate.TabIndex = 8;
            txtSaleDate.TabStop = false;
            txtSaleDate.Text = "  /  /";
            txtSaleDate.TextAlign = HorizontalAlignment.Left;
            txtSaleDate.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSaleDate.TrailingIcon = null;
            txtSaleDate.UseSystemPasswordChar = false;
            txtSaleDate.ValidatingType = null;
            // 
            // cboCategory
            // 
            cboCategory.AutoResize = false;
            cboCategory.BackColor = Color.FromArgb(255, 255, 255);
            cboCategory.Depth = 0;
            cboCategory.DrawMode = DrawMode.OwnerDrawVariable;
            cboCategory.DropDownHeight = 174;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.DropDownWidth = 121;
            cboCategory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.IntegralHeight = false;
            cboCategory.ItemHeight = 43;
            cboCategory.Location = new Point(262, 113);
            cboCategory.MaxDropDownItems = 4;
            cboCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(519, 49);
            cboCategory.StartIndex = 0;
            cboCategory.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantity.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.CharacterCasing = CharacterCasing.Normal;
            txtQuantity.Depth = 0;
            txtQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantity.HideSelection = true;
            txtQuantity.Hint = "Quantity";
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(6, 114);
            txtQuantity.MaxLength = 32767;
            txtQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PrefixSuffixText = null;
            txtQuantity.ReadOnly = false;
            txtQuantity.RightToLeft = RightToLeft.No;
            txtQuantity.SelectedText = "";
            txtQuantity.SelectionLength = 0;
            txtQuantity.SelectionStart = 0;
            txtQuantity.ShortcutsEnabled = true;
            txtQuantity.Size = new Size(250, 48);
            txtQuantity.TabIndex = 11;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 562);
            Location = new Point(0, 0);
            Name = "ProductForm";
            Text = "Product ​​registration";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtSaleDate;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPrice;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSaleUnit;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategory;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantity;
    }
}