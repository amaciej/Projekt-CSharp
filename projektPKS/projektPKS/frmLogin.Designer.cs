namespace projektPKS
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.but_login = new System.Windows.Forms.Button();
            this.but_haslo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.txt_Hasło = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_login
            // 
            this.but_login.Location = new System.Drawing.Point(52, 188);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(75, 23);
            this.but_login.TabIndex = 0;
            this.but_login.Text = "Zaloguj";
            this.but_login.UseVisualStyleBackColor = true;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // but_haslo
            // 
            this.but_haslo.Location = new System.Drawing.Point(146, 188);
            this.but_haslo.Name = "but_haslo";
            this.but_haslo.Size = new System.Drawing.Size(75, 23);
            this.but_haslo.TabIndex = 0;
            this.but_haslo.Text = "Rejestracja";
            this.but_haslo.UseVisualStyleBackColor = true;
            this.but_haslo.Click += new System.EventHandler(this.but_haslo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(138, 43);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(100, 20);
            this.txt_Login.TabIndex = 2;
            // 
            // txt_Hasło
            // 
            this.txt_Hasło.Location = new System.Drawing.Point(138, 85);
            this.txt_Hasło.Name = "txt_Hasło";
            this.txt_Hasło.PasswordChar = '•';
            this.txt_Hasło.Size = new System.Drawing.Size(100, 20);
            this.txt_Hasło.TabIndex = 2;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(295, 286);
            this.Controls.Add(this.txt_Hasło);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_haslo);
            this.Controls.Add(this.but_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Logowanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Button but_haslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.TextBox txt_Hasło;
    }
}

