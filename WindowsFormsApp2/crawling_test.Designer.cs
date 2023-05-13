namespace WindowsFormsApp2
{
    partial class crawling_test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.web_view = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.web_view)).BeginInit();
            this.SuspendLayout();
            // 
            // web_view
            // 
            this.web_view.AllowExternalDrop = true;
            this.web_view.CreationProperties = null;
            this.web_view.DefaultBackgroundColor = System.Drawing.Color.White;
            this.web_view.Location = new System.Drawing.Point(65, 22);
            this.web_view.Name = "web_view";
            this.web_view.Size = new System.Drawing.Size(661, 312);
            this.web_view.TabIndex = 0;
            this.web_view.ZoomFactor = 1D;
            this.web_view.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.web_view_NavigationCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 351);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(661, 167);
            this.textBox1.TabIndex = 1;
            // 
            // crawling_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.web_view);
            this.Name = "crawling_test";
            this.Text = "crawling_test";
            this.LocationChanged += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.web_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 web_view;
        private System.Windows.Forms.TextBox textBox1;
    }
}