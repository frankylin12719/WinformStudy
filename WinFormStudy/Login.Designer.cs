namespace WinFormStudy
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 18F);
            label1.ForeColor = Color.IndianRed;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(158, 62);
            label1.Name = "label1";
            label1.Size = new Size(116, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F);
            label2.Location = new Point(76, 157);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 1;
            label2.Text = "账号";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 216);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(205, 30);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10F);
            label3.Location = new Point(76, 216);
            label3.Name = "label3";
            label3.Size = new Size(52, 27);
            label3.TabIndex = 4;
            label3.Text = "密码";
            // 
            // button1
            // 
            button1.Location = new Point(158, 295);
            button1.Name = "button1";
            button1.Size = new Size(205, 34);
            button1.TabIndex = 6;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 411);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
    }
}