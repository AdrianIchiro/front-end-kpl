using front_end_kpl.Model;
using front_end_kpl.utils;
using front_end_kpl.view;
using Newtonsoft.Json;

namespace front_end_kpl
{
    public partial class Specialization : Form
    {
        Admin admin;
        SpecializationService service = new SpecializationService();
        string spcUrl = "https://localhost:7264/api/Specialization";
        public Specialization()
        {
            InitializeComponent();
        }

        private async void btn_Tambah_Click(object sender, EventArgs e)
        {

            try
            {
                string name = tB_Name.Text;
                string description = tB_Description.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Name and description cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await service.PostSpecialization(name, description);
                dataGridView1.DataSource = await service.SpecializationsAsyncGet(spcUrl);
                ClearTextBoxes();

                MessageBox.Show("Specialization added successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error Specialization occurred: {ex.Message}");
            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tB_SpecializationId.Text))
                {
                    MessageBox.Show("Specialization ID cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int specializationId = Convert.ToInt32(tB_SpecializationId.Text);
                var updatedSpecialization = new SpecializationModel
                {
                    name = tB_Name.Text,
                    description = tB_Description.Text
                };

                await service.UpdateSpecialization(specializationId, updatedSpecialization);
                dataGridView1.DataSource = await service.SpecializationsAsyncGet(spcUrl);
                ClearTextBoxes();

                MessageBox.Show("Specialization Updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error Specialization occurred: {ex.Message}");
                MessageBox.Show("Data tidak ditemukan, silakan klik data yang ingin diupdate");
            }
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tB_SpecializationId.Text))
                {
                    MessageBox.Show("Specialization ID cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int specializationId = Convert.ToInt32(tB_SpecializationId.Text);
                await service.DeleteSpecialization(specializationId);
                dataGridView1.DataSource = await service.SpecializationsAsyncGet(spcUrl);
                ClearTextBoxes();

                MessageBox.Show("Specialization Deleted successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error Specialization occurred: {ex.Message}");
            }
        }


        private async void Specialization_Load(object sender, EventArgs e)
        {

            List<SpecializationModel> listSpecializationModel = await service.SpecializationsAsyncGet(spcUrl);

            dataGridView1.DataSource = listSpecializationModel;

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int specializationId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["specializationId"].Value);
                tB_SpecializationId.Text = specializationId.ToString();

                string name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                tB_Name.Text = name;

                string description = dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString();
                tB_Description.Text = description;
            }
        }

        private void ClearTextBoxes()
        {
            tB_SpecializationId.Text = "";
            tB_Name.Text = "";
            tB_Description.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HalamanAdmin HalamanAdmin = new HalamanAdmin(admin);

            HalamanAdmin.Show();

            this.Close();
        }
    }
}
