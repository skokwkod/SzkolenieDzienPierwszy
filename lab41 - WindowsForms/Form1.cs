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

namespace lab41___WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pass = txtPassword.Text;
            try
            {
                string connectionString = $@"Data Source=192.168.3.42,50500; Initial Catalog=OC;User ID={login};Password={pass}";

                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection Open!");
                MessageBox.Show("Connection Open!");

                Form2 secondForm = new Form2();
                secondForm.Show();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
