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

namespace CSharpForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Connecting to a DB with a login system
            //Things needed:
            //1. SQL connection

            SqlConnection con = new SqlConnection("Data Source=Localhost; Database=FirstLoginDB; Integrated Security=True");
            con.Open();

            //2. SQL command

            SqlCommand cmd = new SqlCommand("Select * from Account Where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", con);

            //3. SQL datareader

            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please type a correct Username and/ or Password", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
