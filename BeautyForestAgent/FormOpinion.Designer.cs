namespace BeautyForestAgent
{
    partial class FormOpinion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpinion));
            this.button1 = new System.Windows.Forms.Button();
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.fontDlg = new System.Windows.Forms.ToolStripButton();
            this.colorDlg = new System.Windows.Forms.ToolStripButton();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tlsMenu
            // 
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontDlg,
            this.colorDlg});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(486, 25);
            this.tlsMenu.TabIndex = 1;
            this.tlsMenu.Text = "toolStrip1";
            // 
            // fontDlg
            // 
            this.fontDlg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontDlg.Image = ((System.Drawing.Image)(resources.GetObject("fontDlg.Image")));
            this.fontDlg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontDlg.Name = "fontDlg";
            this.fontDlg.Size = new System.Drawing.Size(23, 22);
            this.fontDlg.Text = "toolStripButton1";
            // 
            // colorDlg
            // 
            this.colorDlg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorDlg.Image = ((System.Drawing.Image)(resources.GetObject("colorDlg.Image")));
            this.colorDlg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorDlg.Name = "colorDlg";
            this.colorDlg.Size = new System.Drawing.Size(23, 22);
            this.colorDlg.Text = "toolStripButton2";
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(13, 29);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(461, 230);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = resources.GetString("rtbText.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(486, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormOpinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 344);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOpinion";
            this.Text = "FormOpinion";
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripButton fontDlg;
        private System.Windows.Forms.ToolStripButton colorDlg;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}