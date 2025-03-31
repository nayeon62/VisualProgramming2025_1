namespace _003_Login
{
    partial class Form1
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
            this.Login = new System.Windows.Forms.Button();
            this.ＩＤ = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(161, 204);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(109, 30);
            this.Login.TabIndex = 0;
            this.Login.Text = "로그인";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // ＩＤ
            // 
            this.ＩＤ.AutoSize = true;
            this.ＩＤ.Location = new System.Drawing.Point(68, 73);
            this.ＩＤ.Name = "ＩＤ";
            this.ＩＤ.Size = new System.Drawing.Size(62, 18);
            this.ＩＤ.TabIndex = 1;
            this.ＩＤ.Text = "아이디";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(161, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(115, 28);
            this.txtID.TabIndex = 2;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(161, 119);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '●';
            this.txtPW.Size = new System.Drawing.Size(115, 28);
            this.txtPW.TabIndex = 4;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(68, 122);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(80, 18);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "패스워드";
            this.Pass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(156, 273);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(120, 28);
            this.txtResult.TabIndex = 6;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ＩＤ);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label ＩＤ;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox txtResult;
    }
}

