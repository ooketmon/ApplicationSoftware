﻿namespace WindowsFormsApp2.UDC
{
    partial class Room_lab4
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
            this.lock_case = new System.Windows.Forms.PictureBox();
            this.clock_roma = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.doorLockUDC1 = new WindowsFormsApp2.UDC.DoorLockUDC();
            ((System.ComponentModel.ISupportInitialize)(this.lock_case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clock_roma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lock_case
            // 
            this.lock_case.Image = global::WindowsFormsApp2.Properties.Resources._8F_locecase4;
            this.lock_case.Location = new System.Drawing.Point(100, 284);
            this.lock_case.Name = "lock_case";
            this.lock_case.Size = new System.Drawing.Size(60, 139);
            this.lock_case.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lock_case.TabIndex = 3;
            this.lock_case.TabStop = false;
            this.lock_case.Click += new System.EventHandler(this.lock_case_Click);
            // 
            // clock_roma
            // 
            this.clock_roma.Location = new System.Drawing.Point(583, 82);
            this.clock_roma.Name = "clock_roma";
            this.clock_roma.Size = new System.Drawing.Size(137, 138);
            this.clock_roma.TabIndex = 1;
            this.clock_roma.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.lab_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-19, -19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // doorLockUDC1
            // 
            this.doorLockUDC1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.doorLockUDC1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doorLockUDC1.Location = new System.Drawing.Point(881, 633);
            this.doorLockUDC1.Name = "doorLockUDC1";
            this.doorLockUDC1.Size = new System.Drawing.Size(1200, 800);
            this.doorLockUDC1.TabIndex = 5;
            this.doorLockUDC1.Visible = false;
            // 
            // Room_lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doorLockUDC1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lock_case);
            this.Controls.Add(this.clock_roma);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Room_lab4";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.lock_case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clock_roma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox clock_roma;
        private System.Windows.Forms.PictureBox lock_case;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DoorLockUDC doorLockUDC1;
    }
}
