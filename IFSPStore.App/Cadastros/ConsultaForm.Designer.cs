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
            this.components = new System.ComponentModel.Container();

            // Declaração e Inicialização dos componentes
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDataConsulta = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtHorario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboMedico = new System.Windows.Forms.ComboBox();
            this.cboPaciente = new System.Windows.Forms.ComboBox();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Text = "Agendamento de Consulta";

            // --- Configuração dos controles (Posicionamento Básico) ---

            this.txtId.Location = new System.Drawing.Point(10, 10);
            this.txtId.Size = new System.Drawing.Size(50, 48);
            this.txtId.Text = "ID";
            this.txtId.ReadOnly = true;
            this.txtId.Visible = false;

            this.txtDataConsulta.Location = new System.Drawing.Point(70, 50);
            this.txtDataConsulta.Size = new System.Drawing.Size(200, 48);
            this.txtDataConsulta.Text = "Data da Consulta (DD/MM/AAAA)";

            this.txtHorario.Location = new System.Drawing.Point(300, 50);
            this.txtHorario.Size = new System.Drawing.Size(150, 48);
            this.txtHorario.Text = "Horário (HH:MM)";

            this.cboMedico.FormattingEnabled = true;
            this.cboMedico.Location = new System.Drawing.Point(70, 120);
            this.cboMedico.Size = new System.Drawing.Size(380, 24);

            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(70, 190);
            this.cboPaciente.Size = new System.Drawing.Size(380, 24);

            // Adicionar os controles
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDataConsulta);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.cboMedico);
            this.Controls.Add(this.cboPaciente);

            this.ResumeLayout(false);
            this.PerformLayout();
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