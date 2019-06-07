namespace projektPKS
{
    partial class frmPasażer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasażer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_close = new System.Windows.Forms.ToolStripButton();
            this.tb_logout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsB_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_mKurs = new System.Windows.Forms.ToolStripButton();
            this.tsb_polacz = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_Poł = new System.Windows.Forms.Button();
            this.but_moje = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.but_harm = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_close,
            this.tb_logout,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.tsB_add,
            this.tsb_mKurs,
            this.toolStripButton1,
            this.tsb_polacz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tb_close
            // 
            this.tb_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_close.Image = ((System.Drawing.Image)(resources.GetObject("tb_close.Image")));
            this.tb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_close.Name = "tb_close";
            this.tb_close.Size = new System.Drawing.Size(23, 22);
            this.tb_close.Text = "Zamknij";
            this.tb_close.Click += new System.EventHandler(this.tb_close_Click);
            // 
            // tb_logout
            // 
            this.tb_logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_logout.Image = ((System.Drawing.Image)(resources.GetObject("tb_logout.Image")));
            this.tb_logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_logout.Name = "tb_logout";
            this.tb_logout.Size = new System.Drawing.Size(23, 22);
            this.tb_logout.Text = "Wyloguj się";
            this.tb_logout.Click += new System.EventHandler(this.tb_logout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsB_add
            // 
            this.tsB_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsB_add.Image = ((System.Drawing.Image)(resources.GetObject("tsB_add.Image")));
            this.tsB_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsB_add.Name = "tsB_add";
            this.tsB_add.Size = new System.Drawing.Size(23, 22);
            this.tsB_add.Text = "Dodaj";
            this.tsB_add.Click += new System.EventHandler(this.tsB_add_Click);
            // 
            // tsb_mKurs
            // 
            this.tsb_mKurs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_mKurs.Image = ((System.Drawing.Image)(resources.GetObject("tsb_mKurs.Image")));
            this.tsb_mKurs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_mKurs.Name = "tsb_mKurs";
            this.tsb_mKurs.Size = new System.Drawing.Size(23, 22);
            this.tsb_mKurs.Text = "Moje Kursy";
            this.tsb_mKurs.Click += new System.EventHandler(this.tsb_mKurs_Click);
            // 
            // tsb_polacz
            // 
            this.tsb_polacz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_polacz.Image = ((System.Drawing.Image)(resources.GetObject("tsb_polacz.Image")));
            this.tsb_polacz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_polacz.Name = "tsb_polacz";
            this.tsb_polacz.Size = new System.Drawing.Size(23, 22);
            this.tsb_polacz.Text = "Połączenia";
            this.tsb_polacz.Click += new System.EventHandler(this.tsb_polacz_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but_harm);
            this.panel1.Controls.Add(this.but_Poł);
            this.panel1.Controls.Add(this.but_moje);
            this.panel1.Controls.Add(this.but_add);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 68);
            this.panel1.TabIndex = 1;
            // 
            // but_Poł
            // 
            this.but_Poł.Location = new System.Drawing.Point(262, 4);
            this.but_Poł.Name = "but_Poł";
            this.but_Poł.Size = new System.Drawing.Size(75, 61);
            this.but_Poł.TabIndex = 2;
            this.but_Poł.Text = "Wyszukaj połączenia";
            this.but_Poł.UseVisualStyleBackColor = true;
            this.but_Poł.Click += new System.EventHandler(this.but_Poł_Click);
            // 
            // but_moje
            // 
            this.but_moje.Location = new System.Drawing.Point(90, 3);
            this.but_moje.Name = "but_moje";
            this.but_moje.Size = new System.Drawing.Size(75, 61);
            this.but_moje.TabIndex = 1;
            this.but_moje.Text = "Moje Kursy";
            this.but_moje.UseVisualStyleBackColor = true;
            this.but_moje.Click += new System.EventHandler(this.but_moje_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(9, 3);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 61);
            this.but_add.TabIndex = 0;
            this.but_add.Text = "Dodaj";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(4, 97);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(936, 367);
            this.panel.TabIndex = 2;
            // 
            // but_harm
            // 
            this.but_harm.Location = new System.Drawing.Point(171, 3);
            this.but_harm.Name = "but_harm";
            this.but_harm.Size = new System.Drawing.Size(85, 61);
            this.but_harm.TabIndex = 3;
            this.but_harm.Text = "Harmonogram Ruchu Autobusu";
            this.but_harm.UseVisualStyleBackColor = true;
            this.but_harm.Click += new System.EventHandler(this.but_harm_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Harmonogram Ruchu Autobusu";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmPasażer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(952, 476);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPasażer";
            this.Text = "Pasażer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPasażer_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tb_close;
        private System.Windows.Forms.ToolStripButton tb_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_Poł;
        private System.Windows.Forms.Button but_moje;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsB_add;
        private System.Windows.Forms.ToolStripButton tsb_mKurs;
        private System.Windows.Forms.ToolStripButton tsb_polacz;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button but_harm;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}