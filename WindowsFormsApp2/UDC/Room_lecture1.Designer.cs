namespace WindowsFormsApp2
{
    partial class Room_lecture1
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
            this.Papper_1 = new System.Windows.Forms.PictureBox();
            this.lecture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Papper_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecture1)).BeginInit();
            this.SuspendLayout();
            // 
            // Papper_1
            // 
            this.Papper_1.BackColor = System.Drawing.Color.Transparent;
            this.Papper_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Papper_1.Image = global::WindowsFormsApp2.Properties.Resources._1_Papper;
            this.Papper_1.Location = new System.Drawing.Point(1146, 376);
            this.Papper_1.Name = "Papper_1";
            this.Papper_1.Size = new System.Drawing.Size(34, 30);
            this.Papper_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Papper_1.TabIndex = 1;
            this.Papper_1.TabStop = false;
            this.Papper_1.Click += new System.EventHandler(this.Papper1_Click);
            // 
            // lecture1
            // 
            this.lecture1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.lecture_room_4;
            this.lecture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lecture1.Location = new System.Drawing.Point(0, 0);
            this.lecture1.Name = "lecture1";
            this.lecture1.Size = new System.Drawing.Size(1200, 800);
            this.lecture1.TabIndex = 0;
            this.lecture1.TabStop = false;
            // 
            // Room_lecture1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Papper_1);
            this.Controls.Add(this.lecture1);
            this.Name = "Room_lecture1";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Room_lecture1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Papper_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lecture1;
        private System.Windows.Forms.PictureBox Papper_1;
    }
}
