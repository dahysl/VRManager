namespace LoginTest
{
    partial class Welcome
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPswrd = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPswrd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(37, 15);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "User";
            // 
            // lblPswrd
            // 
            this.lblPswrd.AutoSize = true;
            this.lblPswrd.Location = new System.Drawing.Point(12, 61);
            this.lblPswrd.Name = "lblPswrd";
            this.lblPswrd.Size = new System.Drawing.Size(72, 15);
            this.lblPswrd.TabIndex = 10;
            this.lblPswrd.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(90, 23);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(240, 25);
            this.txtUser.TabIndex = 11;
            // 
            // txtPswrd
            // 
            this.txtPswrd.Location = new System.Drawing.Point(90, 58);
            this.txtPswrd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPswrd.Name = "txtPswrd";
            this.txtPswrd.Size = new System.Drawing.Size(237, 25);
            this.txtPswrd.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Location = new System.Drawing.Point(15, 101);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 25);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login(&L)";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(201, 101);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(126, 24);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register(&R)";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(362, 143);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPswrd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPswrd);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPswrd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPswrd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}

