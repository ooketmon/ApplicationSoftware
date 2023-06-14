namespace WindowsFormsApp2.UDC
{
    partial class Pc_lock
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
            this.img_lock = new System.Windows.Forms.PictureBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_lock)).BeginInit();
            this.SuspendLayout();
            // 
            // img_lock
            // 
            this.img_lock.Location = new System.Drawing.Point(0, 0);
            this.img_lock.Name = "img_lock";
            this.img_lock.Size = new System.Drawing.Size(849, 570);
            this.img_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_lock.TabIndex = 0;
            this.img_lock.TabStop = false;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(233, 305);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(340, 35);
            this.txt_password.TabIndex = 1;
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_enter.Location = new System.Drawing.Point(574, 304);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(43, 36);
            this.btn_enter.TabIndex = 2;
            this.btn_enter.Text = "▶";
            this.btn_enter.UseVisualStyleBackColor = false;
            // 
            // btn_x
            // 
            this.btn_x.BackColor = System.Drawing.Color.IndianRed;
            this.btn_x.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_x.Location = new System.Drawing.Point(810, 3);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(36, 32);
            this.btn_x.TabIndex = 3;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = false;
            this.btn_x.UseWaitCursor = true;
            // 
            // Pc_lock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_x);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.img_lock);
            this.Name = "Pc_lock";
            this.Size = new System.Drawing.Size(849, 573);
            ((System.ComponentModel.ISupportInitialize)(this.img_lock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_lock;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_x;
    }
}
