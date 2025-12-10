using ReaLTaiizor.Controls;
using System.Windows.Forms;
using System.Drawing;

namespace ConsultorioIFSP.App.Cadastros
{
    partial class ConsultaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtId = new MaterialTextBoxEdit();
            txtDataConsulta = new MaterialTextBoxEdit();
            txtHorario = new MaterialTextBoxEdit();
            cboMedico = new ComboBox();
            cboPaciente = new ComboBox();
            tabControlRegister.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Location = new Point(6, 65);
            tabControlRegister.Size = new Size(886, 420);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtHorario);
            tabPage1.Controls.Add(txtDataConsulta);
            tabPage1.Controls.Add(txtId);
            tabPage1.Size = new Size(878, 385);
            tabPage1.Controls.SetChildIndex(txtId, 0);
            tabPage1.Controls.SetChildIndex(txtDataConsulta, 0);
            tabPage1.Controls.SetChildIndex(txtHorario, 0);
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
            // txtDataConsulta
            // 
            txtDataConsulta.AnimateReadOnly = false;
            txtDataConsulta.AutoCompleteMode = AutoCompleteMode.None;
            txtDataConsulta.AutoCompleteSource = AutoCompleteSource.None;
            txtDataConsulta.BackgroundImageLayout = ImageLayout.None;
            txtDataConsulta.CharacterCasing = CharacterCasing.Normal;
            txtDataConsulta.Depth = 0;
            txtDataConsulta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataConsulta.HideSelection = true;
            txtDataConsulta.LeadingIcon = null;
            txtDataConsulta.Location = new Point(63, 7);
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
            txtDataConsulta.Size = new Size(200, 48);
            txtDataConsulta.TabIndex = 2;
            txtDataConsulta.TabStop = false;
            txtDataConsulta.Text = "Data da Consulta (DD/MM/AAAA)";
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
            txtHorario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHorario.HideSelection = true;
            txtHorario.LeadingIcon = null;
            txtHorario.Location = new Point(280, 7);
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
            txtHorario.Text = "Horário (HH:MM)";
            txtHorario.TextAlign = HorizontalAlignment.Left;
            txtHorario.TrailingIcon = null;
            txtHorario.UseSystemPasswordChar = false;
            // 
            // cboMedico
            // 
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(70, 120);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(380, 28);
            cboMedico.TabIndex = 4;
            // 
            // cboPaciente
            // 
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(70, 190);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(380, 28);
            cboPaciente.TabIndex = 5;
            // 
            // ConsultaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 493);
            Controls.Add(cboMedico);
            Controls.Add(cboPaciente);
            Location = new Point(0, 0);
            Name = "ConsultaForm";
            Text = "Agendamento de Consulta";
            Controls.SetChildIndex(cboPaciente, 0);
            Controls.SetChildIndex(cboMedico, 0);
            Controls.SetChildIndex(tabControlRegister, 0);
            tabControlRegister.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        #region Declarações dos Componentes de Consulta
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDataConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtHorario;
        private System.Windows.Forms.ComboBox cboMedico;
        private System.Windows.Forms.ComboBox cboPaciente;
        #endregion
    }
}