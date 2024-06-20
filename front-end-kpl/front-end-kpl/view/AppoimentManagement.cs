using AppointmentApp;
using front_end_kpl.utils;
using front_end_kpl.view;
using System.Drawing.Drawing2D;

namespace frontEnd.view
{
    public partial class AppoimentManagement : Form
    {
        // Array for appointment status
        string[] appoimentStatus = { "Scheduled", "Completed" };

        // Lists to store data
        List<Room> rooms;
        List<Doctor> doctors;
        List<Appointment> appointments;
        // Admin object
        Admin admin;
        // Fields
        private int rows = -1;
        private int appoimentId = -1;


        // Services
        private readonly AppointmentService appointmentService;
        private readonly PostAppointment postAppointment;
        // Constructor
        public AppoimentManagement(Admin admin)
        {


            InitializeComponent();
            // Initialize services
            AppointmentService.Initialize();
            PostAppointment.Initialize();
            appointmentService = AppointmentService.Instance;
            postAppointment = PostAppointment.Instance;
            numericUpDown1.Maximum = 10000;

            // Load initial data
            FillComboBox();
            _ = LoadRoomsAsync();
            _ = LoadDoctorssAsync();
            this.admin = admin;
            _ = LoadAppointmentsAsync();
            // Center form on startup
            this.StartPosition = FormStartPosition.CenterScreen;
            // Set up DataGridView appearance
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;



        }

