namespace projektPKS
{
    partial class frmAdminTab
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
            this.txt_IdUzyt = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_Haslo = new System.Windows.Forms.TextBox();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.but_Szukaj = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.but_usun = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.dgvUzyt = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IdUpr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUzyt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Użytkownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_Uprawnienia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasło";
            // 
            // txt_IdUzyt
            // 
            this.txt_IdUzyt.Location = new System.Drawing.Point(118, 60);
            this.txt_IdUzyt.Name = "txt_IdUzyt";
            this.txt_IdUzyt.ReadOnly = true;
            this.txt_IdUzyt.Size = new System.Drawing.Size(100, 20);
            this.txt_IdUzyt.TabIndex = 4;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(118, 174);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(100, 20);
            this.txt_login.TabIndex = 6;
            // 
            // txt_Haslo
            // 
            this.txt_Haslo.Location = new System.Drawing.Point(118, 207);
            this.txt_Haslo.Name = "txt_Haslo";
            this.txt_Haslo.Size = new System.Drawing.Size(100, 20);
            this.txt_Haslo.TabIndex = 7;
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(387, 36);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(100, 20);
            this.txt_szukaj.TabIndex = 8;
            // 
            // but_Szukaj
            // 
            this.but_Szukaj.Location = new System.Drawing.Point(626, 36);
            this.but_Szukaj.Name = "but_Szukaj";
            this.but_Szukaj.Size = new System.Drawing.Size(75, 23);
            this.but_Szukaj.TabIndex = 9;
            this.but_Szukaj.Text = "Szukaj";
            this.but_Szukaj.UseVisualStyleBackColor = true;
            this.but_Szukaj.Click += new System.EventHandler(this.but_Szukaj_Click);
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(31, 268);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 10;
            this.but_save.Text = "Zapisz";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_usun
            // 
            this.but_usun.Location = new System.Drawing.Point(127, 268);
            this.but_usun.Name = "but_usun";
            this.but_usun.Size = new System.Drawing.Size(75, 23);
            this.but_usun.TabIndex = 11;
            this.but_usun.Text = "Usuń";
            this.but_usun.UseVisualStyleBackColor = true;
            this.but_usun.Click += new System.EventHandler(this.but_usun_Click);
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(222, 268);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 12;
            this.but_clear.Text = "Wyczyść";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // dgvUzyt
            // 
            this.dgvUzyt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUzyt.Location = new System.Drawing.Point(377, 65);
            this.dgvUzyt.Name = "dgvUzyt";
            this.dgvUzyt.ReadOnly = true;
            this.dgvUzyt.Size = new System.Drawing.Size(378, 226);
            this.dgvUzyt.TabIndex = 13;
            this.dgvUzyt.DoubleClick += new System.EventHandler(this.dgvUzyt_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "1: Administrator  |  2: Dyspozytor  |  3: Kierowca  |  4: Pasażer";
            // 
            // txt_IdUpr
            // 
            this.txt_IdUpr.Location = new System.Drawing.Point(118, 95);
            this.txt_IdUpr.Name = "txt_IdUpr";
            this.txt_IdUpr.Size = new System.Drawing.Size(100, 20);
            this.txt_IdUpr.TabIndex = 5;
            // 
            // frmAdminTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvUzyt);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_usun);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.but_Szukaj);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.txt_Haslo);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_IdUpr);
            this.Controls.Add(this.txt_IdUzyt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminTab";
            this.Text = "frmAdminTab";
            this.Load += new System.EventHandler(this.frmAdminTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUzyt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IdUzyt;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_Haslo;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.Button but_Szukaj;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_usun;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.DataGridView dgvUzyt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IdUpr;
    }
}