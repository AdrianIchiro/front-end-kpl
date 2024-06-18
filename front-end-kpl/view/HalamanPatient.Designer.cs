namespace front_end_kpl.view
{
    partial class HalamanPatient
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(297, 298);
            button1.Name = "button1";
            button1.Size = new Size(166, 57);
            button1.TabIndex = 0;
            button1.Text = "my Book Appoiment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(297, 211);
            button2.Name = "button2";
            button2.Size = new Size(166, 57);
            button2.TabIndex = 1;
            button2.Text = "Book Appoiment";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(297, 390);
            button3.Name = "button3";
            button3.Size = new Size(166, 57);
            button3.TabIndex = 2;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 100);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(244, 18);
            label1.Name = "label1";
            label1.Size = new Size(308, 65);
            label1.TabIndex = 1;
            label1.Text = "Patient Menu";
            // 
            // HalamanPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "HalamanPatient";
            Text = "HalamanPatient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label1;
    }
}