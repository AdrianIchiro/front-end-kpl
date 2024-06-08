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
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AppoimentId, TimeStart, TimeEnd, Status, Completed, Capacity, RoomName, Doctor, Date });
            dataGridView1.Location = new Point(607, 269);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(642, 464);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            // AppoimentManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 746);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AppoimentManagement";
            Text = "AppoimentManagement";
            Load += AppoimentManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
    }
}