namespace WindowsFormsApp2.UDC
{
    partial class Room_department
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
            this.papper_4 = new System.Windows.Forms.PictureBox();
            this.room_office = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.papper_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_office)).BeginInit();
            this.SuspendLayout();
            // 
            // papper_4
            // 
            this.papper_4.Image = global::WindowsFormsApp2.Properties.Resources._4_Papper;
            this.papper_4.Location = new System.Drawing.Point(869, 681);
            this.papper_4.Name = "papper_4";
            this.papper_4.Size = new System.Drawing.Size(42, 42);
            this.papper_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.papper_4.TabIndex = 1;
            this.papper_4.TabStop = false;
            this.papper_4.Click += new System.EventHandler(this.Key4_Click);
            // 
            // room_office
            // 
            this.room_office.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.room_office.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.department_office;
            this.room_office.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room_office.Location = new System.Drawing.Point(0, 0);
            this.room_office.Name = "room_office";
            this.room_office.Size = new System.Drawing.Size(1200, 800);
            this.room_office.TabIndex = 0;
            this.room_office.TabStop = false;
            // 
            // Room_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.papper_4);
            this.Controls.Add(this.room_office);
            this.Name = "Room_department";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Room_department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.papper_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_office)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox room_office;
        private System.Windows.Forms.PictureBox papper_4;
    }
}
