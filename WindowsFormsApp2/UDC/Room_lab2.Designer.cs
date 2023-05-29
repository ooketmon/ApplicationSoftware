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
            this.lab2 = new System.Windows.Forms.PictureBox();
            this.labPC_2 = new System.Windows.Forms.PictureBox();
            this.Printer_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labPC_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Printer_2)).BeginInit();
            this.SuspendLayout();
            // 
            // lab2
            // 
            this.lab2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab2.Location = new System.Drawing.Point(0, 0);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(1200, 800);
            this.lab2.TabIndex = 0;
            this.lab2.TabStop = false;
            // 
            // labPC_2
            // 
            this.labPC_2.Location = new System.Drawing.Point(299, 246);
            this.labPC_2.Name = "labPC_2";
            this.labPC_2.Size = new System.Drawing.Size(178, 89);
            this.labPC_2.TabIndex = 1;
            this.labPC_2.TabStop = false;
            // 
            // Printer_2
            // 
            this.Printer_2.BackColor = System.Drawing.Color.Transparent;
            this.Printer_2.Image = global::WindowsFormsApp2.Properties.Resources._8F_Printer1;
            this.Printer_2.Location = new System.Drawing.Point(696, 152);
            this.Printer_2.Name = "Printer_2";
            this.Printer_2.Size = new System.Drawing.Size(329, 385);
            this.Printer_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Printer_2.TabIndex = 2;
            this.Printer_2.TabStop = false;
            // 
            // Room_lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Printer_2);
            this.Controls.Add(this.labPC_2);
            this.Controls.Add(this.lab2);
            this.Name = "Room_lab2";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.lab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labPC_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Printer_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lab2;
        private System.Windows.Forms.PictureBox labPC_2;
        private System.Windows.Forms.PictureBox Printer_2;
    }
}
