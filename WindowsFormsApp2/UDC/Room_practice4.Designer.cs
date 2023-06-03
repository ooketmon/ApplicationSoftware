namespace WindowsFormsApp2.UDC
{
    partial class Room_practice4
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
            this.key_4 = new System.Windows.Forms.PictureBox();
            this.room_practice_4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.key_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_practice_4)).BeginInit();
            this.SuspendLayout();
            // 
            // key_4
            // 
            this.key_4.Image = global::WindowsFormsApp2.Properties.Resources._4_Key;
            this.key_4.Location = new System.Drawing.Point(574, 431);
            this.key_4.Name = "key_4";
            this.key_4.Size = new System.Drawing.Size(62, 62);
            this.key_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key_4.TabIndex = 1;
            this.key_4.TabStop = false;
            this.key_4.Click += new System.EventHandler(this.Key4_Click);
            // 
            // room_practice_4
            // 
            this.room_practice_4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.room_practice_4.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.practice_room_2;
            this.room_practice_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room_practice_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_practice_4.Location = new System.Drawing.Point(0, 0);
            this.room_practice_4.Name = "room_practice_4";
            this.room_practice_4.Size = new System.Drawing.Size(1200, 800);
            this.room_practice_4.TabIndex = 0;
            this.room_practice_4.TabStop = false;
            // 
            // Room_practice4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.key_4);
            this.Controls.Add(this.room_practice_4);
            this.Name = "Room_practice4";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.key_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_practice_4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox room_practice_4;
        private System.Windows.Forms.PictureBox key_4;
    }
}
