namespace IFSPStore.App.Outros
{
    partial class HelpForm
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
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            btnContactWhatsApp = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.FlatStyle = FlatStyle.Popup;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(89, 76);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(177, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "For help contact support:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(79, 104);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(203, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Developer: Nicolas Cerqueira";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(65, 132);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(239, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Email: ncerqueira122@gmail.com";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(94, 160);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(172, 19);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "Phone: (18) 98100-2171";
            // 
            // btnContactWhatsApp
            // 
            btnContactWhatsApp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnContactWhatsApp.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnContactWhatsApp.Depth = 0;
            btnContactWhatsApp.HighEmphasis = true;
            btnContactWhatsApp.Icon = null;
            btnContactWhatsApp.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnContactWhatsApp.Location = new Point(134, 195);
            btnContactWhatsApp.Margin = new Padding(4, 6, 4, 6);
            btnContactWhatsApp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnContactWhatsApp.Name = "btnContactWhatsApp";
            btnContactWhatsApp.NoAccentTextColor = Color.Empty;
            btnContactWhatsApp.Size = new Size(101, 36);
            btnContactWhatsApp.TabIndex = 4;
            btnContactWhatsApp.Text = "WhatsApp";
            btnContactWhatsApp.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnContactWhatsApp.UseAccentColor = false;
            btnContactWhatsApp.UseVisualStyleBackColor = true;
            btnContactWhatsApp.Click += btnContactWhatsApp_Click;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 282);
            Controls.Add(btnContactWhatsApp);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialButton btnContactWhatsApp;
    }
}