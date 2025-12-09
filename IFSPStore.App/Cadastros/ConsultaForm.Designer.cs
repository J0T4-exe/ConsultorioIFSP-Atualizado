namespace IFSPStore.App.Cadastros
{
    partial class ConsultaProdutoForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            // Declaração dos objetos (variáveis)
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.PanelFiltros = new System.Windows.Forms.Panel();

            // Inicialização e Configuração
            this.PanelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();

            // 
            // PanelFiltros
            // 
            this.PanelFiltros.Controls.Add(this.btnConsultar);
            this.PanelFiltros.Controls.Add(this.cboCategory);
            this.PanelFiltros.Controls.Add(this.lblCategory);
            this.PanelFiltros.Controls.Add(this.txtId);
            this.PanelFiltros.Controls.Add(this.lblId);
            // ... (adicionar todos os controles de filtro)
            this.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFiltros.Location = new System.Drawing.Point(0, 0);
            this.PanelFiltros.Size = new System.Drawing.Size(800, 100);

            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(580, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(120, 30);
            this.btnConsultar.Text = "Consultar";
            // Associa o evento de clique ao método C#
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);

            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(0, 100); // Começa abaixo do painel de filtros
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(800, 500);

            // 
            // ConsultaProdutoForm
            // 
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.PanelFiltros);
            this.PanelFiltros.ResumeLayout(false);
            this.PanelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Panel PanelFiltros;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLimparFiltros;
        // ... (demais variáveis declaradas)
    }
}