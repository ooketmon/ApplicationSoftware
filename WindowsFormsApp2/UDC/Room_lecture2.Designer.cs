namespace WindowsFormsApp2.UDC
{
    partial class Room_lecture2
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
            this.Papper_3 = new System.Windows.Forms.PictureBox();
            this.PC_2 = new System.Windows.Forms.PictureBox();
            this.lecture2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Papper_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecture2)).BeginInit();
            this.SuspendLayout();
            // 
            // Papper_3
            // 
            this.Papper_3.Image = global::WindowsFormsApp2.Properties.Resources._3_Papper;
            this.Papper_3.Location = new System.Drawing.Point(1129, 295);
            this.Papper_3.Name = "Papper_3";
            this.Papper_3.Size = new System.Drawing.Size(34, 35);
            this.Papper_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Papper_3.TabIndex = 2;
            this.Papper_3.TabStop = false;
            this.Papper_3.Click += new System.EventHandler(this.Papper3_Click);
            // 
            // PC_2
            // 
            this.PC_2.BackColor = System.Drawing.Color.Transparent;
            this.PC_2.Image = global::WindowsFormsApp2.Properties.Resources._2F_PC2;
            this.PC_2.Location = new System.Drawing.Point(9, 379);
            this.PC_2.Name = "PC_2";
            this.PC_2.Size = new System.Drawing.Size(147, 196);
            this.PC_2.TabIndex = 1;
            this.PC_2.TabStop = false;
            // 
            // lecture2
            // 
            this.lecture2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lecture2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.lecture_room_3;
            this.lecture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lecture2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecture2.Location = new System.Drawing.Point(0, 0);
            this.lecture2.Name = "lecture2";
            this.lecture2.Size = new System.Drawing.Size(1200, 800);
            this.lecture2.TabIndex = 0;
            this.lecture2.TabStop = false;
            // 
            // Room_lecture2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Papper_3);
            this.Controls.Add(this.PC_2);
            this.Controls.Add(this.lecture2);
            this.Name = "Room_lecture2";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Room_lecture2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Papper_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecture2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lecture2;
        private System.Windows.Forms.PictureBox PC_2;
        private System.Windows.Forms.PictureBox Papper_3;
    }
}
