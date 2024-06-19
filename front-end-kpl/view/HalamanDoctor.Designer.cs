namespace front_end_kpl.view
{
    partial class HalamanDoctor
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
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(287, 206);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 0;
            button1.Text = "My Appoiment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F);
            label1.Location = new Point(233, 17);
            label1.Name = "label1";
            label1.Size = new Size(308, 65);
            label1.TabIndex = 0;
            label1.Text = "Doctor Menu";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(287, 357);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 1;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(296, 163);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 2;
            label2.Text = "My Appoiments";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 99);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(567, 206);
            button3.Name = "button3";
            button3.Size = new Size(169, 52);
            button3.TabIndex = 4;
            button3.Text = "Add MedicalCheckup";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(551, 163);
            label3.Name = "label3";
            label3.Size = new Size(210, 30);
            label3.TabIndex = 5;
            label3.Text = "Add MedicalCheckup";
            // 
            // HalamanDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "HalamanDoctor";
            Text = "HalamanDoctor";
            Load += HalamanDoctor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Panel panel1;
        private Button button3;
        private Label label3;
    }
}