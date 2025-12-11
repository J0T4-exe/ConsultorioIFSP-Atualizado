using System.Drawing;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace ConsultorioIFSP.App.Cadastros
{
    partial class ConsultaForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
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
        /// Método necessário para suporte ao designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new MaterialTextBoxEdit();
            txtDataConsulta = new MaterialTextBoxEdit();
            txtHorario = new MaterialTextBoxEdit();
            cboMedico = new MaterialComboBox();
            cboPaciente = new MaterialComboBox();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(6, 67);
            tabControlRegister.Size = new Size(902, 339);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cboPaciente);
            tabPage1.Controls.Add(cboMedico);
            tabPage1.Controls.Add(txtHorario);
            tabPage1.Controls.Add(txtDataConsulta);
            tabPage1.Controls.Add(txtId);
            tabPage1.Size = new Size(894, 304);
            tabPage1.Click += tabPage1_Click;
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtDataConsulta, 0);
            tabPage1.Controls.SetChildIndex(txtHorario, 0);
            tabPage1.Controls.SetChildIndex(cboMedico, 0);
            tabPage1.Controls.SetChildIndex(cboPaciente, 0);
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
            txtId.Location = new Point(540, 6);
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
            txtId.Size = new Size(150, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtDataConsulta
            // 
            txtDataConsulta.AnimateReadOnly = false;
            txtDataConsulta.AutoCompleteMode = AutoCompleteMode.None;
            txtDataConsulta.AutoCompleteSource = AutoCompleteSource.None;
            txtDataConsulta.BackgroundImageLayout = ImageLayout.None;
            txtDataConsulta.CharacterCasing = CharacterCasing.Normal;
            txtDataConsulta.Depth = 0;
            txtDataConsulta.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataConsulta.HideSelection = true;
            txtDataConsulta.Hint = "Data da Consulta (dd/mm/aaaa)";
            txtDataConsulta.LeadingIcon = null;
            txtDataConsulta.Location = new Point(6, 6);
            txtDataConsulta.MaxLength = 32767;
            txtDataConsulta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataConsulta.Name = "txtDataConsulta";
            txtDataConsulta.PasswordChar = '\0';
            txtDataConsulta.PrefixSuffixText = null;
            txtDataConsulta.ReadOnly = false;
            txtDataConsulta.RightToLeft = RightToLeft.No;
            txtDataConsulta.SelectedText = "";
            txtDataConsulta.SelectionLength = 0;
            txtDataConsulta.SelectionStart = 0;
            txtDataConsulta.ShortcutsEnabled = true;
            txtDataConsulta.Size = new Size(300, 48);
            txtDataConsulta.TabIndex = 2;
            txtDataConsulta.TabStop = false;
            txtDataConsulta.TextAlign = HorizontalAlignment.Left;
            txtDataConsulta.TrailingIcon = null;
            txtDataConsulta.UseSystemPasswordChar = false;
            // 
            // txtHorario
            // 
            txtHorario.AnimateReadOnly = false;
            txtHorario.AutoCompleteMode = AutoCompleteMode.None;
            txtHorario.AutoCompleteSource = AutoCompleteSource.None;
            txtHorario.BackgroundImageLayout = ImageLayout.None;
            txtHorario.CharacterCasing = CharacterCasing.Normal;
            txtHorario.Depth = 0;
            txtHorario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHorario.HideSelection = true;
            txtHorario.Hint = "Horário (HH:MM)";
            txtHorario.LeadingIcon = null;
            txtHorario.Location = new Point(372, 7);
            txtHorario.MaxLength = 32767;
            txtHorario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHorario.Name = "txtHorario";
            txtHorario.PasswordChar = '\0';
            txtHorario.PrefixSuffixText = null;
            txtHorario.ReadOnly = false;
            txtHorario.RightToLeft = RightToLeft.No;
            txtHorario.SelectedText = "";
            txtHorario.SelectionLength = 0;
            txtHorario.SelectionStart = 0;
            txtHorario.ShortcutsEnabled = true;
            txtHorario.Size = new Size(150, 48);
            txtHorario.TabIndex = 3;
            txtHorario.TabStop = false;
            txtHorario.TextAlign = HorizontalAlignment.Left;
            txtHorario.TrailingIcon = null;
            txtHorario.UseSystemPasswordChar = false;
            // 
            // cboMedico
            // 
            cboMedico.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboMedico.AutoResize = false;
            cboMedico.BackColor = Color.FromArgb(255, 255, 255);
            cboMedico.Depth = 0;
            cboMedico.DrawMode = DrawMode.OwnerDrawVariable;
            cboMedico.DropDownHeight = 174;
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.DropDownWidth = 121;
            cboMedico.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboMedico.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboMedico.FormattingEnabled = true;
            cboMedico.Hint = "Médico";
            cboMedico.IntegralHeight = false;
            cboMedico.ItemHeight = 43;
            cboMedico.Location = new Point(6, 60);
            cboMedico.MaxDropDownItems = 4;
            cboMedico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(290, 49);
            cboMedico.StartIndex = 0;
            cboMedico.TabIndex = 4;
            // 
            // cboPaciente
            // 
            cboPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboPaciente.AutoResize = false;
            cboPaciente.BackColor = Color.FromArgb(255, 255, 255);
            cboPaciente.Depth = 0;
            cboPaciente.DrawMode = DrawMode.OwnerDrawVariable;
            cboPaciente.DropDownHeight = 174;
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaciente.DropDownWidth = 121;
            cboPaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboPaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Hint = "Paciente";
            cboPaciente.IntegralHeight = false;
            cboPaciente.ItemHeight = 43;
            cboPaciente.Location = new Point(372, 60);
            cboPaciente.MaxDropDownItems = 4;
            cboPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(318, 49);
            cboPaciente.StartIndex = 0;
            cboPaciente.TabIndex = 5;
            // 
            // ConsultaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 401);
            Location = new Point(0, 0);
            Name = "ConsultaForm";
            Text = "Cadastro de Consulta";
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        #region Declarações dos Componentes de Consulta
        // TextBoxes
        private MaterialTextBoxEdit txtId;
        private MaterialTextBoxEdit txtDataConsulta;
        private MaterialTextBoxEdit txtHorario;

        // ComboBoxes (Para Chaves Estrangeiras)
        private MaterialComboBox cboMedico;
        private MaterialComboBox cboPaciente;
        #endregion
    }
}