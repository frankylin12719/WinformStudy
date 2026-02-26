namespace WinFormStudy
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
            buttonStudy = new Button();
            SuspendLayout();
            // 
            // buttonStudy
            // 
            buttonStudy.Location = new Point(266, 161);
            buttonStudy.Name = "buttonStudy";
            buttonStudy.Size = new Size(202, 93);
            buttonStudy.TabIndex = 0;
            buttonStudy.Text = "button1";
            buttonStudy.UseVisualStyleBackColor = true;
            buttonStudy.Click += button1_Click;
            buttonStudy.MouseEnter += buttonStudy_MouseEnter;
            buttonStudy.MouseLeave += buttonStudy_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStudy);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStudy;
    }
}
