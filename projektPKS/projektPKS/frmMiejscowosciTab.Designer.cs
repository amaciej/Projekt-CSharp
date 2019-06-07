namespace projektPKS
{
    partial class frmMiejscowosciTab
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
            this.dgvMiesjsc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_save = new System.Windows.Forms.Button();
            this.but_usun = new System.Windows.Forms.Button();
            this.txt_IdMiej = new System.Windows.Forms.TextBox();
            this.txt_Nazwa = new System.Windows.Forms.TextBox();
            this.but_szukaj = new System.Windows.Forms.Button();
            this.txt_szukaj = new System.Windows.Forms.TextBox();
            this.but_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiesjsc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMiesjsc
            // 
            this.dgvMiesjsc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiesjsc.Location = new System.Drawing.Point(309, 73);
            this.dgvMiesjsc.Name = "dgvMiesjsc";
            this.dgvMiesjsc.ReadOnly = true;
            this.dgvMiesjsc.Size = new System.Drawing.Size(275, 237);
            this.dgvMiesjsc.TabIndex = 0;
            this.dgvMiesjsc.DoubleClick += new System.EventHandler(this.dgvMiesjsc_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id_Miejscowości";
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(15, 287);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 2;
            this.but_save.Text = "Dodaj";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_usun
            // 
            this.but_usun.Location = new System.Drawing.Point(116, 287);
            this.but_usun.Name = "but_usun";
            this.but_usun.Size = new System.Drawing.Size(75, 23);
            this.but_usun.TabIndex = 3;
            this.but_usun.Text = "Usuń";
            this.but_usun.UseVisualStyleBackColor = true;
            this.but_usun.Click += new System.EventHandler(this.but_usun_Click);
            // 
            // txt_IdMiej
            // 
            this.txt_IdMiej.Location = new System.Drawing.Point(116, 89);
            this.txt_IdMiej.Name = "txt_IdMiej";
            this.txt_IdMiej.ReadOnly = true;
            this.txt_IdMiej.Size = new System.Drawing.Size(100, 20);
            this.txt_IdMiej.TabIndex = 4;
            // 
            // txt_Nazwa
            // 
            this.txt_Nazwa.Location = new System.Drawing.Point(116, 139);
            this.txt_Nazwa.Name = "txt_Nazwa";
            this.txt_Nazwa.Size = new System.Drawing.Size(100, 20);
            this.txt_Nazwa.TabIndex = 5;
            // 
            // but_szukaj
            // 
            this.but_szukaj.Location = new System.Drawing.Point(475, 44);
            this.but_szukaj.Name = "but_szukaj";
            this.but_szukaj.Size = new System.Drawing.Size(55, 23);
            this.but_szukaj.TabIndex = 3;
            this.but_szukaj.Text = "Szukaj";
            this.but_szukaj.UseVisualStyleBackColor = true;
            this.but_szukaj.Click += new System.EventHandler(this.but_szukaj_Click);
            // 
            // txt_szukaj
            // 
            this.txt_szukaj.Location = new System.Drawing.Point(280, 44);
            this.txt_szukaj.Name = "txt_szukaj";
            this.txt_szukaj.Size = new System.Drawing.Size(172, 20);
            this.txt_szukaj.TabIndex = 4;
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(210, 287);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 6;
            this.but_clear.Text = "Wyczyść";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // frmMiejscowosciTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 397);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.txt_Nazwa);
            this.Controls.Add(this.txt_szukaj);
            this.Controls.Add(this.txt_IdMiej);
            this.Controls.Add(this.but_szukaj);
            this.Controls.Add(this.but_usun);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMiesjsc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMiejscowosciTab";
            this.Text = "Miejscowosci";
            this.Load += new System.EventHandler(this.frmMiejscowosciTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiesjsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMiesjsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_usun;
        private System.Windows.Forms.TextBox txt_IdMiej;
        private System.Windows.Forms.TextBox txt_Nazwa;
        private System.Windows.Forms.Button but_szukaj;
        private System.Windows.Forms.TextBox txt_szukaj;
        private System.Windows.Forms.Button but_clear;
    }
}