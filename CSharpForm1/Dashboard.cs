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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connecting to a DB
            //Things needed:
            //1. SQL connection - connection string

            SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");
            con.Open();

            //2. SQL command - query

            SqlCommand cmd = new SqlCommand("INSERT INTO Employee ([ID],[FirstName],[LastName],[Email],[Gender],[Salary],[HireDate]) VALUES ('" + txtID.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtEmail.Text + "', '" + txtGender.Text + "', '" + txtSalary.Text + "', '" + dtHireDate.Value + "')", con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record saved successfully","Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
