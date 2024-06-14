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
            ButtonTranslate = new Button();
            btn_back = new Button();
            SpinnerId = new NumericUpDown();
            label4 = new Label();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            ButtonAdd = new Button();
            SpinnerNumber = new NumericUpDown();
            SpinnerFloor = new NumericUpDown();
            TextBoxName = new TextBox();
            LableNumber = new Label();
            LableFloor = new Label();
            LableName = new Label();
            TableRoom = new DataGridView();
            ColumnRoomId = new DataGridViewTextBoxColumn();
            ColumnRoomName = new DataGridViewTextBoxColumn();
            ColumnRoomFloor = new DataGridViewTextBoxColumn();
            ColumnRoomNumber = new DataGridViewTextBoxColumn();
            LableRoom = new Label();
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
            panel1.Controls.Add(ButtonTranslate);
            panel1.Controls.Add(btn_back);
            panel1.Controls.Add(SpinnerId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ButtonUpdate);
            panel1.Controls.Add(ButtonDelete);
            panel1.Controls.Add(ButtonAdd);
            panel1.Controls.Add(SpinnerNumber);
            panel1.Controls.Add(SpinnerFloor);
            panel1.Controls.Add(TextBoxName);
            panel1.Controls.Add(LableNumber);
            panel1.Controls.Add(LableFloor);
            panel1.Controls.Add(LableName);
            panel1.Controls.Add(TableRoom);
            panel1.Location = new Point(-1, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 541);
            panel1.TabIndex = 0;
            // 
            // ButtonTranslate
            // 
            ButtonTranslate.Location = new Point(456, 19);
            ButtonTranslate.Name = "ButtonTranslate";
            ButtonTranslate.Size = new Size(94, 29);
            ButtonTranslate.TabIndex = 22;
            ButtonTranslate.Text = "English";
            ButtonTranslate.UseVisualStyleBackColor = true;
            ButtonTranslate.Click += ButtonTranslate_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(443, 247);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(145, 27);
            btn_back.TabIndex = 21;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // SpinnerId
            // 
            SpinnerId.Location = new Point(73, 39);
            SpinnerId.Name = "SpinnerId";
            SpinnerId.Size = new Size(197, 27);
            SpinnerId.TabIndex = 11;
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
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(443, 186);
            ButtonUpdate.Margin = new Padding(3, 4, 3, 4);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(145, 31);
            ButtonUpdate.TabIndex = 9;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += button3_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(443, 127);
            ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(145, 31);
            ButtonDelete.TabIndex = 8;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += button2_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(443, 65);
            ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(145, 31);
            ButtonAdd.TabIndex = 7;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += button1_Click;
            // 
            // SpinnerNumber
            // 
            SpinnerNumber.Location = new Point(73, 247);
            SpinnerNumber.Margin = new Padding(3, 4, 3, 4);
            SpinnerNumber.Name = "SpinnerNumber";
            SpinnerNumber.Size = new Size(198, 27);
            SpinnerNumber.TabIndex = 6;
            // 
            // SpinnerFloor
            // 
            SpinnerFloor.Location = new Point(73, 176);
            SpinnerFloor.Margin = new Padding(3, 4, 3, 4);
            SpinnerFloor.Name = "SpinnerFloor";
            SpinnerFloor.Size = new Size(198, 27);
            SpinnerFloor.TabIndex = 5;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(73, 104);
            TextBoxName.Margin = new Padding(3, 4, 3, 4);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(197, 27);
            TextBoxName.TabIndex = 4;
            // 
            // LableNumber
            // 
            LableNumber.AutoSize = true;
            LableNumber.Location = new Point(73, 223);
            LableNumber.Name = "LableNumber";
            LableNumber.Size = new Size(63, 20);
            LableNumber.TabIndex = 3;
            LableNumber.Text = "Number";
            LableNumber.Click += label3_Click;
            // 
            // LableFloor
            // 
            LableFloor.AutoSize = true;
            LableFloor.Location = new Point(73, 152);
            LableFloor.Name = "LableFloor";
            LableFloor.Size = new Size(43, 20);
            LableFloor.TabIndex = 2;
            LableFloor.Text = "Floor";
            // 
            // LableName
            // 
            LableName.AutoSize = true;
            LableName.Location = new Point(73, 80);
            LableName.Name = "LableName";
            LableName.Size = new Size(49, 20);
            LableName.TabIndex = 1;
            LableName.Text = "Name";
            // 
            // TableRoom
            // 
            TableRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableRoom.Columns.AddRange(new DataGridViewColumn[] { ColumnRoomId, ColumnRoomName, ColumnRoomFloor, ColumnRoomNumber });
            TableRoom.Location = new Point(73, 301);
            TableRoom.Name = "TableRoom";
            TableRoom.RowHeadersWidth = 51;
            TableRoom.RowTemplate.Height = 29;
            TableRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableRoom.Size = new Size(517, 227);
            TableRoom.TabIndex = 0;
            TableRoom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnRoomId
            // 
            ColumnRoomId.HeaderText = "Room ID";
            ColumnRoomId.MinimumWidth = 6;
            ColumnRoomId.Name = "ColumnRoomId";
            ColumnRoomId.Width = 125;
            // 
            // ColumnRoomName
            // 
            ColumnRoomName.HeaderText = "Name";
            ColumnRoomName.MinimumWidth = 6;
            ColumnRoomName.Name = "ColumnRoomName";
            ColumnRoomName.Width = 125;
            // 
            // ColumnRoomFloor
            // 
            ColumnRoomFloor.HeaderText = "Floor";
            ColumnRoomFloor.MinimumWidth = 6;
            ColumnRoomFloor.Name = "ColumnRoomFloor";
            ColumnRoomFloor.Width = 125;
            // 
            // ColumnRoomNumber
            // 
            ColumnRoomNumber.HeaderText = "Number";
            ColumnRoomNumber.MinimumWidth = 6;
            ColumnRoomNumber.Name = "ColumnRoomNumber";
            ColumnRoomNumber.Width = 125;
            // 
            // LableRoom
            // 
            LableRoom.AutoSize = true;
            LableRoom.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LableRoom.ForeColor = SystemColors.HighlightText;
            LableRoom.Location = new Point(163, 9);
            LableRoom.Name = "LableRoom";
            LableRoom.Size = new Size(335, 46);
            LableRoom.TabIndex = 1;
            LableRoom.Text = "Room Management";
            // 
            // RoomGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(674, 625);
            Controls.Add(LableRoom);
            Controls.Add(panel1);
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
        private Label LableName;
        private Label LableNumber;
        private Label LableFloor;
        private TextBox TextBoxName;
        private NumericUpDown SpinnerNumber;
        private NumericUpDown SpinnerFloor;
        private Button ButtonUpdate;
        private Button ButtonDelete;
        private Button ButtonAdd;
        private Label label4;
        private NumericUpDown SpinnerId;
        private Button btn_back;
        private Button ButtonTranslate;
        private DataGridViewTextBoxColumn ColumnRoomId;
        private DataGridViewTextBoxColumn ColumnRoomName;
        private DataGridViewTextBoxColumn ColumnRoomFloor;
        private DataGridViewTextBoxColumn ColumnRoomNumber;
    }
}