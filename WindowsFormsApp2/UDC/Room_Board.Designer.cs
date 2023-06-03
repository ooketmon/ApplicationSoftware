namespace WindowsFormsApp2.UDC
{
    partial class Room_Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Board));
            this.Poster_1 = new System.Windows.Forms.PictureBox();
            this.Poster_4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Poster_1
            // 
            this.Poster_1.Image = global::WindowsFormsApp2.Properties.Resources._2F_Poster1;
            this.Poster_1.Location = new System.Drawing.Point(682, 360);
            this.Poster_1.Name = "Poster_1";
            this.Poster_1.Size = new System.Drawing.Size(144, 175);
            this.Poster_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Poster_1.TabIndex = 2;
            this.Poster_1.TabStop = false;
            this.Poster_1.Click += new System.EventHandler(this.Poster_1_Click);
            // 
            // Poster_4
            // 
            this.Poster_4.Image = global::WindowsFormsApp2.Properties.Resources._2F_Poster4;
            this.Poster_4.Location = new System.Drawing.Point(146, 476);
            this.Poster_4.Name = "Poster_4";
            this.Poster_4.Size = new System.Drawing.Size(119, 79);
            this.Poster_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Poster_4.TabIndex = 1;
            this.Poster_4.TabStop = false;
            this.Poster_4.Click += new System.EventHandler(this.Poster_4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Room_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Poster_1);
            this.Controls.Add(this.Poster_4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Room_Board";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.Poster_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Poster_4;
        private System.Windows.Forms.PictureBox Poster_1;
    }
}
