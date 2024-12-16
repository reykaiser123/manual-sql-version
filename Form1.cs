using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections;


namespace Gym_Membership_Manage
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=gymmembership;Uid=root;Pwd=091455;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymMembershipDataSet.Memberships' table. You can move, or remove it, as needed.
            this.membershipsTableAdapter.Fill(this.gymMembershipDataSet.Memberships);

            LoadData();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                { 
                    conn.Open();
                    string query = "SELECT * FROM membership";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "File1.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(dcell.Value.ToString());

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void closeBT_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBT_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO membership (names_, number_, duration, occupation) VALUES (@Name,@Number, @Duration, @Occupation)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", nameTB.Text);
                        cmd.Parameters.AddWithValue("@Number", numberTB.Text);
                        cmd.Parameters.AddWithValue("@Duration", durationTB.Text);
                        cmd.Parameters.AddWithValue("@Occupation", occupationTB.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully.");
                            LoadData(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the record.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void saveBT_Click_1(object sender, EventArgs e)
        {
            String name = nameTB.Text;
            string number = numberTB.Text;
            string duration = durationTB.Text;
            string occupation = occupationTB.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE membership SET names_ = @Name, number_ = @Number, duration = @Duration," +
                    "occupation = @Occupation WHERE number_ = @Number";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))


                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Number", number);
                        cmd.Parameters.AddWithValue("@Duration", duration);
                        cmd.Parameters.AddWithValue("@Occupation", occupation);

                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("Record save successfully.");
                            LoadData(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the record.");
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error during Update: {ex.Message}");
                }
            }
        }

        private void deleteBT_Click_1(object sender, EventArgs e)
        {
            String name = nameTB.Text;
            string number = numberTB.Text;
            string duration = durationTB.Text;
            string occupation = occupationTB.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM membership WHERE number_ = @Number";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Number", number);
                        cmd.Parameters.AddWithValue("@Duration", duration);
                        cmd.Parameters.AddWithValue("@Occupation", occupation);

                        int rowsDeleted = cmd.ExecuteNonQuery();
                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            LoadData(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to deleted the record.");
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error during Delete: {ex.Message}");
                }

            }
        }
    }
}
