using ReaLTaiizor.Controls;

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
            txtId = new MaterialTextBoxEdit();
            txtPeriodo = new MaterialTextBoxEdit();
            txtQuantidade = new MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(6, 69);
            tabControlRegister.Size = new Size(915, 407);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtPeriodo);
            tabPage1.Controls.Add(txtId);
            tabPage1.Size = new Size(907, 372);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtPeriodo, 0);
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
            txtId.LeadingIcon = null;
            txtId.Location = new Point(7, 7);
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
            txtId.Size = new Size(50, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.Text = "ID";
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            txtId.Visible = false;
            // 
            // txtPeriodo
            // 
            txtPeriodo.AnimateReadOnly = false;
            txtPeriodo.AutoCompleteMode = AutoCompleteMode.None;
            txtPeriodo.AutoCompleteSource = AutoCompleteSource.None;
            txtPeriodo.BackgroundImageLayout = ImageLayout.None;
            txtPeriodo.CharacterCasing = CharacterCasing.Normal;
            txtPeriodo.Depth = 0;
            txtPeriodo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPeriodo.HideSelection = true;
            txtPeriodo.LeadingIcon = null;
            txtPeriodo.Location = new Point(63, 7);
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
            txtPeriodo.Size = new Size(250, 48);
            txtPeriodo.TabIndex = 2;
            txtPeriodo.TabStop = false;
            txtPeriodo.Text = "Período da Receita";
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
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(70, 120);
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
            txtQuantidade.Size = new Size(250, 48);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.TabStop = false;
            txtQuantidade.Text = "Quantidade (dias/doses)";
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // ReceitaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 482);
            Controls.Add(txtQuantidade);
            Location = new Point(0, 0);
            Name = "ReceitaForm";
            Text = "ReceitaForm";
            Controls.SetChildIndex(txtQuantidade, 0);
            Controls.SetChildIndex(tabControlRegister, 0);
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        #region Declarações dos Componentes de Receita
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeriodo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        #endregion
    }
}