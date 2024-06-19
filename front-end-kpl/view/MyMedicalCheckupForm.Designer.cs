namespace front_end_kpl.view
{
    partial class MyMedicalCheckupForm
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
            dataGridView1 = new DataGridView();
            medicalChekUpId = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            noteMedicalChekup = new DataGridViewTextBoxColumn();
            result = new DataGridViewTextBoxColumn();
            doctor = new DataGridViewTextBoxColumn();
            patient = new DataGridViewTextBoxColumn();
            appoimentId = new DataGridViewTextBoxColumn();
            patientId = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F);
            label1.Location = new Point(180, 20);
            label1.Name = "label1";
            label1.Size = new Size(456, 65);
            label1.TabIndex = 2;
            label1.Text = "My MedicalCheckup";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { medicalChekUpId, date, noteMedicalChekup, result, doctor, patient, appoimentId, patientId });
            dataGridView1.Location = new Point(90, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(636, 195);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // medicalChekUpId
            // 
            medicalChekUpId.HeaderText = "MedicalCheckUpId";
            medicalChekUpId.Name = "medicalChekUpId";
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            // 
            // noteMedicalChekup
            // 
            noteMedicalChekup.HeaderText = "NoteMedicalCheckup";
            noteMedicalChekup.Name = "noteMedicalChekup";
            // 
            // result
            // 
            result.HeaderText = "Result";
            result.Name = "result";
            // 
            // doctor
            // 
            doctor.HeaderText = "Doctor";
            doctor.Name = "doctor";
            // 
            // patient
            // 
            patient.HeaderText = "Patient";
            patient.Name = "patient";
            // 
            // appoimentId
            // 
            appoimentId.HeaderText = "AppoimentId";
            appoimentId.Name = "appoimentId";
            // 
            // patientId
            // 
            patientId.HeaderText = "PatientId";
            patientId.Name = "patientId";
            // 
            // button1
            // 
            button1.Location = new Point(29, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.Click += button1_Click;
            // 
            // MyMedicalCheckupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "MyMedicalCheckupForm";
            Text = "MyMedicalCheckup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn medicalChekUpId;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn noteMedicalChekup;
        private DataGridViewTextBoxColumn result;
        private DataGridViewTextBoxColumn doctor;
        private DataGridViewTextBoxColumn patient;
        private DataGridViewTextBoxColumn appoimentId;
        private DataGridViewTextBoxColumn patientId;
        private Button button1;
    }
}