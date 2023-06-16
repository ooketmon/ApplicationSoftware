namespace WindowsFormsApp2.UDC
{
    partial class Room_StartupClub3
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
            this.cardkey_3 = new System.Windows.Forms.PictureBox();
            this.room_sofa = new System.Windows.Forms.PictureBox();
            this.npc_sleep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardkey_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_sofa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc_sleep)).BeginInit();
            this.SuspendLayout();
            // 
            // cardkey_3
            // 
            this.cardkey_3.Image = global::WindowsFormsApp2.Properties.Resources._3_Cardkey;
            this.cardkey_3.Location = new System.Drawing.Point(1086, 497);
            this.cardkey_3.Name = "cardkey_3";
            this.cardkey_3.Size = new System.Drawing.Size(66, 56);
            this.cardkey_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardkey_3.TabIndex = 1;
            this.cardkey_3.TabStop = false;
            this.cardkey_3.Click += new System.EventHandler(this.Cardkey3_Click);
            // 
            // room_sofa
            // 
            this.room_sofa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.room_sofa.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._3F_meeting_room_2_1;
            this.room_sofa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room_sofa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_sofa.Location = new System.Drawing.Point(0, 0);
            this.room_sofa.Name = "room_sofa";
            this.room_sofa.Size = new System.Drawing.Size(1200, 800);
            this.room_sofa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.room_sofa.TabIndex = 0;
            this.room_sofa.TabStop = false;
            // 
            // npc_sleep
            // 
            this.npc_sleep.BackColor = System.Drawing.Color.Transparent;
            this.npc_sleep.Location = new System.Drawing.Point(416, 354);
            this.npc_sleep.Name = "npc_sleep";
            this.npc_sleep.Size = new System.Drawing.Size(281, 74);
            this.npc_sleep.TabIndex = 2;
            this.npc_sleep.TabStop = false;
            this.npc_sleep.Click += new System.EventHandler(this.Npc_Click);
            // 
            // Room_StartupClub3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.npc_sleep);
            this.Controls.Add(this.cardkey_3);
            this.Controls.Add(this.room_sofa);
            this.Name = "Room_StartupClub3";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Room_StartupClub3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardkey_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_sofa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc_sleep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox room_sofa;
        private System.Windows.Forms.PictureBox cardkey_3;
        private System.Windows.Forms.PictureBox npc_sleep;
    }
}
