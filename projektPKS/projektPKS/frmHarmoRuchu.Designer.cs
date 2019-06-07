namespace projektPKS
{
    partial class frmHarmoRuchu
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
            this.dgvKursy = new System.Windows.Forms.DataGridView();
            this.dgvHarmTrasy = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.but_Pokaz = new System.Windows.Forms.Button();
            this.txt_IdKursy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarmTrasy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKursy
            // 
            this.dgvKursy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKursy.Location = new System.Drawing.Point(28, 104);
            this.dgvKursy.Name = "dgvKursy";
            this.dgvKursy.ReadOnly = true;
            this.dgvKursy.Size = new System.Drawing.Size(308, 255);
            this.dgvKursy.TabIndex = 0;
            // 
            // dgvHarmTrasy
            // 
            this.dgvHarmTrasy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHarmTrasy.Location = new System.Drawing.Point(425, 104);
            this.dgvHarmTrasy.Name = "dgvHarmTrasy";
            this.dgvHarmTrasy.ReadOnly = true;
            this.dgvHarmTrasy.Size = new System.Drawing.Size(289, 255);
            this.dgvHarmTrasy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id_Kursy";
            // 
            // but_Pokaz
            // 
            this.but_Pokaz.Location = new System.Drawing.Point(639, 62);
            this.but_Pokaz.Name = "but_Pokaz";
            this.but_Pokaz.Size = new System.Drawing.Size(75, 23);
            this.but_Pokaz.TabIndex = 4;
            this.but_Pokaz.Text = "Pokaż";
            this.but_Pokaz.UseVisualStyleBackColor = true;
            this.but_Pokaz.Click += new System.EventHandler(this.but_Pokaz_Click);
            // 
            // txt_IdKursy
            // 
            this.txt_IdKursy.Location = new System.Drawing.Point(482, 67);
            this.txt_IdKursy.Name = "txt_IdKursy";
            this.txt_IdKursy.Size = new System.Drawing.Size(100, 20);
            this.txt_IdKursy.TabIndex = 3;
            // 
            // frmHarmoRuchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_Pokaz);
            this.Controls.Add(this.txt_IdKursy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHarmTrasy);
            this.Controls.Add(this.dgvKursy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHarmoRuchu";
            this.Text = "frmHarmoRuchu";
            this.Load += new System.EventHandler(this.frmHarmoRuchu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKursy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarmTrasy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKursy;
        private System.Windows.Forms.DataGridView dgvHarmTrasy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Pokaz;
        private System.Windows.Forms.TextBox txt_IdKursy;
    }
}