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

        public void EmptyString()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtSalary.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connecting to a DB
            //Things needed:
            //1. SQL connection - connection string

            SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");

            //2. SQL command - query

            String query = "INSERT INTO Employee(FirstName, LastName, Email, Gender, Salary, HireDate) VALUES (@FirstName, @LastName, @Email, @Gender, @Salary, @HireDate)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@HireDate", dtHireDate.Value);


                //SqlCommand cmd = new SqlCommand("INSERT INTO Employee ([FirstName],[LastName],[Email],[Gender],[Salary],[HireDate]) VALUES ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtEmail.Text + "', '" + txtGender.Text + "', '" + txtSalary.Text + "', '" + dtHireDate.Value + "')", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEmployeeRecords();
                    EmptyString();
                }

                catch (SqlException err)
                {
                    MessageBox.Show($"Error:{err.ToString()}", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ////1. SQL connection - connection string

            //SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");
            //con.Open();

            ////2. SQL command - query to perform transaction

            //SqlCommand cmd = new SqlCommand("UPDATE [Employee] SET [FirstName]='"+txtFirstName.Text+ "', [LastName]='" + txtLastName.Text + "', [Email]='" + txtEmail.Text + "', [Gender]='" + txtGender.Text + "', [Salary]='" + txtSalary.Text + "', [HireDate]='" + dtHireDate.Value + "' Where ID='"+ txtID.Text +"'", con);

            //cmd.ExecuteNonQuery();

            //MessageBox.Show("Record updated successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //loadEmployeeRecords();

            //EmptyString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ////1. SQL connection - connection string

            //SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");
            //con.Open();

            ////2. SQL command - query to perform transaction

            //SqlCommand cmd = new SqlCommand("DELETE FROM [Employee] WHERE ID='" + txtID.Text + "' ", con);

            //cmd.ExecuteNonQuery();

            //MessageBox.Show("Record deleted successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //loadEmployeeRecords();

            //EmptyString();

        }

        public void loadEmployeeRecords()
        {
            //1. SQL connection - connection string

            SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");
            con.Open();

            //2. SQL command - query to perform transaction

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);

            //3. DataTable and SQLDataAdapter

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            //5.Bindingh Source

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dgvEmployee.DataSource = bs;
            sda.Update(dt);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadEmployeeRecords();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
