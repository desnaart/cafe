namespace UAS_Cafe_Management
{
    partial class Profile_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_Admin));
            button1 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(108, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 452);
            panel1.TabIndex = 3;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(82, 255);
            button6.Name = "button6";
            button6.Size = new Size(116, 27);
            button6.TabIndex = 46;
            button6.Text = "Log out";
            button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 12);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 20;
            label1.Text = "Profile";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(82, 214);
            button5.Name = "button5";
            button5.Size = new Size(116, 27);
            button5.TabIndex = 9;
            button5.Text = "Menu";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(82, 130);
            button2.Name = "button2";
            button2.Size = new Size(116, 27);
            button2.TabIndex = 8;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(82, 174);
            button3.Name = "button3";
            button3.Size = new Size(116, 27);
            button3.TabIndex = 7;
            button3.Text = "Group";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.SaddleBrown;
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(295, 207);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(98, 47);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "Total Menu\n20";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.SaddleBrown;
            richTextBox2.ForeColor = SystemColors.Window;
            richTextBox2.Location = new Point(414, 207);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(98, 47);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "Pelanggan\n10";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.SaddleBrown;
            richTextBox3.ForeColor = SystemColors.Window;
            richTextBox3.Location = new Point(534, 207);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(98, 47);
            richTextBox3.TabIndex = 12;
            richTextBox3.Text = "Total Meja\n15";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.SaddleBrown;
            richTextBox4.ForeColor = SystemColors.Window;
            richTextBox4.Location = new Point(653, 207);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(98, 47);
            richTextBox4.TabIndex = 13;
            richTextBox4.Text = "Meja Kosong\n5";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(429, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 23);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 47;
            label2.Text = "Dashboard";
            // 
            // Profile_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile_Admin";
            Text = "Profile_Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button5;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button6;
        private Label label2;
    }
}