using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace purplematcha
{
    public partial class Table : Form
    {
        // Variable for connection
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=studentsdatabase;User=root;Password='';");
        public Table()
        {
            InitializeComponent();

            // 
            try
            {
                connection.Open();
                string query = "SELECT * FROM studentstbl ORDER by studentsID DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Gridview.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("hey bro you'v got an error : " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 
                string query = "INSERT INTO studentstbl (Name, Age, isSingle) VALUES (@name, @Age, @isSingle)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //set a parameters
                cmd.Parameters.AddWithValue("@name", Name.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(Age.Text));

                cmd.Parameters.AddWithValue("@isSingle", isSingleCheckBox.Checked);

                //execute the query
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Inserted Succesfullly.");

                Gridview.DataSource = null;
                string query2 = "SELECT * FROM studentstbl ORDER by studentsID DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query2, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Gridview.DataSource = dt;

                Name.Text = "";
                Age.Text = "";
                isSingleCheckBox.Checked = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("you have an error erp!" + ex.Message);
            }


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
