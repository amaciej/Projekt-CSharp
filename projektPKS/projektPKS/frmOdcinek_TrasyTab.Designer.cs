namespace projektPKS
{
    partial class frmOdcinek_TrasyTab
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
            this.txt_IdTrasy = new System.Windows.Forms.TextBox();
            this.txt_IdOdcinek = new System.Windows.Forms.TextBox();
            this.txt_kolej = new System.Windows.Forms.TextBox();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.but_save = new System.Windows.Forms.Button();
            this.but_usun = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_Szukaj = new System.Windows.Forms.Button();
            this.dgv_OdcTras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OdcTras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Trasy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_Odcinek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kolejność";
            // 
            // txt_IdTrasy
            // 
            this.txt_IdTrasy.Location = new System.Drawing.Point(85, 85);
            this.txt_IdTrasy.Name = "txt_IdTrasy";
            this.txt_IdTrasy.Size = new System.Drawing.Size(100, 20);
            this.txt_IdTrasy.TabIndex = 3;
            // 
            // txt_IdOdcinek
            // 
            this.txt_IdOdcinek.Location = new System.Drawing.Point(85, 121);
            this.txt_IdOdcinek.Name = "txt_IdOdcinek";
            this.txt_IdOdcinek.Size = new System.Drawing.Size(100, 20);
            this.txt_IdOdcinek.TabIndex = 4;
            // 
            // txt_kolej
            // 
            this.txt_kolej.Location = new System.Drawing.Point(85, 153);
            this.txt_kolej.Name = "txt_kolej";
            this.txt_kolej.Size = new System.Drawing.Size(100, 20);
            this.txt_kolej.TabIndex = 5;
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(354, 44);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(100, 20);
            this.txt_szukaj.TabIndex = 5;
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(15, 296);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 6;
            this.but_save.Text = "Zapisz";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_usun
            // 
            this.but_usun.Location = new System.Drawing.Point(96, 296);
            this.but_usun.Name = "but_usun";
            this.but_usun.Size = new System.Drawing.Size(75, 23);
            this.but_usun.TabIndex = 7;
            this.but_usun.Text = "Usuń";
            this.but_usun.UseVisualStyleBackColor = true;
            this.but_usun.Click += new System.EventHandler(this.but_usun_Click);
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(177, 296);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 8;
            this.but_clear.Text = "Wyczyść";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_Szukaj
            // 
            this.but_Szukaj.Location = new System.Drawing.Point(561, 41);
            this.but_Szukaj.Name = "but_Szukaj";
            this.but_Szukaj.Size = new System.Drawing.Size(75, 23);
            this.but_Szukaj.TabIndex = 9;
            this.but_Szukaj.Text = "Szukaj";
            this.but_Szukaj.UseVisualStyleBackColor = true;
            this.but_Szukaj.Click += new System.EventHandler(this.but_Szukaj_Click);
            // 
            // dgv_OdcTras
            // 
            this.dgv_OdcTras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OdcTras.Location = new System.Drawing.Point(273, 70);
            this.dgv_OdcTras.Name = "dgv_OdcTras";
            this.dgv_OdcTras.Size = new System.Drawing.Size(363, 254);
            this.dgv_OdcTras.TabIndex = 10;
            this.dgv_OdcTras.DoubleClick += new System.EventHandler(this.dgv_OdcTras_DoubleClick);
            // 
            // frmOdcinek_TrasyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_OdcTras);
            this.Controls.Add(this.but_Szukaj);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_usun);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.txt_kolej);
            this.Controls.Add(this.txt_IdOdcinek);
            this.Controls.Add(this.txt_IdTrasy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOdcinek_TrasyTab";
            this.Text = "frmOdcinek_TrasyTab";
            this.Load += new System.EventHandler(this.frmOdcinek_TrasyTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OdcTras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdTrasy;
        private System.Windows.Forms.TextBox txt_IdOdcinek;
        private System.Windows.Forms.TextBox txt_kolej;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_usun;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_Szukaj;
        private System.Windows.Forms.DataGridView dgv_OdcTras;
    }
}