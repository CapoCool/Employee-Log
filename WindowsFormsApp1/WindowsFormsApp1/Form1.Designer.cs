namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_logDataSet = new WindowsFormsApp1.Employee_logDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressOne = new System.Windows.Forms.TextBox();
            this.statesOne = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zipCodeOne = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressTwo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statesTwo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.zipCodeTwo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ssn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApp1.Employee_logDataSetTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_logDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // lastName
            // 
            this.lastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "lastName", true));
            this.lastName.Location = new System.Drawing.Point(361, 29);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(145, 20);
            this.lastName.TabIndex = 3;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.employee_logDataSet;
            // 
            // employee_logDataSet
            // 
            this.employee_logDataSet.DataSetName = "Employee_logDataSet";
            this.employee_logDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth:";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "dateOfBirth", true));
            this.dateOfBirth.Location = new System.Drawing.Point(621, 29);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(145, 20);
            this.dateOfBirth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address 1:";
            // 
            // addressOne
            // 
            this.addressOne.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "addressOne", true));
            this.addressOne.Location = new System.Drawing.Point(117, 68);
            this.addressOne.Name = "addressOne";
            this.addressOne.Size = new System.Drawing.Size(389, 20);
            this.addressOne.TabIndex = 7;
            // 
            // statesOne
            // 
            this.statesOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statesOne.FormattingEnabled = true;
            this.statesOne.Items.AddRange(new object[] {
            "Alabama ",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "MAine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippa",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.statesOne.Location = new System.Drawing.Point(570, 67);
            this.statesOne.Name = "statesOne";
            this.statesOne.Size = new System.Drawing.Size(121, 21);
            this.statesOne.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zip Code:";
            // 
            // zipCodeOne
            // 
            this.zipCodeOne.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "zipCodeOne", true));
            this.zipCodeOne.Location = new System.Drawing.Point(780, 67);
            this.zipCodeOne.Name = "zipCodeOne";
            this.zipCodeOne.Size = new System.Drawing.Size(70, 20);
            this.zipCodeOne.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address 1:";
            // 
            // addressTwo
            // 
            this.addressTwo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "addressTwo", true));
            this.addressTwo.Location = new System.Drawing.Point(118, 104);
            this.addressTwo.Name = "addressTwo";
            this.addressTwo.Size = new System.Drawing.Size(389, 20);
            this.addressTwo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(512, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "State:";
            // 
            // statesTwo
            // 
            this.statesTwo.BackColor = System.Drawing.Color.White;
            this.statesTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statesTwo.FormattingEnabled = true;
            this.statesTwo.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South  Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.statesTwo.Location = new System.Drawing.Point(570, 103);
            this.statesTwo.Name = "statesTwo";
            this.statesTwo.Size = new System.Drawing.Size(121, 21);
            this.statesTwo.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(697, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Zip Code:";
            // 
            // zipCodeTwo
            // 
            this.zipCodeTwo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "zipCodeTwo", true));
            this.zipCodeTwo.Location = new System.Drawing.Point(780, 104);
            this.zipCodeTwo.Name = "zipCodeTwo";
            this.zipCodeTwo.Size = new System.Drawing.Size(70, 20);
            this.zipCodeTwo.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email:";
            // 
            // email
            // 
            this.email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "email", true));
            this.email.Location = new System.Drawing.Point(89, 145);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(249, 20);
            this.email.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(344, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Phone Number:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "cellPhone", true));
            this.phoneNumber.Location = new System.Drawing.Point(469, 145);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(146, 20);
            this.phoneNumber.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(621, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "SSN:";
            // 
            // ssn
            // 
            this.ssn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ssn", true));
            this.ssn.Location = new System.Drawing.Point(673, 147);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(177, 20);
            this.ssn.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(114, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Search:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(184, 180);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(770, 20);
            this.search.TabIndex = 26;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cancelButton.Location = new System.Drawing.Point(6, 210);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 354);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.TabStop = false;
            this.cancelButton.UseWaitCursor = true;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(15, 303);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(93, 23);
            this.newButton.TabIndex = 28;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(15, 332);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(93, 23);
            this.editButton.TabIndex = 29;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(15, 361);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(93, 23);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // firstName
            // 
            this.firstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "firstName", true));
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(117, 27);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(145, 20);
            this.firstName.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.addressOneDataGridViewTextBoxColumn,
            this.addressTwoDataGridViewTextBoxColumn,
            this.zipCodeOneDataGridViewTextBoxColumn,
            this.zipCodeTwoDataGridViewTextBoxColumn,
            this.homePhoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ssnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(122, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(836, 354);
            this.dataGridView1.TabIndex = 33;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 25;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressOneDataGridViewTextBoxColumn
            // 
            this.addressOneDataGridViewTextBoxColumn.DataPropertyName = "addressOne";
            this.addressOneDataGridViewTextBoxColumn.HeaderText = "addressOne";
            this.addressOneDataGridViewTextBoxColumn.Name = "addressOneDataGridViewTextBoxColumn";
            this.addressOneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressTwoDataGridViewTextBoxColumn
            // 
            this.addressTwoDataGridViewTextBoxColumn.DataPropertyName = "addressTwo";
            this.addressTwoDataGridViewTextBoxColumn.HeaderText = "addressTwo";
            this.addressTwoDataGridViewTextBoxColumn.Name = "addressTwoDataGridViewTextBoxColumn";
            this.addressTwoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipCodeOneDataGridViewTextBoxColumn
            // 
            this.zipCodeOneDataGridViewTextBoxColumn.DataPropertyName = "zipCodeOne";
            this.zipCodeOneDataGridViewTextBoxColumn.HeaderText = "zipCodeOne";
            this.zipCodeOneDataGridViewTextBoxColumn.Name = "zipCodeOneDataGridViewTextBoxColumn";
            this.zipCodeOneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipCodeTwoDataGridViewTextBoxColumn
            // 
            this.zipCodeTwoDataGridViewTextBoxColumn.DataPropertyName = "zipCodeTwo";
            this.zipCodeTwoDataGridViewTextBoxColumn.HeaderText = "zipCodeTwo";
            this.zipCodeTwoDataGridViewTextBoxColumn.Name = "zipCodeTwoDataGridViewTextBoxColumn";
            this.zipCodeTwoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homePhoneDataGridViewTextBoxColumn
            // 
            this.homePhoneDataGridViewTextBoxColumn.DataPropertyName = "homePhone";
            this.homePhoneDataGridViewTextBoxColumn.HeaderText = "homePhone";
            this.homePhoneDataGridViewTextBoxColumn.Name = "homePhoneDataGridViewTextBoxColumn";
            this.homePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ssnDataGridViewTextBoxColumn
            // 
            this.ssnDataGridViewTextBoxColumn.DataPropertyName = "ssn";
            this.ssnDataGridViewTextBoxColumn.HeaderText = "ssn";
            this.ssnDataGridViewTextBoxColumn.Name = "ssnDataGridViewTextBoxColumn";
            this.ssnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.employee_logDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.zipCodeTwo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statesTwo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressTwo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zipCodeOne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statesOne);
            this.Controls.Add(this.addressOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_logDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressOne;
        private System.Windows.Forms.ComboBox statesOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zipCodeOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressTwo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox statesTwo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox zipCodeTwo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox cancelButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox firstName;
        private Employee_logDataSet employee_logDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Employee_logDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnDataGridViewTextBoxColumn;
    }
}

