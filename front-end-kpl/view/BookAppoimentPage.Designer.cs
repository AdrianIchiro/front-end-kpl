namespace front_end_kpl.view
{
    partial class BookAppoimentPage
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
            dataGridView1 = new DataGridView();
            AppoimentId = new DataGridViewTextBoxColumn();
            TimeStart = new DataGridViewTextBoxColumn();
            TimeEnd = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Completed = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            RoomName = new DataGridViewTextBoxColumn();
            Doctor = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Specialization = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AppoimentId, TimeStart, TimeEnd, Status, Completed, Capacity, RoomName, Doctor, Date, Specialization });
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(44, 450);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1452, 312);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AppoimentId
            // 
            AppoimentId.HeaderText = "AppoimentI d";
            AppoimentId.MinimumWidth = 8;
            AppoimentId.Name = "AppoimentId";
            AppoimentId.ReadOnly = true;
            AppoimentId.Width = 150;
            // 
            // TimeStart
            // 
            TimeStart.HeaderText = "Time Start";
            TimeStart.MinimumWidth = 8;
            TimeStart.Name = "TimeStart";
            TimeStart.ReadOnly = true;
            TimeStart.Width = 150;
            // 
            // TimeEnd
            // 
            TimeEnd.HeaderText = "Time End";
            TimeEnd.MinimumWidth = 8;
            TimeEnd.Name = "TimeEnd";
            TimeEnd.ReadOnly = true;
            TimeEnd.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            // 
            // Completed
            // 
            Completed.HeaderText = "Completed";
            Completed.MinimumWidth = 8;
            Completed.Name = "Completed";
            Completed.ReadOnly = true;
            Completed.Width = 150;
            // 
            // Capacity
            // 
            Capacity.HeaderText = "Capacity";
            Capacity.MinimumWidth = 8;
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            Capacity.Width = 150;
            // 
            // RoomName
            // 
            RoomName.HeaderText = "Room Name";
            RoomName.MinimumWidth = 8;
            RoomName.Name = "RoomName";
            RoomName.ReadOnly = true;
            RoomName.Width = 150;
            // 
            // Doctor
            // 
            Doctor.HeaderText = "Doctor";
            Doctor.MinimumWidth = 8;
            Doctor.Name = "Doctor";
            Doctor.ReadOnly = true;
            Doctor.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 150;
            // 
            // Specialization
            // 
            Specialization.HeaderText = "Specializtion";
            Specialization.Name = "Specialization";
            Specialization.ReadOnly = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(573, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(283, 32);
            label2.TabIndex = 1;
            label2.Text = "Appoiment Management";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1544, 99);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 2;
            label1.Text = "Detail Appoiment";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 203);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 7;
            label3.Text = "Time Start:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 246);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 8;
            label4.Text = "Time End:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 285);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 9;
            label5.Text = "Date:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 322);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 25);
            label6.TabIndex = 10;
            label6.Text = "Doctor:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 358);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 11;
            label7.Text = "Specialization:";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(44, 396);
            button1.Name = "button1";
            button1.Size = new Size(122, 49);
            button1.TabIndex = 12;
            button1.Text = "Book Appoiment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(189, 396);
            button2.Name = "button2";
            button2.Size = new Size(108, 49);
            button2.TabIndex = 13;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BookAppoimentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1544, 813);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "BookAppoimentPage";
            Text = "Form1";
            Load += BookAppoiment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn AppoimentId;
        private DataGridViewTextBoxColumn TimeStart;
        private DataGridViewTextBoxColumn TimeEnd;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Completed;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn RoomName;
        private DataGridViewTextBoxColumn Doctor;
        private DataGridViewTextBoxColumn Date;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Specialization;
        private Button button1;
        private Button button2;
    }
}