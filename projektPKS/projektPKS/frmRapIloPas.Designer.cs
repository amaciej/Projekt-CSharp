namespace projektPKS
{
    partial class frmRapIloPas
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
            this.dgvRapIloPas = new System.Windows.Forms.DataGridView();
            this.txt_idKursu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_Pokaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_godzS = new System.Windows.Forms.TextBox();
            this.txt_godzK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapIloPas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRapIloPas
            // 
            this.dgvRapIloPas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapIloPas.Location = new System.Drawing.Point(196, 166);
            this.dgvRapIloPas.Name = "dgvRapIloPas";
            this.dgvRapIloPas.ReadOnly = true;
            this.dgvRapIloPas.Size = new System.Drawing.Size(240, 150);
            this.dgvRapIloPas.TabIndex = 0;
            // 
            // txt_idKursu
            // 
            this.txt_idKursu.Location = new System.Drawing.Point(111, 77);
            this.txt_idKursu.Name = "txt_idKursu";
            this.txt_idKursu.Size = new System.Drawing.Size(69, 20);
            this.txt_idKursu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(97, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wproawdź Id_Kursu oraz zakres dla którego chcesz uzyskać raport o liczbie pasażer" +
    "ów\r\n";
            // 
            // but_Pokaz
            // 
            this.but_Pokaz.Location = new System.Drawing.Point(307, 118);
            this.but_Pokaz.Name = "but_Pokaz";
            this.but_Pokaz.Size = new System.Drawing.Size(75, 26);
            this.but_Pokaz.TabIndex = 3;
            this.but_Pokaz.Text = "Pokaż";
            this.but_Pokaz.UseVisualStyleBackColor = true;
            this.but_Pokaz.Click += new System.EventHandler(this.but_Pokaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id_Kursu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data i Godz. Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data i Godz. Do";
            // 
            // txt_godzS
            // 
            this.txt_godzS.Location = new System.Drawing.Point(307, 76);
            this.txt_godzS.MaxLength = 18;
            this.txt_godzS.Name = "txt_godzS";
            this.txt_godzS.Size = new System.Drawing.Size(129, 20);
            this.txt_godzS.TabIndex = 7;
            this.txt_godzS.Text = "YYYY-MM-DD 00:00:00";
            // 
            // txt_godzK
            // 
            this.txt_godzK.Location = new System.Drawing.Point(550, 77);
            this.txt_godzK.Name = "txt_godzK";
            this.txt_godzK.Size = new System.Drawing.Size(122, 20);
            this.txt_godzK.TabIndex = 8;
            this.txt_godzK.Text = "YYYY-MM-DD 00:00:00";
            // 
            // frmRapIloPas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_godzK);
            this.Controls.Add(this.txt_godzS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_Pokaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idKursu);
            this.Controls.Add(this.dgvRapIloPas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRapIloPas";
            this.Text = "frmRapIloPas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapIloPas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRapIloPas;
        private System.Windows.Forms.TextBox txt_idKursu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Pokaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_godzS;
        private System.Windows.Forms.TextBox txt_godzK;
    }
}