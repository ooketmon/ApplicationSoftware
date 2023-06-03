namespace WindowsFormsApp2.UDC
{
    partial class Room_lab1
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
            this.Printer_1 = new System.Windows.Forms.PictureBox();
            this.lab1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Printer_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab1)).BeginInit();
            this.SuspendLayout();
            // 
            // Printer_1
            // 
            this.Printer_1.Image = global::WindowsFormsApp2.Properties.Resources._8F_Printer1;
            this.Printer_1.Location = new System.Drawing.Point(414, 317);
            this.Printer_1.Name = "Printer_1";
            this.Printer_1.Size = new System.Drawing.Size(357, 341);
            this.Printer_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Printer_1.TabIndex = 1;
            this.Printer_1.TabStop = false;
            this.Printer_1.Click += new System.EventHandler(this.Printer1_Click);
            // 
            // lab1
            // 
            this.lab1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.lab_1;
            this.lab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab1.Location = new System.Drawing.Point(0, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(1200, 800);
            this.lab1.TabIndex = 0;
            this.lab1.TabStop = false;
            // 
            // Room_lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Printer_1);
            this.Controls.Add(this.lab1);
            this.Name = "Room_lab1";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.Printer_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lab1;
        private System.Windows.Forms.PictureBox Printer_1;
    }
}
