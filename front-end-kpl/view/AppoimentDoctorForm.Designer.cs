namespace front_end_kpl.view
{
    partial class AppoimentDoctorForm
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
            appoimentId = new DataGridViewTextBoxColumn();
            timeStart = new DataGridViewTextBoxColumn();
            timeEnd = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            isCompleted = new DataGridViewTextBoxColumn();
            sapacity = new DataGridViewTextBoxColumn();
            room = new DataGridViewTextBoxColumn();
            doctor = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            doctorId = new DataGridViewTextBoxColumn();
            specialization = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { appoimentId, timeStart, timeEnd, status, isCompleted, sapacity, room, doctor, date, doctorId, specialization });
            dataGridView1.Location = new Point(-1, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(804, 240);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // appoimentId
            // 
            appoimentId.HeaderText = "AppoimentId";
            appoimentId.Name = "appoimentId";
            // 
            // timeStart
            // 
            timeStart.HeaderText = "TimeStart";
            timeStart.Name = "timeStart";
            // 
            // timeEnd
            // 
            timeEnd.HeaderText = "TimeEnd";
            timeEnd.Name = "timeEnd";
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // isCompleted
            // 
            isCompleted.HeaderText = "IsCompleted";
            isCompleted.Name = "isCompleted";
            // 
            // sapacity
            // 
            sapacity.HeaderText = "Capacity";
            sapacity.Name = "sapacity";
            // 
            // room
            // 
            room.HeaderText = "Room";
            room.Name = "room";
            // 
            // doctor
            // 
            doctor.HeaderText = "Doctor";
            doctor.Name = "doctor";
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            // 
            // doctorId
            // 
            doctorId.HeaderText = "DoctorId";
            doctorId.Name = "doctorId";
            // 
            // specialization
            // 
            specialization.HeaderText = "Specialization";
            specialization.Name = "specialization";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 81);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F);
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(490, 65);
            label1.TabIndex = 1;
            label1.Text = "Add Medical Checkup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Choose Appoiment";
            // 
            // button1
            // 
            button1.Location = new Point(21, 99);
            button1.Name = "button1";
            button1.Size = new Size(81, 32);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AppoimentDoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "AppoimentDoctorForm";
            Text = "AppoimentDoctor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn appoimentId;
        private DataGridViewTextBoxColumn timeStart;
        private DataGridViewTextBoxColumn timeEnd;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn isCompleted;
        private DataGridViewTextBoxColumn sapacity;
        private DataGridViewTextBoxColumn room;
        private DataGridViewTextBoxColumn doctor;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn doctorId;
        private DataGridViewTextBoxColumn specialization;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}