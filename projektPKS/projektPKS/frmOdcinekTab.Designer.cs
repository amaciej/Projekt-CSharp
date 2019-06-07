namespace projektPKS
{
    partial class frmOdcinekTab
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
            this.lbl_Id_Miejscowości_S = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Godz_Początek = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IdOdcinek = new System.Windows.Forms.TextBox();
            this.txt_Dlugosc = new System.Windows.Forms.TextBox();
            this.txt_gPoczatek = new System.Windows.Forms.TextBox();
            this.txt_gkoniec = new System.Windows.Forms.TextBox();
            this.txt_cena = new System.Windows.Forms.TextBox();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.but_save = new System.Windows.Forms.Button();
            this.but_usun = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_szukaj = new System.Windows.Forms.Button();
            this.dgvOdcinek = new System.Windows.Forms.DataGridView();
            this.cb_poczatek = new System.Windows.Forms.ComboBox();
            this.cb_koniec = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdcinek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Odcinek";
            // 
            // lbl_Id_Miejscowości_S
            // 
            this.lbl_Id_Miejscowości_S.AutoSize = true;
            this.lbl_Id_Miejscowości_S.Location = new System.Drawing.Point(12, 105);
            this.lbl_Id_Miejscowości_S.Name = "lbl_Id_Miejscowości_S";
            this.lbl_Id_Miejscowości_S.Size = new System.Drawing.Size(81, 13);
            this.lbl_Id_Miejscowości_S.TabIndex = 1;
            this.lbl_Id_Miejscowości_S.Text = "Miejscowość_S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miejscowość_K";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Długość";
            // 
            // lbl_Godz_Początek
            // 
            this.lbl_Godz_Początek.AutoSize = true;
            this.lbl_Godz_Początek.Location = new System.Drawing.Point(12, 190);
            this.lbl_Godz_Początek.Name = "lbl_Godz_Początek";
            this.lbl_Godz_Początek.Size = new System.Drawing.Size(83, 13);
            this.lbl_Godz_Początek.TabIndex = 4;
            this.lbl_Godz_Początek.Text = "Godz_Początek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Godz_Koniec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cena biletu";
            // 
            // txt_IdOdcinek
            // 
            this.txt_IdOdcinek.Location = new System.Drawing.Point(113, 70);
            this.txt_IdOdcinek.Name = "txt_IdOdcinek";
            this.txt_IdOdcinek.ReadOnly = true;
            this.txt_IdOdcinek.Size = new System.Drawing.Size(131, 20);
            this.txt_IdOdcinek.TabIndex = 7;
            // 
            // txt_Dlugosc
            // 
            this.txt_Dlugosc.Location = new System.Drawing.Point(113, 158);
            this.txt_Dlugosc.Name = "txt_Dlugosc";
            this.txt_Dlugosc.Size = new System.Drawing.Size(131, 20);
            this.txt_Dlugosc.TabIndex = 10;
            // 
            // txt_gPoczatek
            // 
            this.txt_gPoczatek.Location = new System.Drawing.Point(113, 187);
            this.txt_gPoczatek.Name = "txt_gPoczatek";
            this.txt_gPoczatek.Size = new System.Drawing.Size(131, 20);
            this.txt_gPoczatek.TabIndex = 11;
            // 
            // txt_gkoniec
            // 
            this.txt_gkoniec.Location = new System.Drawing.Point(113, 217);
            this.txt_gkoniec.Name = "txt_gkoniec";
            this.txt_gkoniec.Size = new System.Drawing.Size(131, 20);
            this.txt_gkoniec.TabIndex = 12;
            // 
            // txt_cena
            // 
            this.txt_cena.Location = new System.Drawing.Point(113, 248);
            this.txt_cena.Name = "txt_cena";
            this.txt_cena.Size = new System.Drawing.Size(131, 20);
            this.txt_cena.TabIndex = 13;
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(291, 37);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(405, 20);
            this.txt_szukaj.TabIndex = 14;
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(15, 340);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 15;
            this.but_save.Text = "Zapisz";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_usun
            // 
            this.but_usun.Location = new System.Drawing.Point(113, 340);
            this.but_usun.Name = "but_usun";
            this.but_usun.Size = new System.Drawing.Size(75, 23);
            this.but_usun.TabIndex = 16;
            this.but_usun.Text = "Usuń";
            this.but_usun.UseVisualStyleBackColor = true;
            this.but_usun.Click += new System.EventHandler(this.but_usun_Click);
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(210, 340);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 17;
            this.but_clear.Text = "Wyczyść";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_szukaj
            // 
            this.but_szukaj.Location = new System.Drawing.Point(702, 37);
            this.but_szukaj.Name = "but_szukaj";
            this.but_szukaj.Size = new System.Drawing.Size(89, 23);
            this.but_szukaj.TabIndex = 17;
            this.but_szukaj.Text = "Szukaj";
            this.but_szukaj.UseVisualStyleBackColor = true;
            this.but_szukaj.Click += new System.EventHandler(this.but_szukaj_Click);
            // 
            // dgvOdcinek
            // 
            this.dgvOdcinek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdcinek.Location = new System.Drawing.Point(291, 80);
            this.dgvOdcinek.Name = "dgvOdcinek";
            this.dgvOdcinek.ReadOnly = true;
            this.dgvOdcinek.Size = new System.Drawing.Size(500, 283);
            this.dgvOdcinek.TabIndex = 18;
            this.dgvOdcinek.DoubleClick += new System.EventHandler(this.dgvOdcinek_DoubleClick);
            // 
            // cb_poczatek
            // 
            this.cb_poczatek.FormattingEnabled = true;
            this.cb_poczatek.Location = new System.Drawing.Point(113, 102);
            this.cb_poczatek.Name = "cb_poczatek";
            this.cb_poczatek.Size = new System.Drawing.Size(131, 21);
            this.cb_poczatek.TabIndex = 19;
            // 
            // cb_koniec
            // 
            this.cb_koniec.FormattingEnabled = true;
            this.cb_koniec.Location = new System.Drawing.Point(113, 129);
            this.cb_koniec.Name = "cb_koniec";
            this.cb_koniec.Size = new System.Drawing.Size(131, 21);
            this.cb_koniec.TabIndex = 20;
            // 
            // frmOdcinekTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 455);
            this.Controls.Add(this.cb_koniec);
            this.Controls.Add(this.cb_poczatek);
            this.Controls.Add(this.dgvOdcinek);
            this.Controls.Add(this.but_szukaj);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_usun);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.txt_cena);
            this.Controls.Add(this.txt_gkoniec);
            this.Controls.Add(this.txt_gPoczatek);
            this.Controls.Add(this.txt_Dlugosc);
            this.Controls.Add(this.txt_IdOdcinek);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Godz_Początek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Id_Miejscowości_S);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOdcinekTab";
            this.Text = "frmOdcinekTab";
            this.Load += new System.EventHandler(this.frmOdcinekTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdcinek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Id_Miejscowości_S;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Godz_Początek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_IdOdcinek;
        private System.Windows.Forms.TextBox txt_Dlugosc;
        private System.Windows.Forms.TextBox txt_gPoczatek;
        private System.Windows.Forms.TextBox txt_gkoniec;
        private System.Windows.Forms.TextBox txt_cena;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_usun;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_szukaj;
        private System.Windows.Forms.DataGridView dgvOdcinek;
        private System.Windows.Forms.ComboBox cb_poczatek;
        private System.Windows.Forms.ComboBox cb_koniec;
    }
}