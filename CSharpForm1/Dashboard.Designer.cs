namespace CSharpForm1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.titleFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.titleLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.titleSalary = new System.Windows.Forms.Label();
            this.titleHireDate = new System.Windows.Forms.Label();
            this.titleGender = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.titleEmail = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstLoginDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstLoginDBDataSet = new CSharpForm1.FirstLoginDBDataSet();
            this.dtHireDate = new System.Windows.Forms.DateTimePicker();
            this.employeeTableAdapter = new CSharpForm1.FirstLoginDBDataSetTableAdapters.EmployeeTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.invalidFirstName = new System.Windows.Forms.Label();
            this.invalidLastName = new System.Windows.Forms.Label();
            this.invalidEmail = new System.Windows.Forms.Label();
            this.invalidGender = new System.Windows.Forms.Label();
            this.invalidSalary = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstLoginDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstLoginDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 58);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(460, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 36);
            this.textBox1.TabIndex = 12;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "EMPLOYEE INFORMATION";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleFirstName
            // 
            this.titleFirstName.AutoSize = true;
            this.titleFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleFirstName.Location = new System.Drawing.Point(40, 122);
            this.titleFirstName.Name = "titleFirstName";
            this.titleFirstName.Size = new System.Drawing.Size(76, 17);
            this.titleFirstName.TabIndex = 1;
            this.titleFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(131, 121);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(417, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // titleLastName
            // 
            this.titleLastName.AutoSize = true;
            this.titleLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleLastName.Location = new System.Drawing.Point(40, 164);
            this.titleLastName.Name = "titleLastName";
            this.titleLastName.Size = new System.Drawing.Size(76, 17);
            this.titleLastName.TabIndex = 1;
            this.titleLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(131, 163);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(417, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(697, 203);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(417, 20);
            this.txtSalary.TabIndex = 6;
            // 
            // titleSalary
            // 
            this.titleSalary.AutoSize = true;
            this.titleSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleSalary.Location = new System.Drawing.Point(623, 204);
            this.titleSalary.Name = "titleSalary";
            this.titleSalary.Size = new System.Drawing.Size(48, 17);
            this.titleSalary.TabIndex = 3;
            this.titleSalary.Text = "Salary";
            // 
            // titleHireDate
            // 
            this.titleHireDate.AutoSize = true;
            this.titleHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleHireDate.Location = new System.Drawing.Point(605, 167);
            this.titleHireDate.Name = "titleHireDate";
            this.titleHireDate.Size = new System.Drawing.Size(68, 17);
            this.titleHireDate.TabIndex = 4;
            this.titleHireDate.Text = "Hire Date";
            // 
            // titleGender
            // 
            this.titleGender.AutoSize = true;
            this.titleGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleGender.Location = new System.Drawing.Point(615, 122);
            this.titleGender.Name = "titleGender";
            this.titleGender.Size = new System.Drawing.Size(56, 17);
            this.titleGender.TabIndex = 5;
            this.titleGender.Text = "Gender";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(417, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // titleEmail
            // 
            this.titleEmail.AutoSize = true;
            this.titleEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.titleEmail.Location = new System.Drawing.Point(74, 203);
            this.titleEmail.Name = "titleEmail";
            this.titleEmail.Size = new System.Drawing.Size(42, 17);
            this.titleEmail.TabIndex = 9;
            this.titleEmail.Text = "Email";
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.txtGender.Location = new System.Drawing.Point(697, 121);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(417, 21);
            this.txtGender.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(774, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(907, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(1040, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dgvEmployee.DataSource = this.employeeBindingSource;
            this.dgvEmployee.Location = new System.Drawing.Point(43, 323);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1095, 426);
            this.dgvEmployee.TabIndex = 10;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.firstLoginDBDataSetBindingSource;
            // 
            // firstLoginDBDataSetBindingSource
            // 
            this.firstLoginDBDataSetBindingSource.DataSource = this.firstLoginDBDataSet;
            this.firstLoginDBDataSetBindingSource.Position = 0;
            // 
            // firstLoginDBDataSet
            // 
            this.firstLoginDBDataSet.DataSetName = "FirstLoginDBDataSet";
            this.firstLoginDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtHireDate
            // 
            this.dtHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHireDate.Location = new System.Drawing.Point(697, 163);
            this.dtHireDate.Name = "dtHireDate";
            this.dtHireDate.Size = new System.Drawing.Size(417, 20);
            this.dtHireDate.TabIndex = 5;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(1070, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(43, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // invalidFirstName
            // 
            this.invalidFirstName.AutoSize = true;
            this.invalidFirstName.Enabled = false;
            this.invalidFirstName.Location = new System.Drawing.Point(138, 144);
            this.invalidFirstName.Name = "invalidFirstName";
            this.invalidFirstName.Size = new System.Drawing.Size(0, 13);
            this.invalidFirstName.TabIndex = 12;
            this.invalidFirstName.Tag = "";
            // 
            // invalidLastName
            // 
            this.invalidLastName.AutoSize = true;
            this.invalidLastName.Enabled = false;
            this.invalidLastName.Location = new System.Drawing.Point(138, 187);
            this.invalidLastName.Name = "invalidLastName";
            this.invalidLastName.Size = new System.Drawing.Size(0, 13);
            this.invalidLastName.TabIndex = 13;
            // 
            // invalidEmail
            // 
            this.invalidEmail.AutoSize = true;
            this.invalidEmail.Enabled = false;
            this.invalidEmail.Location = new System.Drawing.Point(135, 226);
            this.invalidEmail.Name = "invalidEmail";
            this.invalidEmail.Size = new System.Drawing.Size(0, 13);
            this.invalidEmail.TabIndex = 14;
            // 
            // invalidGender
            // 
            this.invalidGender.AutoSize = true;
            this.invalidGender.Enabled = false;
            this.invalidGender.Location = new System.Drawing.Point(703, 145);
            this.invalidGender.Name = "invalidGender";
            this.invalidGender.Size = new System.Drawing.Size(0, 13);
            this.invalidGender.TabIndex = 15;
            this.invalidGender.Tag = "";
            // 
            // invalidSalary
            // 
            this.invalidSalary.AutoSize = true;
            this.invalidSalary.Enabled = false;
            this.invalidSalary.Location = new System.Drawing.Point(703, 226);
            this.invalidSalary.Name = "invalidSalary";
            this.invalidSalary.Size = new System.Drawing.Size(0, 13);
            this.invalidSalary.TabIndex = 17;
            this.invalidSalary.Tag = "";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1223, 786);
            this.Controls.Add(this.invalidSalary);
            this.Controls.Add(this.invalidGender);
            this.Controls.Add(this.invalidEmail);
            this.Controls.Add(this.invalidLastName);
            this.Controls.Add(this.invalidFirstName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtHireDate);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.titleEmail);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.titleSalary);
            this.Controls.Add(this.titleHireDate);
            this.Controls.Add(this.titleGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.titleLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.titleFirstName);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstLoginDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstLoginDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titleFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label titleLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label titleSalary;
        private System.Windows.Forms.Label titleHireDate;
        private System.Windows.Forms.Label titleGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label titleEmail;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DateTimePicker dtHireDate;
        private System.Windows.Forms.BindingSource firstLoginDBDataSetBindingSource;
        private FirstLoginDBDataSet firstLoginDBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private FirstLoginDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label invalidFirstName;
        private System.Windows.Forms.Label invalidLastName;
        private System.Windows.Forms.Label invalidEmail;
        private System.Windows.Forms.Label invalidGender;
        private System.Windows.Forms.Label invalidSalary;
    }
}