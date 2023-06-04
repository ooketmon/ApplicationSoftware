namespace WindowsFormsApp2.UDC
{
    partial class Room_lab2
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
            this.Printer_2 = new System.Windows.Forms.PictureBox();
            this.labPC_2 = new System.Windows.Forms.PictureBox();
            this.lab2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.computerPasswordInput1 = new WindowsFormsApp2.UDC.ComputerPasswordInput();
            ((System.ComponentModel.ISupportInitialize)(this.Printer_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labPC_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Printer_2
            // 
            this.Printer_2.BackColor = System.Drawing.Color.Transparent;
            this.Printer_2.Image = global::WindowsFormsApp2.Properties.Resources._8F_Printer1;
            this.Printer_2.Location = new System.Drawing.Point(919, 403);
            this.Printer_2.Name = "Printer_2";
            this.Printer_2.Size = new System.Drawing.Size(244, 236);
            this.Printer_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Printer_2.TabIndex = 2;
            this.Printer_2.TabStop = false;
            this.Printer_2.Click += new System.EventHandler(this.Printer2_Click);
            // 
            // labPC_2
            // 
            this.labPC_2.BackColor = System.Drawing.Color.Transparent;
            this.labPC_2.Image = global::WindowsFormsApp2.Properties.Resources._8F_lab2PC;
            this.labPC_2.Location = new System.Drawing.Point(176, 416);
            this.labPC_2.Name = "labPC_2";
            this.labPC_2.Size = new System.Drawing.Size(278, 252);
            this.labPC_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labPC_2.TabIndex = 1;
            this.labPC_2.TabStop = false;
            this.labPC_2.Click += new System.EventHandler(this.labPC2_Click);
            // 
            // lab2
            // 
            this.lab2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.lab_2;
            this.lab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab2.Location = new System.Drawing.Point(0, 0);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(1200, 800);
            this.lab2.TabIndex = 0;
            this.lab2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // computerPasswordInput1
            // 
            this.computerPasswordInput1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.computerPasswordInput1.Location = new System.Drawing.Point(862, 686);
            this.computerPasswordInput1.Name = "computerPasswordInput1";
            this.computerPasswordInput1.Size = new System.Drawing.Size(1200, 800);
            this.computerPasswordInput1.TabIndex = 5;
            this.computerPasswordInput1.Visible = false;
            // 
            // Room_lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.computerPasswordInput1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Printer_2);
            this.Controls.Add(this.labPC_2);
            this.Controls.Add(this.lab2);
            this.Name = "Room_lab2";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.Printer_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labPC_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lab2;
        private System.Windows.Forms.PictureBox labPC_2;
        private System.Windows.Forms.PictureBox Printer_2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComputerPasswordInput computerPasswordInput1;
    }
}
