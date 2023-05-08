namespace Eungsosil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            web_view = new Microsoft.Web.WebView2.WinForms.WebView2();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)web_view).BeginInit();
            SuspendLayout();
            // 
            // web_view
            // 
            web_view.AllowExternalDrop = true;
            web_view.CreationProperties = null;
            web_view.DefaultBackgroundColor = Color.White;
            web_view.Location = new Point(73, 12);
            web_view.Name = "web_view";
            web_view.Size = new Size(650, 355);
            web_view.TabIndex = 0;
            web_view.ZoomFactor = 1D;
            web_view.NavigationCompleted += web_view_NavigationCompleted;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 373);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(685, 148);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(web_view);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)web_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 web_view;
        private TextBox textBox1;
    }
}