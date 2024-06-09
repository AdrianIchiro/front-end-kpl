using System.Windows.Forms;

namespace front_end_kpl
{
    partial class Specialization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450); // Ukuran panel disesuaikan dengan ukuran Form
            this.panel1.TabIndex = 0;

            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tB_SpecializationId = new TextBox();
            tB_Name = new TextBox();
            tB_Description = new TextBox();
            btn_Tambah = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            dataGridView1 = new DataGridView();
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
            panel1.Size = new Size(801, 127);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 39);
            label1.Name = "label1";
            label1.Size = new Size(226, 45);
            label1.TabIndex = 0;
            label1.Text = "Specialization";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 211);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 1;
            label2.Text = "SpecializationId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 288);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 381);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // tB_SpecializationId
            // 
            tB_SpecializationId.Location = new Point(258, 205);
            tB_SpecializationId.Name = "tB_SpecializationId";
            tB_SpecializationId.Size = new Size(212, 31);
            tB_SpecializationId.TabIndex = 4;
            // 
            // tB_Name
            // 
            tB_Name.Location = new Point(258, 288);
            tB_Name.Name = "tB_Name";
            tB_Name.Size = new Size(210, 31);
            tB_Name.TabIndex = 5;
            // 
            // tB_Description
            // 
            tB_Description.Location = new Point(258, 366);
            tB_Description.Multiline = true;
            tB_Description.Name = "tB_Description";
            tB_Description.Size = new Size(212, 83);
            tB_Description.TabIndex = 6;
            // 
            // btn_Tambah
            // 
            btn_Tambah.Location = new Point(624, 205);
            btn_Tambah.Name = "btn_Tambah";
            btn_Tambah.Size = new Size(130, 47);
            btn_Tambah.TabIndex = 7;
            btn_Tambah.Text = "Add";
            btn_Tambah.UseVisualStyleBackColor = true;
            btn_Tambah.Click += btn_Tambah_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(624, 301);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(130, 47);
            btn_Update.TabIndex = 8;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(624, 393);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(130, 47);
            btn_Delete.TabIndex = 9;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20); // Lokasi disesuaikan agar berada dalam panel
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(760, 410); // Ukuran disesuaikan agar sesuai dengan panel
            this.dataGridView1.TabIndex = 0;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(121, 474);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(513, 269);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Specialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 755);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Tambah);
            Controls.Add(tB_Description);
            Controls.Add(tB_Name);
            Controls.Add(tB_SpecializationId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Specialization";
            Text = "Specialization";
            Load += Specialization_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tB_SpecializationId;
        private TextBox tB_Name;
        private TextBox tB_Description;
        private Button btn_Tambah;
        private Button btn_Update;
        private Button btn_Delete;
    }
}
