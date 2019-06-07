namespace projektPKS
{
    partial class frmKierowca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKierowca));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_zamknij = new System.Windows.Forms.ToolStripButton();
            this.tB_wyloguj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_info = new System.Windows.Forms.ToolStripButton();
            this.tsb_ilosc = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_IloPas = new System.Windows.Forms.Button();
            this.but_Info = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_zamknij,
            this.tB_wyloguj,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.tsb_info,
            this.tsb_ilosc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tb_zamknij
            // 
            this.tb_zamknij.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_zamknij.Image = ((System.Drawing.Image)(resources.GetObject("tb_zamknij.Image")));
            this.tb_zamknij.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_zamknij.Name = "tb_zamknij";
            this.tb_zamknij.Size = new System.Drawing.Size(23, 22);
            this.tb_zamknij.Text = "Zamknij";
            this.tb_zamknij.Click += new System.EventHandler(this.tb_zamknij_Click);
            // 
            // tB_wyloguj
            // 
            this.tB_wyloguj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_wyloguj.Image = ((System.Drawing.Image)(resources.GetObject("tB_wyloguj.Image")));
            this.tB_wyloguj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tB_wyloguj.Name = "tB_wyloguj";
            this.tB_wyloguj.Size = new System.Drawing.Size(23, 22);
            this.tB_wyloguj.Text = "Wyloguj się";
            this.tB_wyloguj.Click += new System.EventHandler(this.tB_wyloguj_Click);
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
            // tsb_info
            // 
            this.tsb_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_info.Image = ((System.Drawing.Image)(resources.GetObject("tsb_info.Image")));
            this.tsb_info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_info.Name = "tsb_info";
            this.tsb_info.Size = new System.Drawing.Size(23, 22);
            this.tsb_info.Text = "Informacje";
            this.tsb_info.Click += new System.EventHandler(this.tsb_info_Click);
            // 
            // tsb_ilosc
            // 
            this.tsb_ilosc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ilosc.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ilosc.Image")));
            this.tsb_ilosc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ilosc.Name = "tsb_ilosc";
            this.tsb_ilosc.Size = new System.Drawing.Size(23, 22);
            this.tsb_ilosc.Text = "Ilość Pasażerów";
            this.tsb_ilosc.Click += new System.EventHandler(this.tsb_ilosc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but_IloPas);
            this.panel1.Controls.Add(this.but_Info);
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 63);
            this.panel1.TabIndex = 1;
            // 
            // but_IloPas
            // 
            this.but_IloPas.Location = new System.Drawing.Point(102, 3);
            this.but_IloPas.Name = "but_IloPas";
            this.but_IloPas.Size = new System.Drawing.Size(90, 55);
            this.but_IloPas.TabIndex = 1;
            this.but_IloPas.Text = "Ilość Pasażerów\r\n";
            this.but_IloPas.UseVisualStyleBackColor = true;
            this.but_IloPas.Click += new System.EventHandler(this.but_IloPas_Click);
            // 
            // but_Info
            // 
            this.but_Info.Location = new System.Drawing.Point(9, 3);
            this.but_Info.Name = "but_Info";
            this.but_Info.Size = new System.Drawing.Size(87, 55);
            this.but_Info.TabIndex = 0;
            this.but_Info.Text = "Informacje";
            this.but_Info.UseVisualStyleBackColor = true;
            this.but_Info.Click += new System.EventHandler(this.but_Info_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(3, 93);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(937, 371);
            this.panel.TabIndex = 2;
            // 
            // frmKierowca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(952, 476);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKierowca";
            this.Text = "Kierowca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKierowca_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tb_zamknij;
        private System.Windows.Forms.ToolStripButton tB_wyloguj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_IloPas;
        private System.Windows.Forms.Button but_Info;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_info;
        private System.Windows.Forms.ToolStripButton tsb_ilosc;
    }
}