namespace CRUD_Winform
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblregister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(255, 156);
            this.TBUsername.Multiline = true;
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(292, 44);
            this.TBUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(255, 242);
            this.TBPassword.Multiline = true;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(292, 41);
            this.TBPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(338, 333);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 52);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblregister
            // 
            this.lblregister.AutoSize = true;
            this.lblregister.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregister.ForeColor = System.Drawing.Color.Red;
            this.lblregister.Location = new System.Drawing.Point(259, 286);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(287, 28);
            this.lblregister.TabIndex = 6;
            this.lblregister.Text = "Belum Punya Akun? Registrasi";
            this.lblregister.Click += new System.EventHandler(this.lblregister_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 481);
            this.Controls.Add(this.lblregister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.label2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblregister;
    }
}