namespace projektPKS
{
    partial class frmRapKier
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
            this.txt_IdKier = new System.Windows.Forms.TextBox();
            this.but_Pokaz = new System.Windows.Forms.Button();
            this.dgv_kier = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(122, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wprawdź swój numer identyfikacyjny aby wyświetlić potrzebne Ci informacje";
            // 
            // txt_IdKier
            // 
            this.txt_IdKier.Location = new System.Drawing.Point(239, 106);
            this.txt_IdKier.Name = "txt_IdKier";
            this.txt_IdKier.Size = new System.Drawing.Size(57, 20);
            this.txt_IdKier.TabIndex = 4;
            // 
            // but_Pokaz
            // 
            this.but_Pokaz.Location = new System.Drawing.Point(437, 100);
            this.but_Pokaz.Name = "but_Pokaz";
            this.but_Pokaz.Size = new System.Drawing.Size(75, 31);
            this.but_Pokaz.TabIndex = 5;
            this.but_Pokaz.Text = "Pokaż";
            this.but_Pokaz.UseVisualStyleBackColor = true;
            this.but_Pokaz.Click += new System.EventHandler(this.but_Pokaz_Click);
            // 
            // dgv_kier
            // 
            this.dgv_kier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kier.Location = new System.Drawing.Point(23, 146);
            this.dgv_kier.Name = "dgv_kier";
            this.dgv_kier.ReadOnly = true;
            this.dgv_kier.Size = new System.Drawing.Size(731, 150);
            this.dgv_kier.TabIndex = 6;
            // 
            // frmRapKier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_kier);
            this.Controls.Add(this.but_Pokaz);
            this.Controls.Add(this.txt_IdKier);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRapKier";
            this.Text = "frmRapKier";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdKier;
        private System.Windows.Forms.Button but_Pokaz;
        private System.Windows.Forms.DataGridView dgv_kier;
    }
}