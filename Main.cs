using MySql.Data.MySqlClient;
using System.Data;

namespace enciclopedia
{
    public partial class Main : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost; Database=enciclopedia; Uid=root; Pwd=;");
        public Main()
        {
            InitializeComponent();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help help = new();
            help.ShowDialog();
  
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About about = new();
            about.ShowDialog();
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            Support support = new();
            support.ShowDialog();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con el servidor");
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Historia FROM categorias", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewInfo.DataSource = dataTable;
        }

        private void buttonGeography_Click(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Geografia FROM categorias", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewInfo.DataSource = dataTable;
        }

        private void buttonPeople_Click(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Sociales FROM categorias", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewInfo.DataSource = dataTable;
        }

        private void buttonTech_Click(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Tecnologias FROM categorias", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewInfo.DataSource = dataTable;
        }

        private void buttonArts_Click(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Artes FROM categorias", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewInfo.DataSource = dataTable;
        }

        private void buttonPolitics_Click(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Politica FROM categorias", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewInfo.DataSource = dataTable;
        }

        private void buttonScience_Click(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Ciencias FROM categorias", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewInfo.DataSource = dataTable;
        }

        private void buttonReligion_Click(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Religion FROM categorias", connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewInfo.DataSource = dataTable;
        }
    }
}