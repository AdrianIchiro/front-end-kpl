namespace front_end_kpl.view
{
    partial class MedicalCheckupForm
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
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            AppoimentId = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Patient = new DataGridViewTextBoxColumn();
            PatientId = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 79);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 168);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Result";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(527, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 260);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Note";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(527, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(226, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(590, 334);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AppoimentId, Time, Patient, PatientId });
            dataGridView1.Location = new Point(172, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(330, 191);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AppoimentId
            // 
            AppoimentId.HeaderText = "Appoiment Id";
            AppoimentId.Name = "AppoimentId";
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.Name = "Time";
            // 
            // Patient
            // 
            Patient.HeaderText = "PatientName";
            Patient.Name = "Patient";
            // 
            // PatientId
            // 
            PatientId.HeaderText = "Patiend Id";
            PatientId.Name = "PatientId";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(527, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 458);
            panel1.TabIndex = 10;
            // 
            // MedicalCheckupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Name = "MedicalCheckupForm";
            Text = "MedicalCheckupForm";
            Load += MedicalCheckupForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn AppoimentId;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Patient;
        private DataGridViewTextBoxColumn PatientId;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
    }
}