        private void AppointmentManagement_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(79, 0, 227), Color.FromArgb(10, 0, 253), LinearGradientMode.ForwardDiagonal))
            {
                ColorBlend colorBlend = new ColorBlend();
                colorBlend.Positions = new[] { 0, 0.0833f, 0.1667f, 0.25f, 0.3333f, 0.4167f, 0.5f, 0.5833f, 0.6667f, 0.75f, 0.8333f, 1 };
                colorBlend.Colors = new[] { Color.FromArgb(79, 0, 227), Color.FromArgb(77, 12, 206), Color.FromArgb(75, 23, 185), Color.FromArgb(72, 28, 164), Color.FromArgb(69, 31, 144), Color.FromArgb(68, 31, 146), Color.FromArgb(66, 30, 148), Color.FromArgb(65, 30, 150), Color.FromArgb(63, 26, 175), Color.FromArgb(58, 20, 200), Color.FromArgb(46, 12, 226), Color.FromArgb(10, 0, 253) };
                brush.InterpolationColors = colorBlend;

                e.Graphics.FillRectangle(brush, this.ClientRectangle);

            }
        }

        private void AppoimentManagement_Load(object sender, EventArgs e)
        {


        }
        // Async method to load appointments
        private async Task LoadAppointmentsAsync()
        {
            try
            {
                // Fetch appointments from service
                var appointments = await appointmentService.FetchAppointmentsAsync();              
                if (appointments != null)               {
                    this.appointments = appointments;
                    // Clear DataGridView and populate with fetched appointments
                    dataGridView1.Rows.Clear();
                    foreach (var appointment in appointments)
                    {
                        dataGridView1.Rows.Add(appointment.AppoimentId, appointment.TimeStart, appointment.TimeEnd, appoimentStatus[appointment.Status], appointment.IsCompleted, appointment.sapacity, appointment.room, appointment.Doctor, appointment.date);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to fetch appointments data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Async method to load rooms
        private async Task LoadRoomsAsync()
        {
            // Fetch rooms from RoomApp
            List<Room> rooms = await RoomApp.Instance.GetAllRoomsAsync();
            this.rooms = rooms;
            // Populate comboBox6 with room names
            foreach (Room room in rooms)
            {
                comboBox6.Items.Add(room.roomName);
            }
        }




        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }
        // Event handler for button update click
        private async void button1_Click_1(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (this.rows < 0 || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null
                           || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null || comboBox5.SelectedItem == null
                           || comboBox6.SelectedItem == null || numericUpDown1.Value == null) 
            {

                MessageBox.Show("all fields must be filled in ");
            }
            else
            {
                // Construct appointment data from form fields
                string timeStart = comboBox2.SelectedItem.ToString() + ":" + comboBox3.SelectedItem.ToString() + ":00";
                string timeEnd = comboBox4.SelectedItem.ToString() + ":" + comboBox5.SelectedItem.ToString() + ":00";
                AppomentData editAppoment = new AppomentData();
                editAppoment.timeStart = timeStart;
                editAppoment.timeEnd = timeEnd;
                string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                editAppoment.sapacity = Convert.ToInt32(numericUpDown1.Value);
                editAppoment.date = date.Replace("/", "-");
                editAppoment.isComplete = false;
                editAppoment.status = 0;
                int doctorId = doctors[comboBox1.SelectedIndex].id;
                int roomId = rooms[comboBox6.SelectedIndex].roomId;
                // Call service to edit appointment
                await postAppointment.EditAppointmentAsync(editAppoment, doctorId, roomId, this.appoimentId);
                // Clear selection and reload appointments
                dataGridView1.ClearSelection();
               _ =  LoadAppointmentsAsync();
            }
        }
        // Event handler for table cell click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Populate form fields with selected appointment data
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                this.rows = e.RowIndex;
                String tanggalString = Convert.ToString(selectedRow.Cells["Date"].Value).Substring(0, 10);
                DateTime tanggal = DateTime.ParseExact(tanggalString, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                dateTimePicker1.Value = tanggal;
                comboBox1.SelectedItem = selectedRow.Cells["Doctor"].Value;
                comboBox2.SelectedItem = Convert.ToString(selectedRow.Cells["TimeStart"].Value).Substring(0, 2);
                comboBox3.SelectedItem = Convert.ToString(selectedRow.Cells["TimeStart"].Value).Substring(3, 2);

                comboBox4.SelectedItem = Convert.ToString(selectedRow.Cells["TimeEnd"].Value).Substring(0, 2);
                comboBox5.SelectedItem = Convert.ToString(selectedRow.Cells["TimeEnd"].Value).Substring(3, 2);
                comboBox6.SelectedItem = selectedRow.Cells["RoomName"].Value;
                int capacity = Convert.ToInt32(selectedRow.Cells["Capacity"].Value);
                numericUpDown1.Value = capacity;
                this.appoimentId = Convert.ToInt32(selectedRow.Cells["AppoimentId"].Value);





            }
        }
        // Method to fill time ComboBoxes
        private void FillComboBox()
        {

            // Fill hours (00-23) and minutes (00-59) ComboBoxes
            for (int i = 0; i <= 23; i++)
            {
                
                string hour = i.ToString("00");
                comboBox2.Items.Add(hour);
                comboBox4.Items.Add(hour);

            }
            comboBox3.Items.Add("00");
            comboBox5.Items.Add("00");
            for (int i = 1; i <= 59; i++)
            {
                string hour = i.ToString("00");
                comboBox3.Items.Add(hour);
                comboBox5.Items.Add(hour);
            }
        }
        // Async method to load doctors
        private async Task LoadDoctorssAsync()
        {
            // Fetch doctors from DoctorApp
            DoctorApp doctorApp = new DoctorApp();
            List<Doctor> doctors = await doctorApp.GetAllDoctorsAsync();
            this.doctors = doctors;
            // Populate comboBox1 with doctor names
            foreach (Doctor doctor in doctors)
            {
                comboBox1.Items.Add(doctor.firstName);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Rectangle borderRectangle = this.dataGridView1.ClientRectangle;

           

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        // Event handler for button Add click (Add Appointment)
        private async void button3_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null
                || comboBox3.SelectedItem == null || comboBox4.SelectedItem == null || comboBox5.SelectedItem == null
                || comboBox6.SelectedItem == null)
            {
              
                MessageBox.Show("all fields must be filled in ");
            }
            else
            {
                try
                {
                    // Construct appointment data from form fields
                    string timeStart = comboBox2.SelectedItem.ToString() + ":" + comboBox3.SelectedItem.ToString() + ":00";
                    string timeEnd = comboBox4.SelectedItem.ToString() + ":" + comboBox5.SelectedItem.ToString() + ":00";
                    AppomentData addAppointmentData = new AppomentData(); 
                    addAppointmentData.timeStart = timeStart;
                    addAppointmentData.timeEnd = timeEnd;
                    string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                    addAppointmentData.sapacity = Convert.ToInt32(numericUpDown1.Value);
                    addAppointmentData.date = date.Replace("/", "-");
                    addAppointmentData.isComplete = false;
                    addAppointmentData.status = 0;
                    int doctorId = doctors[comboBox1.SelectedIndex].id;
                    int roomId = rooms[comboBox6.SelectedIndex].roomId;
                    // Call service to create appointment
                    await postAppointment.CreateAppointmentAsync(addAppointmentData, doctorId, roomId);
                    // Clear selection and notify success
                    dataGridView1.ClearSelection();
                    MessageBox.Show("Appointment added successfully!");
                   _= LoadAppointmentsAsync();

                }
                catch (Exception ex)
                {
                    string message = ex.ToString();
                    MessageBox.Show(message);
                }
            }





        }
        // Event handler for button back click (Back to Admin Page)
        private void button4_Click(object sender, EventArgs e)
        {
            HalamanAdmin halamanAdmin = new HalamanAdmin(admin);
            halamanAdmin.Show();
            this.Hide();
        }
        // Event handler for button delete click (Delete Appointment)
        private async void button2_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (this.rows >=0)
            {

                // Delete appointment using service
                await appointmentService.DeleteAppoiment(this.appoimentId);
                // Clear selection and reload appointments
                dataGridView1.ClearSelection();
               await LoadAppointmentsAsync();
            }
        }
    }
}