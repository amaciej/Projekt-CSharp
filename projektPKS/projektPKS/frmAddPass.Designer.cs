namespace projektPKS
{
    partial class frmAddPass
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
            this.txt_imie = new System.Windows.Forms.TextBox();
            this.txt_nazw = new System.Windows.Forms.TextBox();
            this.but_Zapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(206, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aby zapisać się do kursu uzupełnij dane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(140, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(140, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // txt_imie
            // 
            this.txt_imie.Location = new System.Drawing.Point(280, 113);
            this.txt_imie.Name = "txt_imie";
            this.txt_imie.Size = new System.Drawing.Size(229, 20);
            this.txt_imie.TabIndex = 3;
            // 
            // txt_nazw
            // 
            this.txt_nazw.Location = new System.Drawing.Point(280, 155);
            this.txt_nazw.Name = "txt_nazw";
            this.txt_nazw.Size = new System.Drawing.Size(229, 20);
            this.txt_nazw.TabIndex = 4;
            // 
            // but_Zapisz
            // 
            this.but_Zapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_Zapisz.Location = new System.Drawing.Point(268, 224);
            this.but_Zapisz.Name = "but_Zapisz";
            this.but_Zapisz.Size = new System.Drawing.Size(124, 34);
            this.but_Zapisz.TabIndex = 5;
            this.but_Zapisz.Text = "Zapisz się";
            this.but_Zapisz.UseVisualStyleBackColor = true;
            this.but_Zapisz.Click += new System.EventHandler(this.but_Zapisz_Click);
            // 
            // frmAddPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.but_Zapisz);
            this.Controls.Add(this.txt_nazw);
            this.Controls.Add(this.txt_imie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPass";
            this.Text = "frmAddPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_imie;
        private System.Windows.Forms.TextBox txt_nazw;
        private System.Windows.Forms.Button but_Zapisz;
    }
}