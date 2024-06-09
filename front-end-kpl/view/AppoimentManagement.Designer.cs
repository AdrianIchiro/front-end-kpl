namespace frontEnd.view
{
    partial class AppoimentManagement
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
            Specialization = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AppoimentId, TimeStart, TimeEnd, Status, Completed, Capacity, RoomName, Doctor, Specialization, Date });
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(11, 444);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1451, 363);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            dataGridView1.Paint += dataGridView1_Paint;
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
            // Specialization
            // 
            Specialization.HeaderText = "Specialization";
            Specialization.Name = "Specialization";
            Specialization.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 150;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(530, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(283, 32);
            label2.TabIndex = 1;
            label2.Text = "Appoiment Management";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(314, 396);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(132, 44);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(162, 396);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(132, 44);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(11, 396);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(132, 44);
            button3.TabIndex = 4;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1473, 100);
            panel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(22, 207);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(22, 265);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(43, 23);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(71, 265);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(43, 23);
            comboBox3.TabIndex = 9;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(22, 323);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(43, 23);
            comboBox4.TabIndex = 10;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(71, 323);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(43, 23);
            comboBox5.TabIndex = 11;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(300, 148);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 12;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(300, 207);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 130);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 14;
            label1.Text = "Doctor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 189);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 15;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 247);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 16;
            label4.Text = "Time Start";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 305);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 17;
            label5.Text = "Time End";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 130);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 18;
            label6.Text = "Room Name";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(300, 189);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 19;
            label7.Text = "Capacity";
            // 
            // AppoimentManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 818);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "AppoimentManagement";
            Text = "AppoimentManagement";
            Load += AppoimentManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn AppoimentId;
        private DataGridViewTextBoxColumn TimeStart;
        private DataGridViewTextBoxColumn TimeEnd;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Completed;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn RoomName;
        private DataGridViewTextBoxColumn Doctor;
        private DataGridViewTextBoxColumn Specialization;
        private DataGridViewTextBoxColumn Date;
    }
}