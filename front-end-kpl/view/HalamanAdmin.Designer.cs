namespace front_end_kpl.view
{
    partial class HalamanAdmin
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1345, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(488, 17);
            label1.Name = "label1";
            label1.Size = new Size(302, 65);
            label1.TabIndex = 0;
            label1.Text = "Admin Menu";
            // 
            // button1
            // 
            button1.Location = new Point(12, 194);
            button1.Name = "button1";
            button1.Size = new Size(97, 38);
            button1.TabIndex = 1;
            button1.Text = "Add Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 251);
            button2.Name = "button2";
            button2.Size = new Size(97, 38);
            button2.TabIndex = 2;
            button2.Text = "Edit Admin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 311);
            button3.Name = "button3";
            button3.Size = new Size(97, 38);
            button3.TabIndex = 3;
            button3.Text = "Delete Admin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(146, 194);
            button4.Name = "button4";
            button4.Size = new Size(97, 38);
            button4.TabIndex = 4;
            button4.Text = "Add Doctor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(146, 251);
            button5.Name = "button5";
            button5.Size = new Size(97, 38);
            button5.TabIndex = 5;
            button5.Text = "Edit Doctor";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(146, 311);
            button6.Name = "button6";
            button6.Size = new Size(97, 38);
            button6.TabIndex = 6;
            button6.Text = "Delete Doctor";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(271, 194);
            button7.Name = "button7";
            button7.Size = new Size(97, 38);
            button7.TabIndex = 7;
            button7.Text = "Add Patient";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(271, 251);
            button8.Name = "button8";
            button8.Size = new Size(97, 38);
            button8.TabIndex = 8;
            button8.Text = "Edit Patient";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(271, 311);
            button9.Name = "button9";
            button9.Size = new Size(97, 38);
            button9.TabIndex = 9;
            button9.Text = "Delete Patient";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // HalamanAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 648);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "HalamanAdmin";
            Text = "HalamanAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}