namespace front_end_kpl.view
{
    partial class Room
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
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SpinnerNumber = new NumericUpDown();
            SpinnerFloor = new NumericUpDown();
            TextBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TableRoom = new DataGridView();
            RoomId = new DataGridViewTextBoxColumn();
            RoomName = new DataGridViewTextBoxColumn();
            RoomFloor = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            LableRoom = new Label();
            SpinnerId = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpinnerNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpinnerFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TableRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpinnerId).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(SpinnerId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SpinnerNumber);
            panel1.Controls.Add(SpinnerFloor);
            panel1.Controls.Add(TextBoxName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TableRoom);
            panel1.Location = new Point(-1, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 541);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 16);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 10;
            label4.Text = "ID";
            // 
            // button3
            // 
            button3.Location = new Point(643, 201);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(145, 31);
            button3.TabIndex = 9;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(643, 131);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(145, 31);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(643, 69);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 31);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpinnerNumber
            // 
            SpinnerNumber.Location = new Point(73, 247);
            SpinnerNumber.Margin = new Padding(3, 4, 3, 4);
            SpinnerNumber.Name = "SpinnerNumber";
            SpinnerNumber.Size = new Size(198, 27);
            SpinnerNumber.TabIndex = 6;
            SpinnerFloor.Minimum = 0;
            // 
            // SpinnerFloor
            // 
            SpinnerFloor.Location = new Point(73, 176);
            SpinnerFloor.Margin = new Padding(3, 4, 3, 4);
            SpinnerFloor.Name = "SpinnerFloor";
            SpinnerFloor.Size = new Size(198, 27);
            SpinnerFloor.TabIndex = 5;
            SpinnerFloor.Minimum = 0;
            SpinnerFloor.Maximum = 100;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(73, 104);
            TextBoxName.Margin = new Padding(3, 4, 3, 4);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(197, 27);
            TextBoxName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 223);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "Number";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 152);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Floor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 80);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // TableRoom
            // 
            TableRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableRoom.Columns.AddRange(new DataGridViewColumn[] { RoomId, RoomName, RoomFloor, RoomNumber });
            TableRoom.Location = new Point(73, 299);
            TableRoom.Name = "TableRoom";
            TableRoom.RowHeadersWidth = 51;
            TableRoom.RowTemplate.Height = 29;
            TableRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableRoom.Size = new Size(715, 227);
            TableRoom.TabIndex = 0;
            TableRoom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RoomId
            // 
            RoomId.HeaderText = "Room ID";
            RoomId.MinimumWidth = 6;
            RoomId.Name = "RoomId";
            RoomId.Width = 125;
            // 
            // RoomName
            // 
            RoomName.HeaderText = "Name";
            RoomName.MinimumWidth = 6;
            RoomName.Name = "RoomName";
            RoomName.Width = 200;
            // 
            // RoomFloor
            // 
            RoomFloor.HeaderText = "Floor";
            RoomFloor.MinimumWidth = 6;
            RoomFloor.Name = "RoomFloor";
            RoomFloor.Width = 125;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "Number";
            RoomNumber.MinimumWidth = 6;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Width = 125;
            // 
            // LableRoom
            // 
            LableRoom.AutoSize = true;
            LableRoom.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LableRoom.ForeColor = SystemColors.HighlightText;
            LableRoom.Location = new Point(279, 12);
            LableRoom.Name = "LableRoom";
            LableRoom.Size = new Size(335, 46);
            LableRoom.TabIndex = 1;
            LableRoom.Text = "Room Management";
            // 
            // SpinnerId
            // 
            SpinnerId.Location = new Point(73, 39);
            SpinnerId.Name = "SpinnerId";
            SpinnerId.Size = new Size(197, 27);
            SpinnerId.TabIndex = 11;
            SpinnerId.Minimum = 0;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(864, 625);
            Controls.Add(LableRoom);
            Controls.Add(panel1);
            Name = "Room";
            Text = "Room";
            Load += Room_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpinnerNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpinnerFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)TableRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpinnerId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LableRoom;
        private DataGridView TableRoom;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewTextBoxColumn RoomName;
        private DataGridViewTextBoxColumn RoomFloor;
        private DataGridViewTextBoxColumn RoomNumber;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox TextBoxName;
        private NumericUpDown SpinnerNumber;
        private NumericUpDown SpinnerFloor;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private NumericUpDown SpinnerId;
    }
}