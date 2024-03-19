namespace hmm
{
    partial class signup
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtusns = new TextBox();
            txtpasss = new TextBox();
            label2 = new Label();
            txtpasscheck = new TextBox();
            label3 = new Label();
            txtemail = new TextBox();
            label4 = new Label();
            btnsu = new Button();
            check = new Label();
            chck = new Label();
            form1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_03_18_204305;
            pictureBox1.Location = new Point(120, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 212);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txtusns
            // 
            txtusns.Location = new Point(161, 212);
            txtusns.Name = "txtusns";
            txtusns.Size = new Size(227, 27);
            txtusns.TabIndex = 2;
            // 
            // txtpasss
            // 
            txtpasss.Location = new Point(161, 253);
            txtpasss.Name = "txtpasss";
            txtpasss.Size = new Size(227, 27);
            txtpasss.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 257);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtpasscheck
            // 
            txtpasscheck.Location = new Point(161, 293);
            txtpasscheck.Name = "txtpasscheck";
            txtpasscheck.Size = new Size(227, 27);
            txtpasscheck.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 347);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(161, 347);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(227, 27);
            txtemail.TabIndex = 8;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 297);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 7;
            label4.Text = "Password confirm";
            // 
            // btnsu
            // 
            btnsu.Location = new Point(82, 393);
            btnsu.Name = "btnsu";
            btnsu.Size = new Size(94, 29);
            btnsu.TabIndex = 9;
            btnsu.Text = "Sign up";
            btnsu.UseVisualStyleBackColor = true;
            btnsu.Click += btnsu_Click;
            // 
            // check
            // 
            check.AutoSize = true;
            check.Location = new Point(161, 315);
            check.Name = "check";
            check.Size = new Size(0, 20);
            check.TabIndex = 11;
            // 
            // chck
            // 
            chck.AutoSize = true;
            chck.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chck.ForeColor = Color.Red;
            chck.Location = new Point(161, 324);
            chck.Name = "chck";
            chck.Size = new Size(0, 23);
            chck.TabIndex = 12;
            // 
            // form1
            // 
            form1.Location = new Point(247, 393);
            form1.Name = "form1";
            form1.Size = new Size(94, 29);
            form1.TabIndex = 13;
            form1.Text = "form1";
            form1.UseVisualStyleBackColor = true;
            form1.Click += form1_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(435, 450);
            Controls.Add(form1);
            Controls.Add(chck);
            Controls.Add(check);
            Controls.Add(btnsu);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(txtpasscheck);
            Controls.Add(label3);
            Controls.Add(txtpasss);
            Controls.Add(label2);
            Controls.Add(txtusns);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "signup";
            Text = "signup";
            Load += signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtusns;
        private TextBox txtpasss;
        private Label label2;
        private TextBox txtpasscheck;
        private Label label3;
        private TextBox txtemail;
        private Label label4;
        private Button btnsu;
        private Label check;
        private Label chck;
        private Button form1;
    }
}