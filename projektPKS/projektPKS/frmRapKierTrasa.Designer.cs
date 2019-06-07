namespace projektPKS
{
    partial class frmRapKierTrasa
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
            this.dgvKierTrasa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.but_pokaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKierTrasa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKierTrasa
            // 
            this.dgvKierTrasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKierTrasa.Location = new System.Drawing.Point(29, 131);
            this.dgvKierTrasa.Name = "dgvKierTrasa";
            this.dgvKierTrasa.ReadOnly = true;
            this.dgvKierTrasa.Size = new System.Drawing.Size(447, 150);
            this.dgvKierTrasa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz czas aby pokazać kierowców, którzy są aktualnie w trasie\r\n";
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(247, 83);
            this.txt_Time.MaxLength = 8;
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(100, 20);
            this.txt_Time.TabIndex = 3;
            this.txt_Time.Text = "00:00:00";
            // 
            // but_pokaz
            // 
            this.but_pokaz.Location = new System.Drawing.Point(401, 80);
            this.but_pokaz.Name = "but_pokaz";
            this.but_pokaz.Size = new System.Drawing.Size(75, 23);
            this.but_pokaz.TabIndex = 4;
            this.but_pokaz.Text = "Pokaż";
            this.but_pokaz.UseVisualStyleBackColor = true;
            this.but_pokaz.Click += new System.EventHandler(this.but_pokaz_Click);
            // 
            // frmRapKierTrasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.but_pokaz);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKierTrasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRapKierTrasa";
            this.Text = "frmRapKierTrasa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKierTrasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKierTrasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.Button but_pokaz;
    }
}