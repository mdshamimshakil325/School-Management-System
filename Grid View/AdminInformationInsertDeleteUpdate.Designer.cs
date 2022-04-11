
namespace WFASchoolManagementSystem.Grid_View
{
    partial class AdminInformationInsertDeleteUpdate
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
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mothername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parmanentaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpLeftDate = new System.Windows.Forms.DateTimePicker();
            this.dtpJoingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtParmanentAddress = new System.Windows.Forms.TextBox();
            this.txtPresentAddress = new System.Windows.Forms.TextBox();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacher.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.fullname,
            this.email,
            this.gender,
            this.dateofbirth,
            this.nationality,
            this.religion,
            this.bloodgroup,
            this.fathername,
            this.mothername,
            this.joiningdate,
            this.leftdate,
            this.salary,
            this.qualification,
            this.presentaddress,
            this.parmanentaddress,
            this.contactnumber});
            this.dgvTeacher.Location = new System.Drawing.Point(-42, 290);
            this.dgvTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.RowTemplate.Height = 24;
            this.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacher.Size = new System.Drawing.Size(1342, 426);
            this.dgvTeacher.TabIndex = 189;
            this.dgvTeacher.DoubleClick += new System.EventHandler(this.dgvTeacher_DoubleClick);
            // 
            // userId
            // 
            this.userId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "Admin ID";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateofbirth.DataPropertyName = "dateofbirth";
            this.dateofbirth.HeaderText = "DOB";
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            // 
            // nationality
            // 
            this.nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nationality.DataPropertyName = "nationality";
            this.nationality.HeaderText = "Nationality";
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            // 
            // religion
            // 
            this.religion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.religion.DataPropertyName = "religion";
            this.religion.HeaderText = "Religion";
            this.religion.Name = "religion";
            this.religion.ReadOnly = true;
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "BloodGroup";
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            // 
            // fathername
            // 
            this.fathername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fathername.DataPropertyName = "fathername";
            this.fathername.HeaderText = "Father\'s Name";
            this.fathername.Name = "fathername";
            this.fathername.ReadOnly = true;
            // 
            // mothername
            // 
            this.mothername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mothername.DataPropertyName = "mothername";
            this.mothername.HeaderText = "Mother\'s Name";
            this.mothername.Name = "mothername";
            this.mothername.ReadOnly = true;
            // 
            // joiningdate
            // 
            this.joiningdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.joiningdate.DataPropertyName = "joiningdate";
            this.joiningdate.HeaderText = "Joining Date";
            this.joiningdate.Name = "joiningdate";
            this.joiningdate.ReadOnly = true;
            // 
            // leftdate
            // 
            this.leftdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.leftdate.DataPropertyName = "leftdate";
            this.leftdate.HeaderText = "Left Date";
            this.leftdate.Name = "leftdate";
            this.leftdate.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // qualification
            // 
            this.qualification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qualification.DataPropertyName = "qualification";
            this.qualification.HeaderText = "Qualification";
            this.qualification.Name = "qualification";
            this.qualification.ReadOnly = true;
            // 
            // presentaddress
            // 
            this.presentaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.presentaddress.DataPropertyName = "presentaddress";
            this.presentaddress.HeaderText = "Present Address";
            this.presentaddress.Name = "presentaddress";
            this.presentaddress.ReadOnly = true;
            // 
            // parmanentaddress
            // 
            this.parmanentaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parmanentaddress.DataPropertyName = "parmanentaddress";
            this.parmanentaddress.HeaderText = "Parmanent Address";
            this.parmanentaddress.Name = "parmanentaddress";
            this.parmanentaddress.ReadOnly = true;
            // 
            // contactnumber
            // 
            this.contactnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactnumber.DataPropertyName = "contactnumber";
            this.contactnumber.HeaderText = "Contact Number";
            this.contactnumber.Name = "contactnumber";
            this.contactnumber.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(805, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 229;
            this.label2.Text = "          ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(594, 24);
            this.label3.TabIndex = 228;
            this.label3.Text = "ADMIN PERSONAL INFORMATION INSERT/DELETE/UPDATE";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(470, 239);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(167, 24);
            this.label33.TabIndex = 226;
            this.label33.Text = "Contact Number:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(438, 215);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(199, 24);
            this.label31.TabIndex = 225;
            this.label31.Text = "Parmanent Address:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(467, 191);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(170, 24);
            this.label29.TabIndex = 224;
            this.label29.Text = "Present Address:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(506, 167);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 24);
            this.label27.TabIndex = 223;
            this.label27.Text = "Qualification:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(540, 143);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 24);
            this.label25.TabIndex = 222;
            this.label25.Text = "Left Date:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(505, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(132, 24);
            this.label23.TabIndex = 221;
            this.label23.Text = "Joining Date:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(495, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(142, 24);
            this.label21.TabIndex = 220;
            this.label21.Text = "Mother Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(500, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 24);
            this.label19.TabIndex = 219;
            this.label19.Text = "Father Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(135, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 24);
            this.label17.TabIndex = 218;
            this.label17.Text = "Blood Group:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(176, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 24);
            this.label15.TabIndex = 217;
            this.label15.Text = "Religion:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(157, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 24);
            this.label13.TabIndex = 216;
            this.label13.Text = "Nationality:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(136, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 24);
            this.label11.TabIndex = 215;
            this.label11.Text = "Date Of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 214;
            this.label9.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 213;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 212;
            this.label6.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 211;
            this.label4.Text = "Name:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(168, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 24);
            this.label26.TabIndex = 210;
            this.label26.Text = "Admin ID:";
            // 
            // dtpLeftDate
            // 
            this.dtpLeftDate.CustomFormat = "yyyy-MM-dd";
            this.dtpLeftDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLeftDate.Location = new System.Drawing.Point(642, 146);
            this.dtpLeftDate.Name = "dtpLeftDate";
            this.dtpLeftDate.Size = new System.Drawing.Size(159, 20);
            this.dtpLeftDate.TabIndex = 209;
            // 
            // dtpJoingDate
            // 
            this.dtpJoingDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoingDate.Location = new System.Drawing.Point(642, 122);
            this.dtpJoingDate.Name = "dtpJoingDate";
            this.dtpJoingDate.Size = new System.Drawing.Size(159, 20);
            this.dtpJoingDate.TabIndex = 208;
            // 
            // dtpdob
            // 
            this.dtpdob.CustomFormat = "yyyy-MM-dd";
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdob.Location = new System.Drawing.Point(274, 194);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(159, 20);
            this.dtpdob.TabIndex = 207;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(274, 170);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(159, 21);
            this.cmbGender.TabIndex = 206;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(883, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 132);
            this.panel1.TabIndex = 205;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 230;
            this.label5.Text = "       ";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Bisque;
            this.btnClear.Location = new System.Drawing.Point(230, 24);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 20);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Bisque;
            this.btnUpdate.Location = new System.Drawing.Point(154, 24);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 20);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Bisque;
            this.btnDelete.Location = new System.Drawing.Point(78, 24);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 20);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Bisque;
            this.btnSave.Location = new System.Drawing.Point(2, 24);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 20);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Insert";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Bisque;
            this.btnShow.Location = new System.Drawing.Point(307, 24);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(72, 20);
            this.btnShow.TabIndex = 91;
            this.btnShow.Text = "Show All Info";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(190, 73);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(159, 20);
            this.txtAutoSearch.TabIndex = 92;
            this.txtAutoSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Search By Admin ID:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(641, 242);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(159, 20);
            this.txtContactNumber.TabIndex = 204;
            this.txtContactNumber.Text = "01";
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNumber_KeyPress);
            // 
            // txtParmanentAddress
            // 
            this.txtParmanentAddress.Location = new System.Drawing.Point(641, 218);
            this.txtParmanentAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtParmanentAddress.Name = "txtParmanentAddress";
            this.txtParmanentAddress.Size = new System.Drawing.Size(159, 20);
            this.txtParmanentAddress.TabIndex = 203;
            // 
            // txtPresentAddress
            // 
            this.txtPresentAddress.Location = new System.Drawing.Point(641, 194);
            this.txtPresentAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtPresentAddress.Name = "txtPresentAddress";
            this.txtPresentAddress.Size = new System.Drawing.Size(159, 20);
            this.txtPresentAddress.TabIndex = 202;
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(642, 170);
            this.txtQualification.Margin = new System.Windows.Forms.Padding(2);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(159, 20);
            this.txtQualification.TabIndex = 201;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(274, 122);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(159, 20);
            this.txtSalary.TabIndex = 200;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(642, 98);
            this.txtMotherName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(159, 20);
            this.txtMotherName.TabIndex = 199;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(642, 74);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(159, 20);
            this.txtFatherName.TabIndex = 198;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(274, 266);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(2);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(159, 20);
            this.txtBloodGroup.TabIndex = 197;
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(274, 242);
            this.txtReligion.Margin = new System.Windows.Forms.Padding(2);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(159, 20);
            this.txtReligion.TabIndex = 196;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(274, 218);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(2);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(159, 20);
            this.txtNationality.TabIndex = 195;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 146);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 194;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(274, 98);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(159, 20);
            this.txtFullName.TabIndex = 193;
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(274, 74);
            this.txtTeacherId.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.ReadOnly = true;
            this.txtTeacherId.Size = new System.Drawing.Size(159, 20);
            this.txtTeacherId.TabIndex = 192;
            // 
            // AdminInformationInsertDeleteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1297, 718);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.dtpLeftDate);
            this.Controls.Add(this.dtpJoingDate);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtParmanentAddress);
            this.Controls.Add(this.txtPresentAddress);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.txtReligion);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtTeacherId);
            this.Controls.Add(this.dgvTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminInformationInsertDeleteUpdate";
            this.Text = "AdminInformationInsertDeleteUpdate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminInformationInsertDeleteUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn mothername;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn parmanentaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtpLeftDate;
        private System.Windows.Forms.DateTimePicker dtpJoingDate;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtParmanentAddress;
        private System.Windows.Forms.TextBox txtPresentAddress;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label label5;
    }
}