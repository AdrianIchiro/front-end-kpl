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

// using globalization buat mengatur culture
// culture (budaya) merujuk pada seperangkat aturan dan konvensi
// yang terkait dengan bahasa, format tanggal dan waktu, format angka, dan berbagai elemen lain yang
// berbeda antara satu budaya atau wilayah dengan yang lainnya.

namespace front_end_kpl.view
{
    public partial class RoomGUI : Form
    {
        private Admin admin;
        private RoomApp app;
        // Untuk mengelola resource
        private ResourceManager rm;

        string id;
        string name;
        int floor;
        int number;



        public RoomGUI(Admin admin)
        {
            InitializeComponent();
            // mendapatkan instansi dari RoomApp
            app = RoomApp.Instance;
            //Menyimpan referensi admin sekarang
            this.admin = admin;
            SetCulture("en");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // menginisialisasi resource dari resource lokal yang sesuai
        // Untuk kelas ini memakai resource Strings sebagai defaultnya
        private void SetCulture(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            rm = new ResourceManager("front_end_kpl.Language.Strings", typeof(Room).Assembly);
            UpdateText();
        }

        // Buat mengubah teks pada komponen GUI sesuai dengan bahasa sekarang
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
                ButtonTranslate.Text = rm.GetString("Language");
            }
            else
            {
                ButtonTranslate.Text = rm.GetString("Language");
            }

        }

        // Menukar bahasa
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


        // Add Button
        private async void button1_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            int floor = (int)SpinnerFloor.Value;
            int number = (int)SpinnerNumber.Value;

            if (name == "")
            {
                MessageBox.Show(rm.GetString("MNameEmpty"));
                return;
            }

            var createdRoom = await app.PostRoom(name, floor, number);
            if (createdRoom != null)
            {
                MessageBox.Show(rm.GetString("MRoomAddedSucces"));
                await LoadRooms();
            }
            ClearFields();
        }


        // Delete button
        private async void button2_Click(object sender, EventArgs e)
        {
            int id = (int)SpinnerId.Value;

            bool isComplete = await app.DeleteRoom(id);
            if (isComplete)
            {
                MessageBox.Show(rm.GetString("MRoomDeletedSucces"));
                await LoadRooms();
            }
            ClearFields();
        }


        // Update Button
        private async void button3_Click(object sender, EventArgs e)
        {
            int id = (int)SpinnerId.Value;
            string name = TextBoxName.Text;
            int floor = (int)SpinnerFloor.Value;
            int number = (int)SpinnerNumber.Value;

            if (name == "")
            {
                MessageBox.Show(rm.GetString("MNameEmpty"));
                return;
            }

            var updatedRoom = await app.UpdateRoom(id, name, floor, number);
            if (updatedRoom != null)
            {
                MessageBox.Show(rm.GetString("MRoomUpdatedSucces"));
            }
            await LoadRooms();
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Menangani event saat form dibuat
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

        // Memuat data ruangan ke tabel
        private async Task LoadRooms()
        {
            var rooms = await app.GetAllRoomsAsync();

            if (rooms != null && rooms.Any())
            {
                TableRoom.DataSource = rooms;
            }
            else
            {
                MessageBox.Show(rm.GetString("MRoomNotFound"));
                TableRoom.DataSource = null;
            }
        }

        // Membersihkan tempat input
        private void ClearFields()
        {
            TextBoxName.Text = string.Empty;
            SpinnerFloor.Value = 0;
            SpinnerNumber.Value = 0;
            SpinnerId.Value = 0;
        }

        // Kembali ke menu admin
        private void btn_back_Click(object sender, EventArgs e)
        {
            HalamanAdmin halamanAdmin = new HalamanAdmin(admin);
            halamanAdmin.Show();
            this.Close();
        }

        // Melakukan event menukar bahasa
        private void ButtonTranslate_Click(object sender, EventArgs e)
        {
            SwitchLanguage();
        }
    }
}
