namespace IFSPStore.App.Cadastros
{
    partial class SaleForm
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
            txtSaleDate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboUser = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCustomer = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBoxItens = new GroupBox();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            cboCategory = new ReaLTaiizor.Controls.MaterialComboBox();
            txtQuantity = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dataGridViewItens = new DataGridView();
            btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            txtTotalPrice = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrice = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSaleUnit = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboProduct = new ReaLTaiizor.Controls.MaterialComboBox();
            lblQtdItens = new ReaLTaiizor.Controls.MaterialLabel();
            lblTotalPrice = new ReaLTaiizor.Controls.MaterialLabel();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Size = new Size(790, 597);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(798, 632);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblTotalPrice);
            tabPage1.Controls.Add(lblQtdItens);
            tabPage1.Controls.Add(groupBoxItens);
            tabPage1.Controls.Add(cboCustomer);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(cboUser);
            tabPage1.Controls.Add(txtSaleDate);
            tabPage1.Size = new Size(790, 597);
            tabPage1.Controls.SetChildIndex(txtSaleDate, 0);
            tabPage1.Controls.SetChildIndex(cboUser, 0);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(cboCustomer, 0);
            tabPage1.Controls.SetChildIndex(groupBoxItens, 0);
            tabPage1.Controls.SetChildIndex(lblQtdItens, 0);
            tabPage1.Controls.SetChildIndex(lblTotalPrice, 0);
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
            txtSaleDate.Location = new Point(6, 6);
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
            txtSaleDate.Size = new Size(353, 48);
            txtSaleDate.SkipLiterals = true;
            txtSaleDate.TabIndex = 3;
            txtSaleDate.TabStop = false;
            txtSaleDate.Text = "  /  /";
            txtSaleDate.TextAlign = HorizontalAlignment.Left;
            txtSaleDate.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtSaleDate.TrailingIcon = null;
            txtSaleDate.UseSystemPasswordChar = false;
            txtSaleDate.ValidatingType = null;
            // 
            // cboUser
            // 
            cboUser.AutoResize = false;
            cboUser.BackColor = Color.FromArgb(255, 255, 255);
            cboUser.Depth = 0;
            cboUser.DrawMode = DrawMode.OwnerDrawVariable;
            cboUser.DropDownHeight = 174;
            cboUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUser.DropDownWidth = 121;
            cboUser.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboUser.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboUser.FormattingEnabled = true;
            cboUser.Hint = "User";
            cboUser.IntegralHeight = false;
            cboUser.ItemHeight = 43;
            cboUser.Location = new Point(365, 7);
            cboUser.MaxDropDownItems = 4;
            cboUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUser.Name = "cboUser";
            cboUser.Size = new Size(281, 49);
            cboUser.StartIndex = 0;
            cboUser.TabIndex = 4;
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
            txtId.Location = new Point(652, 7);
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
            txtId.Size = new Size(132, 48);
            txtId.TabIndex = 5;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboCustomer
            // 
            cboCustomer.AutoResize = false;
            cboCustomer.BackColor = Color.FromArgb(255, 255, 255);
            cboCustomer.Depth = 0;
            cboCustomer.DrawMode = DrawMode.OwnerDrawVariable;
            cboCustomer.DropDownHeight = 174;
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomer.DropDownWidth = 121;
            cboCustomer.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Hint = "Customer";
            cboCustomer.IntegralHeight = false;
            cboCustomer.ItemHeight = 43;
            cboCustomer.Location = new Point(6, 60);
            cboCustomer.MaxDropDownItems = 4;
            cboCustomer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(778, 49);
            cboCustomer.StartIndex = 0;
            cboCustomer.TabIndex = 6;
            // 
            // groupBoxItens
            // 
            groupBoxItens.Controls.Add(btnExcluir);
            groupBoxItens.Controls.Add(cboCategory);
            groupBoxItens.Controls.Add(txtQuantity);
            groupBoxItens.Controls.Add(dataGridViewItens);
            groupBoxItens.Controls.Add(btnAdd);
            groupBoxItens.Controls.Add(txtTotalPrice);
            groupBoxItens.Controls.Add(txtPrice);
            groupBoxItens.Controls.Add(txtSaleUnit);
            groupBoxItens.Controls.Add(cboProduct);
            groupBoxItens.Location = new Point(6, 115);
            groupBoxItens.Name = "groupBoxItens";
            groupBoxItens.Size = new Size(778, 428);
            groupBoxItens.TabIndex = 7;
            groupBoxItens.TabStop = false;
            groupBoxItens.Text = "SaleItens";
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(707, 85);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(64, 36);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "-";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
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
            cboCategory.Enabled = false;
            cboCategory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Hint = "Category";
            cboCategory.IntegralHeight = false;
            cboCategory.ItemHeight = 43;
            cboCategory.Location = new Point(6, 75);
            cboCategory.MaxDropDownItems = 4;
            cboCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(238, 49);
            cboCategory.StartIndex = 0;
            cboCategory.TabIndex = 7;
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
            txtQuantity.Location = new Point(250, 76);
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
            txtQuantity.Size = new Size(222, 48);
            txtQuantity.TabIndex = 6;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            txtQuantity.KeyPress += txtQuantity_KeyPress;
            txtQuantity.Leave += txtQuantity_Leave_1;
            // 
            // dataGridViewItens
            // 
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Location = new Point(6, 130);
            dataGridViewItens.MultiSelect = false;
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.ReadOnly = true;
            dataGridViewItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItens.Size = new Size(766, 276);
            dataGridViewItens.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdd.Location = new Point(707, 25);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.AnimateReadOnly = false;
            txtTotalPrice.AutoCompleteMode = AutoCompleteMode.None;
            txtTotalPrice.AutoCompleteSource = AutoCompleteSource.None;
            txtTotalPrice.BackgroundImageLayout = ImageLayout.None;
            txtTotalPrice.CharacterCasing = CharacterCasing.Normal;
            txtTotalPrice.Depth = 0;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalPrice.HideSelection = true;
            txtTotalPrice.Hint = "Total Price";
            txtTotalPrice.LeadingIcon = null;
            txtTotalPrice.Location = new Point(478, 76);
            txtTotalPrice.MaxLength = 32767;
            txtTotalPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.PasswordChar = '\0';
            txtTotalPrice.PrefixSuffixText = null;
            txtTotalPrice.ReadOnly = false;
            txtTotalPrice.RightToLeft = RightToLeft.No;
            txtTotalPrice.SelectedText = "";
            txtTotalPrice.SelectionLength = 0;
            txtTotalPrice.SelectionStart = 0;
            txtTotalPrice.ShortcutsEnabled = true;
            txtTotalPrice.Size = new Size(212, 48);
            txtTotalPrice.TabIndex = 3;
            txtTotalPrice.TabStop = false;
            txtTotalPrice.TextAlign = HorizontalAlignment.Left;
            txtTotalPrice.TrailingIcon = null;
            txtTotalPrice.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            txtPrice.AnimateReadOnly = false;
            txtPrice.AutoCompleteMode = AutoCompleteMode.None;
            txtPrice.AutoCompleteSource = AutoCompleteSource.None;
            txtPrice.BackgroundImageLayout = ImageLayout.None;
            txtPrice.CharacterCasing = CharacterCasing.Normal;
            txtPrice.Depth = 0;
            txtPrice.Enabled = false;
            txtPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrice.HideSelection = true;
            txtPrice.Hint = "Price";
            txtPrice.LeadingIcon = null;
            txtPrice.Location = new Point(478, 24);
            txtPrice.MaxLength = 32767;
            txtPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PrefixSuffixText = null;
            txtPrice.ReadOnly = false;
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.SelectedText = "";
            txtPrice.SelectionLength = 0;
            txtPrice.SelectionStart = 0;
            txtPrice.ShortcutsEnabled = true;
            txtPrice.Size = new Size(212, 48);
            txtPrice.TabIndex = 2;
            txtPrice.TabStop = false;
            txtPrice.TextAlign = HorizontalAlignment.Left;
            txtPrice.TrailingIcon = null;
            txtPrice.UseSystemPasswordChar = false;
            txtPrice.Leave += txtQuantity_Leave;
            // 
            // txtSaleUnit
            // 
            txtSaleUnit.AnimateReadOnly = false;
            txtSaleUnit.AutoCompleteMode = AutoCompleteMode.None;
            txtSaleUnit.AutoCompleteSource = AutoCompleteSource.None;
            txtSaleUnit.BackgroundImageLayout = ImageLayout.None;
            txtSaleUnit.CharacterCasing = CharacterCasing.Normal;
            txtSaleUnit.Depth = 0;
            txtSaleUnit.Enabled = false;
            txtSaleUnit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSaleUnit.HideSelection = true;
            txtSaleUnit.Hint = "SaleUnit";
            txtSaleUnit.LeadingIcon = null;
            txtSaleUnit.Location = new Point(250, 22);
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
            txtSaleUnit.Size = new Size(222, 48);
            txtSaleUnit.TabIndex = 1;
            txtSaleUnit.TabStop = false;
            txtSaleUnit.TextAlign = HorizontalAlignment.Left;
            txtSaleUnit.TrailingIcon = null;
            txtSaleUnit.UseSystemPasswordChar = false;
            // 
            // cboProduct
            // 
            cboProduct.AutoResize = false;
            cboProduct.BackColor = Color.FromArgb(255, 255, 255);
            cboProduct.Depth = 0;
            cboProduct.DrawMode = DrawMode.OwnerDrawVariable;
            cboProduct.DropDownHeight = 174;
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.DropDownWidth = 121;
            cboProduct.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProduct.FormattingEnabled = true;
            cboProduct.Hint = "Product";
            cboProduct.IntegralHeight = false;
            cboProduct.ItemHeight = 43;
            cboProduct.Location = new Point(6, 22);
            cboProduct.MaxDropDownItems = 4;
            cboProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(238, 49);
            cboProduct.StartIndex = 0;
            cboProduct.TabIndex = 0;
            cboProduct.SelectedValueChanged += cboProduct_SelectedValueChanged;
            // 
            // lblQtdItens
            // 
            lblQtdItens.AutoSize = true;
            lblQtdItens.Depth = 0;
            lblQtdItens.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblQtdItens.Location = new Point(12, 524);
            lblQtdItens.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblQtdItens.Name = "lblQtdItens";
            lblQtdItens.Size = new Size(145, 19);
            lblQtdItens.TabIndex = 8;
            lblQtdItens.Text = "Quantity Products: 0";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Depth = 0;
            lblTotalPrice.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalPrice.Location = new Point(352, 524);
            lblTotalPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(94, 19);
            lblTotalPrice.TabIndex = 9;
            lblTotalPrice.Text = "Total Price: 0";
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 702);
            Location = new Point(0, 0);
            Name = "SaleForm";
            Text = "Sale ​​registration";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBoxItens.ResumeLayout(false);
            groupBoxItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboUser;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtSaleDate;
        private ReaLTaiizor.Controls.MaterialComboBox cboCustomer;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private GroupBox groupBoxItens;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTotalPrice;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrice;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSaleUnit;
        private ReaLTaiizor.Controls.MaterialComboBox cboProduct;
        private DataGridView dataGridViewItens;
        private ReaLTaiizor.Controls.MaterialLabel lblTotalPrice;
        private ReaLTaiizor.Controls.MaterialLabel lblQtdItens;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantity;
        private ReaLTaiizor.Controls.MaterialComboBox cboCategory;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
    }
}