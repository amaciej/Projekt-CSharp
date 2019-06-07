namespace projektPKS
{
    partial class frmRejestracja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRejestracja));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Hasło = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_haslo = new System.Windows.Forms.TextBox();
            this.rB_Admin = new System.Windows.Forms.RadioButton();
            this.rB_Dyspozytor = new System.Windows.Forms.RadioButton();
            this.rB_kierowca = new System.Windows.Forms.RadioButton();
            this.rB_Pasazer = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_close = new System.Windows.Forms.ToolStripButton();
            this.tb_return = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wypełnij poniższe dane aby założyć konto\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login:";
            // 
            // lbl_Hasło
            // 
            this.lbl_Hasło.AutoSize = true;
            this.lbl_Hasło.Location = new System.Drawing.Point(40, 152);
            this.lbl_Hasło.Name = "lbl_Hasło";
            this.lbl_Hasło.Size = new System.Drawing.Size(39, 13);
            this.lbl_Hasło.TabIndex = 2;
            this.lbl_Hasło.Text = "Hasło:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rodzaj konta";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(115, 100);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(144, 20);
            this.txt_login.TabIndex = 4;
            // 
            // txt_haslo
            // 
            this.txt_haslo.Location = new System.Drawing.Point(115, 149);
            this.txt_haslo.Name = "txt_haslo";
            this.txt_haslo.Size = new System.Drawing.Size(144, 20);
            this.txt_haslo.TabIndex = 5;
            // 
            // rB_Admin
            // 
            this.rB_Admin.AutoSize = true;
            this.rB_Admin.Location = new System.Drawing.Point(42, 240);
            this.rB_Admin.Name = "rB_Admin";
            this.rB_Admin.Size = new System.Drawing.Size(85, 17);
            this.rB_Admin.TabIndex = 6;
            this.rB_Admin.TabStop = true;
            this.rB_Admin.Text = "Administrator";
            this.rB_Admin.UseVisualStyleBackColor = true;
            // 
            // rB_Dyspozytor
            // 
            this.rB_Dyspozytor.AutoSize = true;
            this.rB_Dyspozytor.Location = new System.Drawing.Point(133, 240);
            this.rB_Dyspozytor.Name = "rB_Dyspozytor";
            this.rB_Dyspozytor.Size = new System.Drawing.Size(77, 17);
            this.rB_Dyspozytor.TabIndex = 7;
            this.rB_Dyspozytor.TabStop = true;
            this.rB_Dyspozytor.Text = "Dyspozytor";
            this.rB_Dyspozytor.UseVisualStyleBackColor = true;
            // 
            // rB_kierowca
            // 
            this.rB_kierowca.AutoSize = true;
            this.rB_kierowca.Location = new System.Drawing.Point(216, 240);
            this.rB_kierowca.Name = "rB_kierowca";
            this.rB_kierowca.Size = new System.Drawing.Size(69, 17);
            this.rB_kierowca.TabIndex = 8;
            this.rB_kierowca.TabStop = true;
            this.rB_kierowca.Text = "Kierowca";
            this.rB_kierowca.UseVisualStyleBackColor = true;
            // 
            // rB_Pasazer
            // 
            this.rB_Pasazer.AutoSize = true;
            this.rB_Pasazer.Location = new System.Drawing.Point(291, 240);
            this.rB_Pasazer.Name = "rB_Pasazer";
            this.rB_Pasazer.Size = new System.Drawing.Size(63, 17);
            this.rB_Pasazer.TabIndex = 9;
            this.rB_Pasazer.TabStop = true;
            this.rB_Pasazer.Text = "Pasażer";
            this.rB_Pasazer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Załóż konto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_close,
            this.tb_return});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(397, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tb_close
            // 
            this.tb_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_close.Image = ((System.Drawing.Image)(resources.GetObject("tb_close.Image")));
            this.tb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_close.Name = "tb_close";
            this.tb_close.Size = new System.Drawing.Size(23, 22);
            this.tb_close.Text = "Zamknij";
            this.tb_close.Click += new System.EventHandler(this.tb_close_Click);
            // 
            // tb_return
            // 
            this.tb_return.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_return.Image = ((System.Drawing.Image)(resources.GetObject("tb_return.Image")));
            this.tb_return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_return.Name = "tb_return";
            this.tb_return.Size = new System.Drawing.Size(23, 22);
            this.tb_return.Text = "Powrót";
            this.tb_return.Click += new System.EventHandler(this.tb_return_Click);
            // 
            // frmRejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(397, 365);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rB_Pasazer);
            this.Controls.Add(this.rB_kierowca);
            this.Controls.Add(this.rB_Dyspozytor);
            this.Controls.Add(this.rB_Admin);
            this.Controls.Add(this.txt_haslo);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Hasło);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRejestracja";
            this.Text = "Rejestracja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRejestracja_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Hasło;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_haslo;
        private System.Windows.Forms.RadioButton rB_Admin;
        private System.Windows.Forms.RadioButton rB_Dyspozytor;
        private System.Windows.Forms.RadioButton rB_kierowca;
        private System.Windows.Forms.RadioButton rB_Pasazer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tb_close;
        private System.Windows.Forms.ToolStripButton tb_return;
    }
}