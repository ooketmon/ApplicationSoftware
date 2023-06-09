﻿namespace WindowsFormsApp2.UDC
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
            this.board_2f = new System.Windows.Forms.PictureBox();
            this.zoomPoster = new System.Windows.Forms.PictureBox();
            this.blackBack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board_2f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // Poster_1
            // 
            this.Poster_1.BackColor = System.Drawing.Color.Transparent;
            this.Poster_1.Image = global::WindowsFormsApp2.Properties.Resources._2F_Poster1;
            this.Poster_1.Location = new System.Drawing.Point(682, 360);
            this.Poster_1.Name = "Poster_1";
            this.Poster_1.Size = new System.Drawing.Size(144, 185);
            this.Poster_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Poster_1.TabIndex = 2;
            this.Poster_1.TabStop = false;
            this.Poster_1.Click += new System.EventHandler(this.Poster_1_Click);
            // 
            // Poster_4
            // 
            this.Poster_4.BackColor = System.Drawing.Color.Transparent;
            this.Poster_4.Image = global::WindowsFormsApp2.Properties.Resources._2F_Poster4;
            this.Poster_4.Location = new System.Drawing.Point(146, 476);
            this.Poster_4.Name = "Poster_4";
            this.Poster_4.Size = new System.Drawing.Size(119, 79);
            this.Poster_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Poster_4.TabIndex = 1;
            this.Poster_4.TabStop = false;
            this.Poster_4.Click += new System.EventHandler(this.Poster_4_Click);
            // 
            // board_2f
            // 
            this.board_2f.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.board_2f.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("board_2f.BackgroundImage")));
            this.board_2f.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.board_2f.Dock = System.Windows.Forms.DockStyle.Fill;
            this.board_2f.Location = new System.Drawing.Point(0, 0);
            this.board_2f.Name = "board_2f";
            this.board_2f.Size = new System.Drawing.Size(1200, 800);
            this.board_2f.TabIndex = 0;
            this.board_2f.TabStop = false;
            this.board_2f.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // zoomPoster
            // 
            this.zoomPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomPoster.Location = new System.Drawing.Point(0, 0);
            this.zoomPoster.Name = "zoomPoster";
            this.zoomPoster.Size = new System.Drawing.Size(100, 50);
            this.zoomPoster.TabIndex = 4;
            this.zoomPoster.TabStop = false;
            // 
            // blackBack
            // 
            this.blackBack.Location = new System.Drawing.Point(-19, -19);
            this.blackBack.Name = "blackBack";
            this.blackBack.Size = new System.Drawing.Size(200, 100);
            this.blackBack.TabIndex = 5;
            // 
            // Room_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.blackBack);
            this.Controls.Add(this.zoomPoster);
            this.Controls.Add(this.Poster_1);
            this.Controls.Add(this.Poster_4);
            this.Controls.Add(this.board_2f);
            this.Name = "Room_Board";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Room_Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Poster_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board_2f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox board_2f;
        private System.Windows.Forms.PictureBox Poster_4;
        private System.Windows.Forms.PictureBox Poster_1;
        private System.Windows.Forms.PictureBox zoomPoster;
        private System.Windows.Forms.Panel blackBack;
    }
}
