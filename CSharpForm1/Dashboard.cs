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


        public void EmptyString()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtSalary.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Connecting to a DB
            //Things needed:
            //1. SQL connection - connection string

            SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");

            //2. SQL command - query

            //SqlCommand cmd = new SqlCommand("INSERT INTO Employee ([FirstName],[LastName],[Email],[Gender],[Salary],[HireDate]) VALUES ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtEmail.Text + "', '" + txtGender.Text + "', '" + txtSalary.Text + "', '" + dtHireDate.Value + "')", con);
            String query = "INSERT INTO Employee(FirstName, LastName, Email, Gender, Salary, HireDate) VALUES (@FirstName, @LastName, @Email, @Gender, @Salary, @HireDate)";
          
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@HireDate", dtHireDate.Value);
                try
                {
                    con.Open();
                    if (txtFirstName.Text == String.Empty || txtFirstName.Text == null)
                    {
                        MessageBox.Show("Field can't be blank!", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cmd.ExecuteNonQuery();                    
                    MessageBox.Show("Record saved successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEmployeeRecords();
                    EmptyString();
                }

                catch (SqlException err)
                {
                    MessageBox.Show($"Error:{err.ToString()}", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal sal = decimal.Parse(txtSalary.Text);
            //1. SQL connection - connection string

            SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");      

            //2. SQL command - query to perform transaction

            String query = "UPDATE [Employee] SET [FirstName]=@FirstName, [LastName]=@LastName, [Email]=@Email, [Gender]=@Gender, [Salary]=@Salary, [HireDate]=@HireDate Where ID=@ID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                int selectedrowindex = dgvEmployee.CurrentRow.Index;
                DataGridViewRow selectedRow = dgvEmployee.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@ID", cellValue);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@HireDate", dtHireDate.Value);
                cmd.Parameters.AddWithValue("@Salary", sal);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEmployeeRecords();
                    EmptyString();
                }
                catch (SqlException err)
                {
                    MessageBox.Show($"Error:{err.ToString()}", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //DELETING SELECTED ROW IN DATAGRID (NOT DB)
            SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM [Employee] WHERE ID=@ID", con);
            int selectedrowindex = dgvEmployee.CurrentRow.Index;
            DataGridViewRow selectedRow =dgvEmployee.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@ID", cellValue);
            cmd.ExecuteNonQuery();
            con.Close();

            foreach(DataGridViewRow row in dgvEmployee.SelectedRows)
            {
                if(!row.IsNewRow)
                {
                    dgvEmployee.Rows.Remove(row);
                }
            }
        }
               
            //DELETING A ROW IN DATAGRID AND DB BY TYPING THE USER ID ON ID INPUT

            //SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("DELETE FROM [Employee] WHERE ID=@ID", con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Record deleted successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //loadEmployeeRecords();
            //EmptyString();

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
            // TODO: esta linha de código carrega dados na tabela 'firstLoginDBDataSet.Employee'. pode movê-la ou removê-la conforme necessário.
            this.employeeTableAdapter.Fill(this.firstLoginDBDataSet.Employee);
            loadEmployeeRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvEmployee.Rows[e.RowIndex];
                txtFirstName.Text = dgvRow.Cells[1].Value.ToString();
                txtLastName.Text = dgvRow.Cells[2].Value.ToString();
                txtEmail.Text = dgvRow.Cells[3].Value.ToString();
                txtGender.Text = dgvRow.Cells[4].Value.ToString();
                dtHireDate.Value = (DateTime)dgvRow.Cells[5].Value;
                txtSalary.Text = dgvRow.Cells[6].Value.ToString();

            }
        }
    }
}
