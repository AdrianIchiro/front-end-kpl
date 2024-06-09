﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using front_end_kpl.utils;

namespace front_end_kpl.view
{
    public partial class Room : Form
    {
        private RoomApp app;

        string id;
        string name;
        int floor;
        int number;

        public Room()
        {
            InitializeComponent();
            app = new RoomApp();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
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
                // Refresh data grid atau lakukan tindakan lain
                await LoadRooms();
            }
        }


        //Delte button
        private async void button2_Click(object sender, EventArgs e)
        {
            int id = (int)SpinnerId.Value;

            bool isComplete = await app.DeleteRoom(id);
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
                // Refresh data grid atau lakukan tindakan lain
                await LoadRooms();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Room_Load(object sender, EventArgs e)
        {
            await LoadRooms();
        }

        private async Task LoadRooms()
        {
            var rooms = await app.GetAllRoomsAsync();
            TableRoom.DataSource = rooms;
        }
    }
}