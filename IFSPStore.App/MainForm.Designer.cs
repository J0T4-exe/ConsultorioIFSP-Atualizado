namespace ConsultorioIFSP.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            saleToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            cityToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = Properties.Resources.unnamed;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.ImageScalingSize = new Size(200, 200);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, helpToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.Location = new Point(3, 85);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(892, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerToolStripMenuItem, saleToolStripMenuItem, categoryToolStripMenuItem, productToolStripMenuItem, cityToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(78, 24);
            cadastrosToolStripMenuItem.Text = "Registro";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Image = (Image)resources.GetObject("customerToolStripMenuItem.Image");
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(268, 26);
            customerToolStripMenuItem.Text = "Cadastro Medico";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // saleToolStripMenuItem
            // 
            saleToolStripMenuItem.Image = Properties.Resources._64096;
            saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            saleToolStripMenuItem.Size = new Size(268, 26);
            saleToolStripMenuItem.Text = "Cadastro de Paciente";
            saleToolStripMenuItem.Click += saleToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Image = Properties.Resources.an_iconic_calendar_icon_png;
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(268, 26);
            categoryToolStripMenuItem.Text = "Agendar Consulta";
            categoryToolStripMenuItem.Click += categorytoolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Image = (Image)resources.GetObject("productToolStripMenuItem.Image");
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(268, 26);
            productToolStripMenuItem.Text = "Cadastro de Medicamento";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // cityToolStripMenuItem
            // 
            cityToolStripMenuItem.Image = (Image)resources.GetObject("cityToolStripMenuItem.Image");
            cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            cityToolStripMenuItem.Size = new Size(268, 26);
            cityToolStripMenuItem.Text = "Emitir Receita";
            cityToolStripMenuItem.Click += cityToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(66, 24);
            closeToolStripMenuItem.Text = "Fechar";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUser });
            statusStrip1.Location = new Point(3, 694);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(892, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.Text = "User";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "unnamed.jpg");
            imageList1.Images.SetKeyName(1, "64096.png");
            imageList1.Images.SetKeyName(2, "an-iconic-calendar-icon-png.png");
            imageList1.Images.SetKeyName(3, "first-aid-kit-red-medical-emergency-box-healthcare-cross-plastic-portable-safety-red-first-aid-kit-box-with-white-cross-symbol-portable-plastic-case-for-emergency-medical-su.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.unnamed;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(898, 724);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultorio IFSP - MENU";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem cityToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUser;
        private ImageList imageList1;
    }
}
