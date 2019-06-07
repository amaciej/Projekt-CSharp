namespace projektPKS
{
    partial class frmPolaczenia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPolacz = new System.Windows.Forms.DataGridView();
            this.but_szukaj = new System.Windows.Forms.Button();
            this.cb_poczatek = new System.Windows.Forms.ComboBox();
            this.cb_koniec = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolacz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miejscowość Początkowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miejscowość Końcowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wprowadź Id Miejscowości do której chcesz się dostać";
            // 
            // dgvPolacz
            // 
            this.dgvPolacz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolacz.Location = new System.Drawing.Point(88, 118);
            this.dgvPolacz.Name = "dgvPolacz";
            this.dgvPolacz.Size = new System.Drawing.Size(471, 159);
            this.dgvPolacz.TabIndex = 6;
            // 
            // but_szukaj
            // 
            this.but_szukaj.Location = new System.Drawing.Point(486, 62);
            this.but_szukaj.Name = "but_szukaj";
            this.but_szukaj.Size = new System.Drawing.Size(75, 28);
            this.but_szukaj.TabIndex = 7;
            this.but_szukaj.Text = "Wyszukaj";
            this.but_szukaj.UseVisualStyleBackColor = true;
            this.but_szukaj.Click += new System.EventHandler(this.but_szukaj_Click);
            // 
            // cb_poczatek
            // 
            this.cb_poczatek.FormattingEnabled = true;
            this.cb_poczatek.Location = new System.Drawing.Point(89, 77);
            this.cb_poczatek.Name = "cb_poczatek";
            this.cb_poczatek.Size = new System.Drawing.Size(121, 21);
            this.cb_poczatek.TabIndex = 8;
            // 
            // cb_koniec
            // 
            this.cb_koniec.FormattingEnabled = true;
            this.cb_koniec.Location = new System.Drawing.Point(276, 77);
            this.cb_koniec.Name = "cb_koniec";
            this.cb_koniec.Size = new System.Drawing.Size(121, 21);
            this.cb_koniec.TabIndex = 9;
            // 
            // frmPolaczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_koniec);
            this.Controls.Add(this.cb_poczatek);
            this.Controls.Add(this.but_szukaj);
            this.Controls.Add(this.dgvPolacz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPolaczenia";
            this.Text = "frmPolaczenia";
            this.Load += new System.EventHandler(this.frmPolaczenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolacz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPolacz;
        private System.Windows.Forms.Button but_szukaj;
        private System.Windows.Forms.ComboBox cb_poczatek;
        private System.Windows.Forms.ComboBox cb_koniec;
    }
}