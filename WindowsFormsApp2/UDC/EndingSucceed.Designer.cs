﻿namespace WindowsFormsApp2.UDC
{
    partial class EndingSucceed
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEndingSucceed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblEndingSucceed
            // 
            this.lblEndingSucceed.AutoSize = true;
            this.lblEndingSucceed.Location = new System.Drawing.Point(98, 75);
            this.lblEndingSucceed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEndingSucceed.Name = "lblEndingSucceed";
            this.lblEndingSucceed.Size = new System.Drawing.Size(77, 25);
            this.lblEndingSucceed.TabIndex = 0;
            this.lblEndingSucceed.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EndingSucceed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblEndingSucceed);
            this.Font = new System.Drawing.Font("굴림", 15F);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EndingSucceed";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.EndingSucceed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEndingSucceed;
        private System.Windows.Forms.Timer timer1;
    }
}
