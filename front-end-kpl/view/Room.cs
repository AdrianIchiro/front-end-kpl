using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using front_end_kpl.utils;
using System.Globalization;
using System.Resources;

namespace front_end_kpl.view
{
    public partial class RoomGUI : Form
    {
        private Admin admin;
        private RoomApp app;
        private ResourceManager rm;

        string id;
        string name;
        int floor;
        int number;



        public RoomGUI(Admin admin)
        {
            InitializeComponent();
            app = new RoomApp();
            this.admin = admin;
            SetCulture("en");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SetCulture(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            rm = new ResourceManager("front_end_kpl.Language.Strings", typeof(Room).Assembly);
            UpdateText();
        }

        private void UpdateText()
        {
            LableRoom.Text = rm.GetString("TitleRoom");
            LableName.Text = rm.GetString("LableName");
            LableFloor.Text = rm.GetString("LableFloor");
            LableNumber.Text = rm.GetString("LableNumber");
            btn_back.Text = rm.GetString("Back");
            ButtonAdd.Text = rm.GetString("Add");
            ButtonDelete.Text = rm.GetString("Delete");
            ButtonUpdate.Text = rm.GetString("Update");
            if (TableRoom.Columns.Count > 0)
            {
                TableRoom.Columns["ColumnRoomId"].HeaderText = rm.GetString("ColumnRoomId");
                TableRoom.Columns["ColumnRoomName"].HeaderText = rm.GetString("ColumnRoomName");
                TableRoom.Columns["ColumnRoomFloor"].HeaderText = rm.GetString("ColumnRoomFloor");
                TableRoom.Columns["ColumnRoomNumber"].HeaderText = rm.GetString("ColumnRoomNumber");
            }

            if (Thread.CurrentThread.CurrentUICulture.Name == "en")
            {
                ButtonTranslate.Text = rm.GetString("English");
            }
            else
            {
                ButtonTranslate.Text = rm.GetString("Indonesia");
            }

        }

        private void SwitchLanguage()
        {
            if (Thread.CurrentThread.CurrentUICulture.Name == "en")
            {
                SetCulture("id");
            }
            else
            {
                SetCulture("en");
            }
            UpdateText();
        }


        //Add Button
        private async void button1_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            int floor = (int)SpinnerFloor.Value;
            int number = (int)SpinnerNumber.Value;

            var createdRoom = await app.PostRoom(name, floor, number);
            if (createdRoom != null)
            {
                MessageBox.Show("Room added successfully!");
                await LoadRooms();
            }
            ClearFields();
        }


        //Delete button
        private async void button2_Click(object sender, EventArgs e)
        {
            int id = (int)SpinnerId.Value;

            bool isComplete = await app.DeleteRoom(id);
            if (isComplete)
            {
                MessageBox.Show("Room deleted successfully!");
                await LoadRooms();
            }
            ClearFields();
        }


        //Update Button
        private async void button3_Click(object sender, EventArgs e)
        {
            int id = (int)SpinnerId.Value;
            string name = TextBoxName.Text;
            int floor = (int)SpinnerFloor.Value;
            int number = (int)SpinnerNumber.Value;

            var updatedRoom = await app.UpdateRoom(id, name, floor, number);
            if (updatedRoom != null)
            {
                MessageBox.Show("Room updated successfully!");
            }
            await LoadRooms();
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Room_Load(object sender, EventArgs e)
        {
            TableRoom.AutoGenerateColumns = false;

            TableRoom.Columns.Clear();

            TableRoom.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColumnRoomId", HeaderText = rm.GetString("ColumnRoomId"), DataPropertyName = "roomId" });
            TableRoom.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColumnRoomName", HeaderText = rm.GetString("ColumnRoomName"), DataPropertyName = "roomName" });
            TableRoom.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColumnRoomFloor", HeaderText = rm.GetString("ColumnRoomFloor"), DataPropertyName = "roomFloor" });
            TableRoom.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColumnRoomNumber", HeaderText = rm.GetString("ColumnRoomNumber"), DataPropertyName = "roomNumber" });

            await LoadRooms();
        }

        private async Task LoadRooms()
        {
            var rooms = await app.GetAllRoomsAsync();

            if (rooms != null && rooms.Any())
            {
                TableRoom.DataSource = rooms;
            }
            else
            {
                MessageBox.Show("No rooms found.");
                TableRoom.DataSource = null;
            }
        }

        private void ClearFields()
        {
            TextBoxName.Text = string.Empty;
            SpinnerFloor.Value = 0;
            SpinnerNumber.Value = 0;
            SpinnerId.Value = 0;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HalamanAdmin halamanAdmin = new HalamanAdmin(admin);
            halamanAdmin.Show();
            this.Close();
        }

        private void ButtonTranslate_Click(object sender, EventArgs e)
        {
            SwitchLanguage();
        }
    }
}
