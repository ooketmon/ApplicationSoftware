namespace WindowsFormsApp2
{
    partial class InitWindow
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
            this.btnStart = new System.Windows.Forms.Button();
            this.init_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.init_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.btn_start;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(481, 649);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(270, 60);
            this.btnStart.TabIndex = 4;
            this.btnStart.Tag = "btn";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // init_image
            // 
            this.init_image.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.init_image;
            this.init_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.init_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.init_image.Location = new System.Drawing.Point(0, 0);
            this.init_image.Name = "init_image";
            this.init_image.Size = new System.Drawing.Size(1200, 847);
            this.init_image.TabIndex = 6;
            this.init_image.TabStop = false;
            // 
            // InitWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.init_image);
            this.Name = "InitWindow";
            this.Size = new System.Drawing.Size(1200, 847);
            ((System.ComponentModel.ISupportInitialize)(this.init_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox init_image;
    }
}
