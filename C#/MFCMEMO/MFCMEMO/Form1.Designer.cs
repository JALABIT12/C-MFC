
namespace MFCMEMO
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
            this.tbMemo1 = new System.Windows.Forms.TextBox();
            this.tbMemo2 = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMemo1
            // 
            this.tbMemo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo1.Location = new System.Drawing.Point(-1, -2);
            this.tbMemo1.Multiline = true;
            this.tbMemo1.Name = "tbMemo1";
            this.tbMemo1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMemo1.Size = new System.Drawing.Size(591, 357);
            this.tbMemo1.TabIndex = 0;
            // 
            // tbMemo2
            // 
            this.tbMemo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo2.Location = new System.Drawing.Point(-1, 471);
            this.tbMemo2.Multiline = true;
            this.tbMemo2.Name = "tbMemo2";
            this.tbMemo2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMemo2.Size = new System.Drawing.Size(591, 357);
            this.tbMemo2.TabIndex = 0;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(665, 24);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(107, 37);
            this.btnS.TabIndex = 1;
            this.btnS.Text = "소문자로";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(665, 80);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(107, 37);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "대문자로";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnH
            // 
            this.btnH.Location = new System.Drawing.Point(665, 142);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(122, 37);
            this.btnH.TabIndex = 1;
            this.btnH.Text = "16진수(Hex)";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(815, 24);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(122, 37);
            this.btnT.TabIndex = 1;
            this.btnT.Text = "Test";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 828);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.tbMemo2);
            this.Controls.Add(this.tbMemo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMemo1;
        private System.Windows.Forms.TextBox tbMemo2;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnT;
    }
}

