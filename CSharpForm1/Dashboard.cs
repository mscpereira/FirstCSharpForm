using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            txtGender.Text = default;
            txtSalary.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
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


                //Validations in a very bad way
                System.Text.RegularExpressions.Regex rName = new System.Text.RegularExpressions.Regex(@"^(\p{L}\p{M}*)+$");
                if (string.IsNullOrEmpty(txtFirstName.Text.ToString()) || (!rName.IsMatch(txtFirstName.Text.ToString())))
                {
                    invalidFirstName.Enabled = true;
                    invalidFirstName.ForeColor = Color.Red;
                    invalidFirstName.Text = "Please enter a valid name";
                    return;
                }
                
                invalidFirstName.Enabled = false;
                invalidFirstName.Text = String.Empty;

                if (string.IsNullOrEmpty(txtLastName.Text.ToString()) || (!rName.IsMatch(txtLastName.Text.ToString())))
                {
                    invalidLastName.Enabled = true;
                    invalidLastName.ForeColor = Color.Red;
                    invalidLastName.Text = "Please enter a valid name";
                    return;
                }

                invalidLastName.Enabled = false;
                invalidLastName.Text = String.Empty;

                System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
                if (string.IsNullOrEmpty(txtEmail.Text.ToString()) || (!rEmail.IsMatch(txtEmail.Text.ToString())))
                {
                    invalidEmail.Enabled = true;
                    invalidEmail.ForeColor = Color.Red;
                    invalidEmail.Text = "Please enter a valid email";
                    return;
                }

                invalidEmail.Enabled = false;
                invalidEmail.Text = String.Empty;

                if (string.IsNullOrEmpty(txtGender.Text.ToString()))
                {
                    invalidGender.Enabled = true;
                    invalidGender.ForeColor = Color.Red;
                    invalidGender.Text = "Can't be blank";
                    return;
                }

     
                invalidGender.Enabled = false;
                invalidGender.Text = String.Empty;


                System.Text.RegularExpressions.Regex rSalary = new System.Text.RegularExpressions.Regex(@"^[0-9]{1,8}([,.][0-9]{1,2})?$");
                if (string.IsNullOrEmpty(txtSalary.Text.ToString()) || (!rSalary.IsMatch(txtSalary.Text.ToString())))
                {
                   
                    invalidSalary.Enabled = true;
                    invalidSalary.ForeColor = Color.Red;
                    invalidSalary.Text = "Enter a valid number with 2 decimals max - Ex.: 1500.35";
                    return;
                }
                else

                invalidSalary.Enabled = false;
                invalidSalary.Text = String.Empty;
   
                try
                {

                //Validations in another very bad way
                    //if(true)
                    //    {
                    //    if (txtFirstName.Text == String.Empty || txtFirstName.Text == null)
                    //    {
                    //        MessageBox.Show($"{titleFirstName.Text} can't be blank!", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }

                    //    //LastName Field
                    //    if (txtLastName.Text == String.Empty || txtLastName.Text == null)
                    //    {
                    //        MessageBox.Show($"{titleLastName.Text} can't be blank!", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }
                   
                    //    //Email Field
                    //    if (txtEmail.Text == String.Empty || txtEmail.Text == null)
                    //    {
                    //        MessageBox.Show($"{titleEmail.Text} can't be blank!", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }

                    //    //Genre Field
                    //    if (txtGender.Text == String.Empty || txtGender.Text == null)
                    //    {
                    //        MessageBox.Show($"{titleGender.Text} can't be blank!", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    } 

                    //    //DateView Field
                    //    //if (dtHireDate.Value == 0 || )
                    //    //{
                    //    //    MessageBox.Show("Field can't be blank!", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    //    return;
                    //    //}

                    //    //Salary Field
                    //    if (txtSalary.Text == String.Empty || txtFirstName.Text == null)
                    //    {
                    //        MessageBox.Show($"{titleSalary.Text} can't be blank!", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }

                    //    }

                    con.Open();
                    cmd.ExecuteNonQuery();                    
                    MessageBox.Show("Record saved successfully", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEmployeeRecords();
                    btnUpdate.Enabled = true;
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
            if (dgvEmployee.Rows.Count > 0)
            {
                btnUpdate.Enabled = true;
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
                    if (txtSalary.Text == "")
                    {
                        cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Salary", System.Convert.ToDecimal(txtSalary.Text));
                    }

                    //Validations in a very bad way
                    System.Text.RegularExpressions.Regex rName = new System.Text.RegularExpressions.Regex(@"^(\p{L}\p{M}*)+$");
                    if (string.IsNullOrEmpty(txtFirstName.Text.ToString()) || (!rName.IsMatch(txtFirstName.Text.ToString())))
                    {
                        invalidFirstName.Enabled = true;
                        invalidFirstName.ForeColor = Color.Red;
                        invalidFirstName.Text = "Please enter a valid name";
                        return;
                    }

                    invalidFirstName.Enabled = false;
                    invalidFirstName.Text = String.Empty;

                    if (string.IsNullOrEmpty(txtLastName.Text.ToString()) || (!rName.IsMatch(txtLastName.Text.ToString())))
                    {
                        invalidLastName.Enabled = true;
                        invalidLastName.ForeColor = Color.Red;
                        invalidLastName.Text = "Please enter a valid name";
                        return;
                    }

                    invalidLastName.Enabled = false;
                    invalidLastName.Text = String.Empty;


                    System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
                    if (string.IsNullOrEmpty(txtEmail.Text.ToString()) || (!rEmail.IsMatch(txtEmail.Text.ToString())))
                    {
                        invalidEmail.Enabled = true;
                        invalidEmail.ForeColor = Color.Red;
                        invalidEmail.Text = "Please enter a valid email";
                        return;
                    }

                    invalidEmail.Enabled = false;
                    invalidEmail.Text = String.Empty;

                    if (string.IsNullOrEmpty(txtGender.Text.ToString()))
                    {
                        invalidGender.Enabled = true;
                        invalidGender.ForeColor = Color.Red;
                        invalidGender.Text = "Can't be blank";
                        return;
                    }

                    invalidGender.Enabled = false;
                    invalidGender.Text = String.Empty;


                    System.Text.RegularExpressions.Regex rSalary = new System.Text.RegularExpressions.Regex(@"^[0-9]{1,8}([,.][0-9]{1,2})?$");
                    if (string.IsNullOrEmpty(txtSalary.Text.ToString()) || (!rSalary.IsMatch(txtSalary.Text.ToString())))
                    {

                        invalidSalary.Enabled = true;
                        invalidSalary.ForeColor = Color.Red;
                        invalidSalary.Text = "Enter a valid number with 2 decimals max - Ex.: 1500.35";
                        return;
                    }
                    else

                    invalidSalary.Enabled = false;
                    invalidSalary.Text = String.Empty;


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
            else
            {
                btnUpdate.Enabled = false;
                MessageBox.Show("Save a record first!", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //DELETING SELECTED ROW IN DATAGRID (NOT DB)
            SqlConnection con = new SqlConnection("Data Source=localhost; Database=FirstLoginDB; Integrated Security=true");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM [Employee] WHERE ID=@ID", con);
            int selectedrowindex = dgvEmployee.CurrentRow.Index;
            DataGridViewRow selectedRow = dgvEmployee.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@ID", cellValue);
            cmd.ExecuteNonQuery();
            EmptyString();
            con.Close();

            foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dgvEmployee.Rows.Remove(row);
                }
            }
            if (dgvEmployee.Rows.Count > 0)
            {
                int nRowIndex = dgvEmployee.Rows.Count - 1;        
                dgvEmployee.Rows[nRowIndex].Selected = true;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtGender.Text = string.Empty;
                dtHireDate.Value = DateTime.Now;
                txtSalary.Text = string.Empty;
        }
    }
}
