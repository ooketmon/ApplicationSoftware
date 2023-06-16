namespace WindowsFormsApp2.UDC
{
    partial class Doorlock
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
            this.btn_enter = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_x = new System.Windows.Forms.Button();
            this.room_number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_enter.Location = new System.Drawing.Point(249, 399);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(43, 36);
            this.btn_enter.TabIndex = 4;
            this.btn_enter.Text = "▶";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(0, 400);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(250, 35);
            this.txt_password.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.lecuture_Door;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_x
            // 
            this.btn_x.BackColor = System.Drawing.Color.IndianRed;
            this.btn_x.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_x.Location = new System.Drawing.Point(249, 3);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(36, 32);
            this.btn_x.TabIndex = 6;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = false;
            this.btn_x.UseWaitCursor = true;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // room_number
            // 
            this.room_number.AutoSize = true;
            this.room_number.BackColor = System.Drawing.Color.Transparent;
            this.room_number.Font = new System.Drawing.Font("굴림", 20F);
            this.room_number.ForeColor = System.Drawing.Color.White;
            this.room_number.Location = new System.Drawing.Point(92, 42);
            this.room_number.Name = "room_number";
            this.room_number.Size = new System.Drawing.Size(110, 34);
            this.room_number.TabIndex = 7;
            this.room_number.Text = "label1";
            // 
            // Doorlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.room_number);
            this.Controls.Add(this.btn_x);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txt_password);
            this.Name = "Doorlock";
            this.Size = new System.Drawing.Size(292, 435);
            this.Load += new System.EventHandler(this.Doorlock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Doorlock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Label room_number;
    }
}
