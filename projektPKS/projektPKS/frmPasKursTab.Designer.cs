namespace projektPKS
{
    partial class frmPasKursTab
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
            this.dgvPasKurs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdPasKurs = new System.Windows.Forms.TextBox();
            this.txt_IdKurs = new System.Windows.Forms.TextBox();
            this.txt_IdPas = new System.Windows.Forms.TextBox();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.but_save = new System.Windows.Forms.Button();
            this.but_usun = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_Szukaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPasKurs
            // 
            this.dgvPasKurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasKurs.Location = new System.Drawing.Point(350, 121);
            this.dgvPasKurs.Name = "dgvPasKurs";
            this.dgvPasKurs.Size = new System.Drawing.Size(397, 200);
            this.dgvPasKurs.TabIndex = 0;
            this.dgvPasKurs.DoubleClick += new System.EventHandler(this.dgvPasKurs_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id_PasKurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id_Kursy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id_Pasażer";
            // 
            // txt_IdPasKurs
            // 
            this.txt_IdPasKurs.Location = new System.Drawing.Point(100, 121);
            this.txt_IdPasKurs.Name = "txt_IdPasKurs";
            this.txt_IdPasKurs.Size = new System.Drawing.Size(100, 20);
            this.txt_IdPasKurs.TabIndex = 4;
            // 
            // txt_IdKurs
            // 
            this.txt_IdKurs.Location = new System.Drawing.Point(100, 156);
            this.txt_IdKurs.Name = "txt_IdKurs";
            this.txt_IdKurs.Size = new System.Drawing.Size(100, 20);
            this.txt_IdKurs.TabIndex = 5;
            // 
            // txt_IdPas
            // 
            this.txt_IdPas.Location = new System.Drawing.Point(100, 192);
            this.txt_IdPas.Name = "txt_IdPas";
            this.txt_IdPas.Size = new System.Drawing.Size(100, 20);
            this.txt_IdPas.TabIndex = 6;
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(388, 87);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(100, 20);
            this.txt_szukaj.TabIndex = 7;
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(27, 282);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 8;
            this.but_save.Text = "Zapisz";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_usun
            // 
            this.but_usun.Location = new System.Drawing.Point(125, 282);
            this.but_usun.Name = "but_usun";
            this.but_usun.Size = new System.Drawing.Size(75, 23);
            this.but_usun.TabIndex = 9;
            this.but_usun.Text = "Usuń";
            this.but_usun.UseVisualStyleBackColor = true;
            this.but_usun.Click += new System.EventHandler(this.but_usun_Click);
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(224, 282);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 10;
            this.but_clear.Text = "Wyczyść";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_Szukaj
            // 
            this.but_Szukaj.Location = new System.Drawing.Point(571, 86);
            this.but_Szukaj.Name = "but_Szukaj";
            this.but_Szukaj.Size = new System.Drawing.Size(75, 23);
            this.but_Szukaj.TabIndex = 11;
            this.but_Szukaj.Text = "Szukaj";
            this.but_Szukaj.UseVisualStyleBackColor = true;
            this.but_Szukaj.Click += new System.EventHandler(this.but_Szukaj_Click);
            // 
            // frmPasKursTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_Szukaj);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_usun);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.txt_IdPas);
            this.Controls.Add(this.txt_IdKurs);
            this.Controls.Add(this.txt_IdPasKurs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPasKurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPasKursTab";
            this.Text = "frmPasKursTab";
            this.Load += new System.EventHandler(this.frmPasKursTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasKurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasKurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdPasKurs;
        private System.Windows.Forms.TextBox txt_IdKurs;
        private System.Windows.Forms.TextBox txt_IdPas;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_usun;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_Szukaj;
    }
}