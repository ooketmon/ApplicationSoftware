namespace WindowsFormsApp2.UDC
{
    partial class ConvModeUDC
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
            this.contentConv = new System.Windows.Forms.Label();
            this.nameCharacter = new System.Windows.Forms.Label();
            this.timerLetter = new System.Windows.Forms.Timer(this.components);
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.imgConvWindowBack = new System.Windows.Forms.PictureBox();
            this.imgCharBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvWindowBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharBack)).BeginInit();
            this.SuspendLayout();
            // 
            // contentConv
            // 
            this.contentConv.AutoSize = true;
            this.contentConv.BackColor = System.Drawing.Color.White;
            this.contentConv.Font = new System.Drawing.Font("굴림", 20F);
            this.contentConv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contentConv.Location = new System.Drawing.Point(25, 695);
            this.contentConv.MinimumSize = new System.Drawing.Size(1050, 80);
            this.contentConv.Name = "contentConv";
            this.contentConv.Size = new System.Drawing.Size(1050, 80);
            this.contentConv.TabIndex = 10;
            this.contentConv.Text = "contentConv";
            this.contentConv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contentConv.UseWaitCursor = true;
            // 
            // nameCharacter
            // 
            this.nameCharacter.AutoSize = true;
            this.nameCharacter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameCharacter.Font = new System.Drawing.Font("굴림", 20F);
            this.nameCharacter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameCharacter.Location = new System.Drawing.Point(32, 645);
            this.nameCharacter.MaximumSize = new System.Drawing.Size(210, 34);
            this.nameCharacter.MinimumSize = new System.Drawing.Size(210, 34);
            this.nameCharacter.Name = "nameCharacter";
            this.nameCharacter.Size = new System.Drawing.Size(210, 34);
            this.nameCharacter.TabIndex = 11;
            this.nameCharacter.Text = "nameCharacter";
            this.nameCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLetter
            // 
            this.timerLetter.Interval = 30;
          
            // 
            // imgCharacter
            // 
            this.imgCharacter.BackColor = System.Drawing.Color.Transparent;
            this.imgCharacter.Location = new System.Drawing.Point(123, 223);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(289, 480);
            this.imgCharacter.TabIndex = 8;
            this.imgCharacter.TabStop = false;
            // 
            // btnSkip
            // 
            this.btnSkip.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Button;
            this.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkip.Location = new System.Drawing.Point(1059, 664);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(100, 100);
            this.btnSkip.TabIndex = 12;
            this.btnSkip.Text = "▶";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // imgConvWindowBack
            // 
            this.imgConvWindowBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgConvWindowBack.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ConvBack;
            this.imgConvWindowBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgConvWindowBack.Location = new System.Drawing.Point(-1, 614);
            this.imgConvWindowBack.Name = "imgConvWindowBack";
            this.imgConvWindowBack.Size = new System.Drawing.Size(1202, 187);
            this.imgConvWindowBack.TabIndex = 9;
            this.imgConvWindowBack.TabStop = false;
            // 
            // imgCharBack
            // 
            this.imgCharBack.BackColor = System.Drawing.Color.Transparent;
            this.imgCharBack.Location = new System.Drawing.Point(149, 234);
            this.imgCharBack.Name = "imgCharBack";
            this.imgCharBack.Size = new System.Drawing.Size(289, 480);
            this.imgCharBack.TabIndex = 13;
            this.imgCharBack.TabStop = false;
            // 
            // ConvModeUDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.contentConv);
            this.Controls.Add(this.nameCharacter);
            this.Controls.Add(this.imgConvWindowBack);
            this.Controls.Add(this.imgCharBack);
            this.Controls.Add(this.imgCharacter);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "ConvModeUDC";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.ConvModeUDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConvWindowBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label contentConv;
        public System.Windows.Forms.Label nameCharacter;
        public System.Windows.Forms.PictureBox imgCharacter;
        private System.Windows.Forms.Timer timerLetter;
        private System.Windows.Forms.Button btnSkip;
        public System.Windows.Forms.PictureBox imgConvWindowBack;
        public System.Windows.Forms.PictureBox imgCharBack;
    }
}
