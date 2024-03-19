namespace hmm
{
    partial class fgpass
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
            btnsu = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnsu
            // 
            btnsu.Location = new Point(141, 325);
            btnsu.Name = "btnsu";
            btnsu.Size = new Size(94, 29);
            btnsu.TabIndex = 19;
            btnsu.Text = "Submit";
            btnsu.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(227, 27);
            textBox4.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 233);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 15;
            label3.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_03_18_204305;
            pictureBox1.Location = new Point(118, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 290);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 20;
            label1.Text = "Check";
            // 
            // fgpass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(396, 450);
            Controls.Add(label1);
            Controls.Add(btnsu);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "fgpass";
            Text = "fgpass";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsu;
        private TextBox textBox4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
    }
}