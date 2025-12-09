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
            this.components = new System.ComponentModel.Container();
            // Declaração e Inicialização dos componentes necessários para a Receita
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtPeriodo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ReceitaForm";

            // txtId 
            this.txtId.Location = new System.Drawing.Point(10, 10);
            this.txtId.Size = new System.Drawing.Size(50, 48);
            this.txtId.Text = "ID";
            this.txtId.ReadOnly = true;
            this.txtId.Visible = false;

            // txtPeriodo
            this.txtPeriodo.Location = new System.Drawing.Point(70, 50);
            this.txtPeriodo.Size = new System.Drawing.Size(250, 48);
            this.txtPeriodo.Text = "Período da Receita";

            // txtQuantidade
            this.txtQuantidade.Location = new System.Drawing.Point(70, 120);
            this.txtQuantidade.Size = new System.Drawing.Size(250, 48);
            this.txtQuantidade.Text = "Quantidade (dias/doses)";

            // Adicionar os controles ao formulário.
            // Para garantir que o BaseForm os encontre, eles devem ser adicionados
            // a um container que o BaseForm possa iterar (geralmente o TabPage de Cadastro).
            // Se o BaseForm não expõe o TabPage, adicione diretamente ao ClientSize.

            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtQuantidade);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        #region Declarações dos Componentes de Receita
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeriodo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        #endregion
    }
}