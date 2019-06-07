namespace projektPKS
{
    partial class frmDyspozytor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDyspozytor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tBzamknij = new System.Windows.Forms.ToolStripButton();
            this.tBWyloguj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.miejscowościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odcinekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odcinkiWTrasachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_harm = new System.Windows.Forms.ToolStripButton();
            this.tsb_kier = new System.Windows.Forms.ToolStripButton();
            this.tsb_ilPas = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_kursy = new System.Windows.Forms.Button();
            this.but_trasy = new System.Windows.Forms.Button();
            this.but_odcTras = new System.Windows.Forms.Button();
            this.but_odcinek = new System.Windows.Forms.Button();
            this.but_Miejsc = new System.Windows.Forms.Button();
            this.but_KierTras = new System.Windows.Forms.Button();
            this.but_HarmRuch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_IloPas = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBzamknij,
            this.tBWyloguj,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.tsb_harm,
            this.tsb_kier,
            this.tsb_ilPas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tBzamknij
            // 
            this.tBzamknij.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBzamknij.Image = ((System.Drawing.Image)(resources.GetObject("tBzamknij.Image")));
            this.tBzamknij.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBzamknij.Name = "tBzamknij";
            this.tBzamknij.Size = new System.Drawing.Size(23, 22);
            this.tBzamknij.Text = "Zamknij";
            this.tBzamknij.Click += new System.EventHandler(this.tBzamknij_Click);
            // 
            // tBWyloguj
            // 
            this.tBWyloguj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBWyloguj.Image = ((System.Drawing.Image)(resources.GetObject("tBWyloguj.Image")));
            this.tBWyloguj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBWyloguj.Name = "tBWyloguj";
            this.tBWyloguj.Size = new System.Drawing.Size(23, 22);
            this.tBWyloguj.Text = "Wyloguj";
            this.tBWyloguj.Click += new System.EventHandler(this.tBWyloguj_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miejscowościToolStripMenuItem,
            this.odcinekToolStripMenuItem,
            this.odcinkiWTrasachToolStripMenuItem,
            this.trasyToolStripMenuItem,
            this.kursyToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "Tabele do modyfikacji";
            // 
            // miejscowościToolStripMenuItem
            // 
            this.miejscowościToolStripMenuItem.Name = "miejscowościToolStripMenuItem";
            this.miejscowościToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.miejscowościToolStripMenuItem.Text = "Miejscowości";
            this.miejscowościToolStripMenuItem.Click += new System.EventHandler(this.miejscowościToolStripMenuItem_Click);
            // 
            // odcinekToolStripMenuItem
            // 
            this.odcinekToolStripMenuItem.Name = "odcinekToolStripMenuItem";
            this.odcinekToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.odcinekToolStripMenuItem.Text = "Odcinek";
            this.odcinekToolStripMenuItem.Click += new System.EventHandler(this.odcinekToolStripMenuItem_Click);
            // 
            // odcinkiWTrasachToolStripMenuItem
            // 
            this.odcinkiWTrasachToolStripMenuItem.Name = "odcinkiWTrasachToolStripMenuItem";
            this.odcinkiWTrasachToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.odcinkiWTrasachToolStripMenuItem.Text = "Odcinki w Trasach";
            this.odcinkiWTrasachToolStripMenuItem.Click += new System.EventHandler(this.odcinkiWTrasachToolStripMenuItem_Click);
            // 
            // trasyToolStripMenuItem
            // 
            this.trasyToolStripMenuItem.Name = "trasyToolStripMenuItem";
            this.trasyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.trasyToolStripMenuItem.Text = "Trasy";
            this.trasyToolStripMenuItem.Click += new System.EventHandler(this.trasyToolStripMenuItem_Click);
            // 
            // kursyToolStripMenuItem
            // 
            this.kursyToolStripMenuItem.Name = "kursyToolStripMenuItem";
            this.kursyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.kursyToolStripMenuItem.Text = "Kursy";
            this.kursyToolStripMenuItem.Click += new System.EventHandler(this.kursyToolStripMenuItem_Click);
            // 
            // tsb_harm
            // 
            this.tsb_harm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_harm.Image = ((System.Drawing.Image)(resources.GetObject("tsb_harm.Image")));
            this.tsb_harm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_harm.Name = "tsb_harm";
            this.tsb_harm.Size = new System.Drawing.Size(23, 22);
            this.tsb_harm.Text = "Harmonogram Ruchu pojazdu po trasie";
            this.tsb_harm.Click += new System.EventHandler(this.tsb_harm_Click);
            // 
            // tsb_kier
            // 
            this.tsb_kier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_kier.Image = ((System.Drawing.Image)(resources.GetObject("tsb_kier.Image")));
            this.tsb_kier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_kier.Name = "tsb_kier";
            this.tsb_kier.Size = new System.Drawing.Size(23, 22);
            this.tsb_kier.Text = "Kierowca w Trasie";
            this.tsb_kier.Click += new System.EventHandler(this.tsb_kier_Click);
            // 
            // tsb_ilPas
            // 
            this.tsb_ilPas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ilPas.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ilPas.Image")));
            this.tsb_ilPas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ilPas.Name = "tsb_ilPas";
            this.tsb_ilPas.Size = new System.Drawing.Size(23, 22);
            this.tsb_ilPas.Text = "Ilość Pasażerów";
            this.tsb_ilPas.Click += new System.EventHandler(this.tsb_ilPas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but_kursy);
            this.panel1.Controls.Add(this.but_trasy);
            this.panel1.Controls.Add(this.but_odcTras);
            this.panel1.Controls.Add(this.but_odcinek);
            this.panel1.Controls.Add(this.but_Miejsc);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 436);
            this.panel1.TabIndex = 1;
            // 
            // but_kursy
            // 
            this.but_kursy.Location = new System.Drawing.Point(3, 173);
            this.but_kursy.Name = "but_kursy";
            this.but_kursy.Size = new System.Drawing.Size(101, 23);
            this.but_kursy.TabIndex = 4;
            this.but_kursy.Text = "Kursy";
            this.but_kursy.UseVisualStyleBackColor = true;
            this.but_kursy.Click += new System.EventHandler(this.but_kursy_Click);
            // 
            // but_trasy
            // 
            this.but_trasy.Location = new System.Drawing.Point(3, 144);
            this.but_trasy.Name = "but_trasy";
            this.but_trasy.Size = new System.Drawing.Size(101, 23);
            this.but_trasy.TabIndex = 3;
            this.but_trasy.Text = "Trasy";
            this.but_trasy.UseVisualStyleBackColor = true;
            this.but_trasy.Click += new System.EventHandler(this.but_trasy_Click);
            // 
            // but_odcTras
            // 
            this.but_odcTras.Location = new System.Drawing.Point(0, 115);
            this.but_odcTras.Name = "but_odcTras";
            this.but_odcTras.Size = new System.Drawing.Size(104, 23);
            this.but_odcTras.TabIndex = 2;
            this.but_odcTras.Text = "Odcinki w Trasach";
            this.but_odcTras.UseVisualStyleBackColor = true;
            this.but_odcTras.Click += new System.EventHandler(this.but_odcTras_Click);
            // 
            // but_odcinek
            // 
            this.but_odcinek.Location = new System.Drawing.Point(0, 86);
            this.but_odcinek.Name = "but_odcinek";
            this.but_odcinek.Size = new System.Drawing.Size(104, 23);
            this.but_odcinek.TabIndex = 1;
            this.but_odcinek.Text = "Odcinek";
            this.but_odcinek.UseVisualStyleBackColor = true;
            this.but_odcinek.Click += new System.EventHandler(this.but_odcinek_Click);
            // 
            // but_Miejsc
            // 
            this.but_Miejsc.Location = new System.Drawing.Point(0, 57);
            this.but_Miejsc.Name = "but_Miejsc";
            this.but_Miejsc.Size = new System.Drawing.Size(104, 23);
            this.but_Miejsc.TabIndex = 0;
            this.but_Miejsc.Text = "Miejscowości";
            this.but_Miejsc.UseVisualStyleBackColor = true;
            this.but_Miejsc.Click += new System.EventHandler(this.but_Miejsc_Click);
            // 
            // but_KierTras
            // 
            this.but_KierTras.Location = new System.Drawing.Point(98, 3);
            this.but_KierTras.Name = "but_KierTras";
            this.but_KierTras.Size = new System.Drawing.Size(75, 49);
            this.but_KierTras.TabIndex = 6;
            this.but_KierTras.Text = "Kierowca w Trasie";
            this.but_KierTras.UseVisualStyleBackColor = true;
            this.but_KierTras.Click += new System.EventHandler(this.but_KierTras_Click);
            // 
            // but_HarmRuch
            // 
            this.but_HarmRuch.Location = new System.Drawing.Point(3, 3);
            this.but_HarmRuch.Name = "but_HarmRuch";
            this.but_HarmRuch.Size = new System.Drawing.Size(89, 49);
            this.but_HarmRuch.TabIndex = 5;
            this.but_HarmRuch.Text = "Harmonogram Ruchu pojazdu po trasie";
            this.but_HarmRuch.UseVisualStyleBackColor = true;
            this.but_HarmRuch.Click += new System.EventHandler(this.but_HarmRuch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.but_IloPas);
            this.panel2.Controls.Add(this.but_KierTras);
            this.panel2.Controls.Add(this.but_HarmRuch);
            this.panel2.Location = new System.Drawing.Point(112, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 57);
            this.panel2.TabIndex = 2;
            // 
            // but_IloPas
            // 
            this.but_IloPas.Location = new System.Drawing.Point(179, 3);
            this.but_IloPas.Name = "but_IloPas";
            this.but_IloPas.Size = new System.Drawing.Size(75, 49);
            this.but_IloPas.TabIndex = 7;
            this.but_IloPas.Text = "Ilość Pasażerów";
            this.but_IloPas.UseVisualStyleBackColor = true;
            this.but_IloPas.Click += new System.EventHandler(this.but_IloPas_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(112, 93);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(828, 371);
            this.panel.TabIndex = 3;
            // 
            // frmDyspozytor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(952, 476);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDyspozytor";
            this.Text = "Dyspozytor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDyspozytor_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tBzamknij;
        private System.Windows.Forms.ToolStripButton tBWyloguj;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_odcinek;
        private System.Windows.Forms.Button but_Miejsc;
        private System.Windows.Forms.Button but_KierTras;
        private System.Windows.Forms.Button but_HarmRuch;
        private System.Windows.Forms.Button but_kursy;
        private System.Windows.Forms.Button but_trasy;
        private System.Windows.Forms.Button but_odcTras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button but_IloPas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem miejscowościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odcinekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odcinkiWTrasachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kursyToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsb_harm;
        private System.Windows.Forms.ToolStripButton tsb_kier;
        private System.Windows.Forms.ToolStripButton tsb_ilPas;
    }
}