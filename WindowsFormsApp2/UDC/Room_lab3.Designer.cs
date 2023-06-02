namespace WindowsFormsApp2.UDC
{
    partial class Room_lab3
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
            this.test_3 = new System.Windows.Forms.PictureBox();
            this.room_lab_3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.test_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_lab_3)).BeginInit();
            this.SuspendLayout();
            // 
            // test_3
            // 
            this.test_3.Location = new System.Drawing.Point(462, 175);
            this.test_3.Name = "test_3";
            this.test_3.Size = new System.Drawing.Size(100, 50);
            this.test_3.TabIndex = 1;
            this.test_3.TabStop = false;
            // 
            // room_lab_3
            // 
            this.room_lab_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.room_lab_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_lab_3.Location = new System.Drawing.Point(0, 0);
            this.room_lab_3.Name = "room_lab_3";
            this.room_lab_3.Size = new System.Drawing.Size(1200, 800);
            this.room_lab_3.TabIndex = 0;
            this.room_lab_3.TabStop = false;
            // 
            // Room_lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.test_3);
            this.Controls.Add(this.room_lab_3);
            this.Name = "Room_lab3";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.test_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_lab_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox room_lab_3;
        private System.Windows.Forms.PictureBox test_3;
    }
}
