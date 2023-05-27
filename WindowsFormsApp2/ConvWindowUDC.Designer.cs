namespace WindowsFormsApp2
{
    partial class ConvWindowUDC
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contentConv = new System.Windows.Forms.Label();
            this.imgConvWin = new System.Windows.Forms.PictureBox();
            this.nameCharacter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvWin)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1113, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Skip";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1113, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1018, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contentConv
            // 
            this.contentConv.AutoSize = true;
            this.contentConv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contentConv.Font = new System.Drawing.Font("굴림", 20F);
            this.contentConv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contentConv.Location = new System.Drawing.Point(12, 89);
            this.contentConv.MinimumSize = new System.Drawing.Size(1100, 150);
            this.contentConv.Name = "contentConv";
            this.contentConv.Size = new System.Drawing.Size(1100, 150);
            this.contentConv.TabIndex = 4;
            this.contentConv.Text = "contentConv";
            // 
            // imgConvWin
            // 
            this.imgConvWin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgConvWin.Location = new System.Drawing.Point(0, -1);
            this.imgConvWin.Name = "imgConvWin";
            this.imgConvWin.Size = new System.Drawing.Size(1202, 275);
            this.imgConvWin.TabIndex = 3;
            this.imgConvWin.TabStop = false;
            this.imgConvWin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameCharacter
            // 
            this.nameCharacter.AutoSize = true;
            this.nameCharacter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameCharacter.Font = new System.Drawing.Font("굴림", 20F);
            this.nameCharacter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameCharacter.Location = new System.Drawing.Point(12, 20);
            this.nameCharacter.Name = "nameCharacter";
            this.nameCharacter.Size = new System.Drawing.Size(254, 34);
            this.nameCharacter.TabIndex = 5;
            this.nameCharacter.Text = "nameCharacter";
            // 
            // ConvWindowUDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contentConv);
            this.Controls.Add(this.nameCharacter);
            this.Controls.Add(this.imgConvWin);
            this.MaximumSize = new System.Drawing.Size(1202, 275);
            this.MinimumSize = new System.Drawing.Size(1202, 275);
            this.Name = "ConvWindowUDC";
            this.Size = new System.Drawing.Size(1202, 275);
            this.Load += new System.EventHandler(this.ConvWindowUDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgConvWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label contentConv;
        private System.Windows.Forms.PictureBox imgConvWin;
        private System.Windows.Forms.Label nameCharacter;
    }
}
