namespace projektPKS
{
    partial class frmPasazerTab
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
            this.txt_IdPas = new System.Windows.Forms.TextBox();
            this.txt_Imie = new System.Windows.Forms.TextBox();
            this.txt_Nazw = new System.Windows.Forms.TextBox();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.but_save = new System.Windows.Forms.Button();
            this.but_usun = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_Szukaj = new System.Windows.Forms.Button();
            this.dgvPas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Pasażer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // txt_IdPas
            // 
            this.txt_IdPas.Location = new System.Drawing.Point(102, 88);
            this.txt_IdPas.Name = "txt_IdPas";
            this.txt_IdPas.ReadOnly = true;
            this.txt_IdPas.Size = new System.Drawing.Size(100, 20);
            this.txt_IdPas.TabIndex = 3;
            // 
            // txt_Imie
            // 
            this.txt_Imie.Location = new System.Drawing.Point(102, 124);
            this.txt_Imie.Name = "txt_Imie";
            this.txt_Imie.Size = new System.Drawing.Size(100, 20);
            this.txt_Imie.TabIndex = 4;
            // 
            // txt_Nazw
            // 
            this.txt_Nazw.Location = new System.Drawing.Point(102, 162);
            this.txt_Nazw.Name = "txt_Nazw";
            this.txt_Nazw.Size = new System.Drawing.Size(100, 20);
            this.txt_Nazw.TabIndex = 5;
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(375, 51);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(100, 20);
            this.txt_szukaj.TabIndex = 6;
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(41, 279);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 7;
            this.but_save.Text = "Zapisz";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_usun
            // 
            this.but_usun.Location = new System.Drawing.Point(141, 279);
            this.but_usun.Name = "but_usun";
            this.but_usun.Size = new System.Drawing.Size(75, 23);
            this.but_usun.TabIndex = 8;
            this.but_usun.Text = "Usuń";
            this.but_usun.UseVisualStyleBackColor = true;
            this.but_usun.Click += new System.EventHandler(this.but_usun_Click);
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(238, 279);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 9;
            this.but_clear.Text = "Wyczyść";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_Szukaj
            // 
            this.but_Szukaj.Location = new System.Drawing.Point(604, 48);
            this.but_Szukaj.Name = "but_Szukaj";
            this.but_Szukaj.Size = new System.Drawing.Size(75, 23);
            this.but_Szukaj.TabIndex = 10;
            this.but_Szukaj.Text = "Szukaj";
            this.but_Szukaj.UseVisualStyleBackColor = true;
            this.but_Szukaj.Click += new System.EventHandler(this.but_Szukaj_Click);
            // 
            // dgvPas
            // 
            this.dgvPas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPas.Location = new System.Drawing.Point(359, 88);
            this.dgvPas.Name = "dgvPas";
            this.dgvPas.ReadOnly = true;
            this.dgvPas.Size = new System.Drawing.Size(395, 222);
            this.dgvPas.TabIndex = 11;
            this.dgvPas.DoubleClick += new System.EventHandler(this.dgvPas_DoubleClick);
            // 
            // frmPasazerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPas);
            this.Controls.Add(this.but_Szukaj);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_usun);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.txt_Nazw);
            this.Controls.Add(this.txt_Imie);
            this.Controls.Add(this.txt_IdPas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPasazerTab";
            this.Text = "frmPasazerTab";
            this.Load += new System.EventHandler(this.frmPasazerTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdPas;
        private System.Windows.Forms.TextBox txt_Imie;
        private System.Windows.Forms.TextBox txt_Nazw;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_usun;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_Szukaj;
        private System.Windows.Forms.DataGridView dgvPas;
    }
}