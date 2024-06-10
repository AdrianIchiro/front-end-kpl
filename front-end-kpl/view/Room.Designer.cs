namespace front_end_kpl.view
{
    partial class RoomGUI
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
            SpinnerId = new NumericUpDown();
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
            LableRoom = new Label();
            btn_back = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpinnerId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpinnerNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpinnerFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TableRoom).BeginInit();
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
            panel1.Location = new Point(-1, 64);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 406);
            panel1.TabIndex = 0;
            // 
            // SpinnerId
            // 
            SpinnerId.Location = new Point(64, 29);
            SpinnerId.Margin = new Padding(3, 2, 3, 2);
            SpinnerId.Name = "SpinnerId";
            SpinnerId.Size = new Size(172, 23);
            SpinnerId.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 12);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 10;
            label4.Text = "ID";
            // 
            // button3
            // 
            button3.Location = new Point(388, 148);
            button3.Name = "button3";
            button3.Size = new Size(127, 23);
            button3.TabIndex = 9;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(388, 95);
            button2.Name = "button2";
            button2.Size = new Size(127, 23);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(388, 49);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SpinnerNumber
            // 
            SpinnerNumber.Location = new Point(64, 185);
            SpinnerNumber.Name = "SpinnerNumber";
            SpinnerNumber.Size = new Size(173, 23);
            SpinnerNumber.TabIndex = 6;
            // 
            // SpinnerFloor
            // 
            SpinnerFloor.Location = new Point(64, 132);
            SpinnerFloor.Name = "SpinnerFloor";
            SpinnerFloor.Size = new Size(173, 23);
            SpinnerFloor.TabIndex = 5;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(64, 78);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(173, 23);
            TextBoxName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 167);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Number";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 114);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Floor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 60);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // TableRoom
            // 
            TableRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableRoom.Location = new Point(64, 226);
            TableRoom.Margin = new Padding(3, 2, 3, 2);
            TableRoom.Name = "TableRoom";
            TableRoom.RowHeadersWidth = 51;
            TableRoom.RowTemplate.Height = 29;
            TableRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableRoom.Size = new Size(452, 170);
            TableRoom.TabIndex = 0;
            TableRoom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LableRoom
            // 
            LableRoom.AutoSize = true;
            LableRoom.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LableRoom.ForeColor = SystemColors.HighlightText;
            LableRoom.Location = new Point(143, 7);
            LableRoom.Name = "LableRoom";
            LableRoom.Size = new Size(271, 37);
            LableRoom.TabIndex = 1;
            LableRoom.Text = "Room Management";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 14);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(49, 34);
            btn_back.TabIndex = 21;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // RoomGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(590, 469);
            Controls.Add(btn_back);
            Controls.Add(LableRoom);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RoomGUI";
            Text = "Room";
            Load += Room_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpinnerId).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpinnerNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpinnerFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)TableRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LableRoom;
        private DataGridView TableRoom;
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
        private Button btn_back;
    }
}