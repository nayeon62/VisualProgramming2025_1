﻿namespace _006_Lablels
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
            this.btnRaffaello = new System.Windows.Forms.Button();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblArt = new System.Windows.Forms.Label();
            this.btnDavinch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRaffaello
            // 
            this.btnRaffaello.Location = new System.Drawing.Point(84, 53);
            this.btnRaffaello.Name = "btnRaffaello";
            this.btnRaffaello.Size = new System.Drawing.Size(270, 60);
            this.btnRaffaello.TabIndex = 0;
            this.btnRaffaello.Text = "라파엘로, 아테네 학당";
            this.btnRaffaello.UseVisualStyleBackColor = true;
            this.btnRaffaello.Click += new System.EventHandler(this.btnRaffaello_Click);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(110, 160);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(0, 18);
            this.lblArtist.TabIndex = 1;
            // 
            // lblArt
            // 
            this.lblArt.Location = new System.Drawing.Point(110, 216);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(604, 201);
            this.lblArt.TabIndex = 2;
            // 
            // btnDavinch
            // 
            this.btnDavinch.Location = new System.Drawing.Point(396, 53);
            this.btnDavinch.Name = "btnDavinch";
            this.btnDavinch.Size = new System.Drawing.Size(270, 60);
            this.btnDavinch.TabIndex = 3;
            this.btnDavinch.Text = "다빈치, 모나리자";
            this.btnDavinch.UseVisualStyleBackColor = true;
            this.btnDavinch.Click += new System.EventHandler(this.btnDavinch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDavinch);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.btnRaffaello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRaffaello;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.Button btnDavinch;
    }
}

