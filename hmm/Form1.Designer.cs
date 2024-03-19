namespace hmm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtus = new TextBox();
            txtpass = new TextBox();
            dky = new LinkLabel();
            fgpass = new LinkLabel();
            btnlog = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.individual_icon_4;
            pictureBox1.Location = new Point(120, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 206);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 251);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtus
            // 
            txtus.Location = new Point(138, 202);
            txtus.Name = "txtus";
            txtus.Size = new Size(246, 27);
            txtus.TabIndex = 3;
            txtus.TextChanged += txtus_TextChanged;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(138, 247);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(246, 27);
            txtpass.TabIndex = 4;
            // 
            // dky
            // 
            dky.AutoSize = true;
            dky.Location = new Point(95, 316);
            dky.Name = "dky";
            dky.Size = new Size(59, 20);
            dky.TabIndex = 5;
            dky.TabStop = true;
            dky.Text = "Sign up";
            dky.LinkClicked += dky_LinkClicked;
            // 
            // fgpass
            // 
            fgpass.AutoSize = true;
            fgpass.Location = new Point(222, 316);
            fgpass.Name = "fgpass";
            fgpass.Size = new Size(120, 20);
            fgpass.TabIndex = 6;
            fgpass.TabStop = true;
            fgpass.Text = "Forgot password";
            fgpass.LinkClicked += fgpass_LinkClicked;
            // 
            // btnlog
            // 
            btnlog.Location = new Point(138, 361);
            btnlog.Name = "btnlog";
            btnlog.Size = new Size(94, 29);
            btnlog.TabIndex = 7;
            btnlog.Text = "Sign in";
            btnlog.UseVisualStyleBackColor = true;
            btnlog.Click += btnlog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(396, 450);
            Controls.Add(btnlog);
            Controls.Add(fgpass);
            Controls.Add(dky);
            Controls.Add(txtpass);
            Controls.Add(txtus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtus;
        private TextBox txtpass;
        private LinkLabel dky;
        private LinkLabel fgpass;
        private Button btnlog;
    }
}