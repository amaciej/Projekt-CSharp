namespace projektPKS
{
    partial class frmKursyTab
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_gKoniec = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IdKusry = new System.Windows.Forms.TextBox();
            this.txt_IdAuto = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_gPoczatek = new System.Windows.Forms.TextBox();
            this.txt_gKoniec = new System.Windows.Forms.TextBox();
            this.txt_IloPas = new System.Windows.Forms.TextBox();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.but_save = new System.Windows.Forms.Button();
            this.but_usun = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_Szukaj = new System.Windows.Forms.Button();
            this.dgvKursy = new System.Windows.Forms.DataGridView();
            this.cbTrasa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Kursy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa Trasy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id_Autokaru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Godzina Rozpoczęcia";
            // 
            // lbl_gKoniec
            // 
            this.lbl_gKoniec.AutoSize = true;
            this.lbl_gKoniec.Location = new System.Drawing.Point(1, 199);
            this.lbl_gKoniec.Name = "lbl_gKoniec";
            this.lbl_gKoniec.Size = new System.Drawing.Size(111, 13);
            this.lbl_gKoniec.TabIndex = 5;
            this.lbl_gKoniec.Text = "Godzina Zakończenia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ilość Pasażerów";
            // 
            // txt_IdKusry
            // 
            this.txt_IdKusry.Location = new System.Drawing.Point(118, 55);
            this.txt_IdKusry.Name = "txt_IdKusry";
            this.txt_IdKusry.ReadOnly = true;
            this.txt_IdKusry.Size = new System.Drawing.Size(121, 20);
            this.txt_IdKusry.TabIndex = 7;
            // 
            // txt_IdAuto
            // 
            this.txt_IdAuto.Location = new System.Drawing.Point(118, 115);
            this.txt_IdAuto.Name = "txt_IdAuto";
            this.txt_IdAuto.Size = new System.Drawing.Size(121, 20);
            this.txt_IdAuto.TabIndex = 9;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(118, 141);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(121, 20);
            this.txt_Dni.TabIndex = 10;
            // 
            // txt_gPoczatek
            // 
            this.txt_gPoczatek.Location = new System.Drawing.Point(118, 167);
            this.txt_gPoczatek.Name = "txt_gPoczatek";
            this.txt_gPoczatek.Size = new System.Drawing.Size(121, 20);
            this.txt_gPoczatek.TabIndex = 11;
            // 
            // txt_gKoniec
            // 
            this.txt_gKoniec.Location = new System.Drawing.Point(118, 196);
            this.txt_gKoniec.Name = "txt_gKoniec";
            this.txt_gKoniec.Size = new System.Drawing.Size(121, 20);
            this.txt_gKoniec.TabIndex = 12;
            // 
            // txt_IloPas
            // 
            this.txt_IloPas.Location = new System.Drawing.Point(118, 224);
            this.txt_IloPas.Name = "txt_IloPas";
            this.txt_IloPas.Size = new System.Drawing.Size(121, 20);
            this.txt_IloPas.TabIndex = 13;
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(356, 22);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(100, 20);
            this.txt_szukaj.TabIndex = 14;
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(37, 287);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 15;
            this.but_save.Text = "Zapisz";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_usun
            // 
            this.but_usun.Location = new System.Drawing.Point(143, 287);
            this.but_usun.Name = "but_usun";
            this.but_usun.Size = new System.Drawing.Size(75, 23);
            this.but_usun.TabIndex = 16;
            this.but_usun.Text = "Usuń";
            this.but_usun.UseVisualStyleBackColor = true;
            this.but_usun.Click += new System.EventHandler(this.but_usun_Click);
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(245, 287);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 17;
            this.but_clear.Text = "Wyczyść";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_Szukaj
            // 
            this.but_Szukaj.Location = new System.Drawing.Point(591, 22);
            this.but_Szukaj.Name = "but_Szukaj";
            this.but_Szukaj.Size = new System.Drawing.Size(75, 23);
            this.but_Szukaj.TabIndex = 18;
            this.but_Szukaj.Text = "Szukaj";
            this.but_Szukaj.UseVisualStyleBackColor = true;
            this.but_Szukaj.Click += new System.EventHandler(this.but_Szukaj_Click);
            // 
            // dgvKursy
            // 
            this.dgvKursy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursy.Location = new System.Drawing.Point(356, 58);
            this.dgvKursy.Name = "dgvKursy";
            this.dgvKursy.Size = new System.Drawing.Size(341, 252);
            this.dgvKursy.TabIndex = 19;
            this.dgvKursy.DoubleClick += new System.EventHandler(this.dgvKursy_DoubleClick);
            // 
            // cbTrasa
            // 
            this.cbTrasa.FormattingEnabled = true;
            this.cbTrasa.Location = new System.Drawing.Point(118, 86);
            this.cbTrasa.Name = "cbTrasa";
            this.cbTrasa.Size = new System.Drawing.Size(121, 21);
            this.cbTrasa.TabIndex = 20;
            // 
            // frmKursyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTrasa);
            this.Controls.Add(this.dgvKursy);
            this.Controls.Add(this.but_Szukaj);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_usun);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.txt_IloPas);
            this.Controls.Add(this.txt_gKoniec);
            this.Controls.Add(this.txt_gPoczatek);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_IdAuto);
            this.Controls.Add(this.txt_IdKusry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_gKoniec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKursyTab";
            this.Text = "frmKursyTab";
            this.Load += new System.EventHandler(this.frmKursyTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_gKoniec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_IdKusry;
        private System.Windows.Forms.TextBox txt_IdAuto;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_gPoczatek;
        private System.Windows.Forms.TextBox txt_gKoniec;
        private System.Windows.Forms.TextBox txt_IloPas;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_usun;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_Szukaj;
        private System.Windows.Forms.DataGridView dgvKursy;
        private System.Windows.Forms.ComboBox cbTrasa;
    }
}