using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Admin
{
    public partial class FormTeacherInfo : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public FormTeacherInfo()
        {
            InitializeComponent();

            this.da = new DataAccess();

            string sql = "select * from Teacher order by userId desc;";
            this.PopulateGridView(sql);
            this.GenerateTeacherID();
        }



        private void FormTeacherInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvTeacher.AutoGenerateColumns = false;
            this.dgvTeacher.DataSource = this.ds.Tables[0];
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.label5.Text = "";
            txtAutoSearch.Text = "";
            try
            {
                string sql = "select * from Teacher order by userId desc;";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.label5.Text = "";
            this.ClearAll();
            try
            {
                string sql = "select * from Teacher where userId like '" + this.txtAutoSearch.Text + "%' order by userId desc;";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
             
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql3 = "select userId from Teacher where userId = '" + this.txtTeacherId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);


            if (ds.Tables[0].Rows.Count == 0)
            {
                try
                {
                    string sql = @"insert into Teacher 
                            values ('" + this.txtTeacherId.Text + "','" + this.txtFullName.Text + "', '" + this.txtEmail.Text + "', '" + this.cmbGender.Text + "', '" + this.dtpdob.Text + "', '" + this.txtNationality.Text + "', '" + this.txtReligion.Text + "', '" + this.txtBloodGroup.Text + "', '" + this.txtFatherName.Text + "', '" + this.txtMotherName.Text + "', '" + this.dtpJoingDate.Text + "', '" + this.dtpLeftDate.Text + "', '" + this.txtSalary.Text + "',  '" + this.txtQualification.Text + "' , '" + this.txtSubject.Text + "' , '" + this.txtPresentAddress.Text + "', '" + this.txtParmanentAddress.Text + "', " + this.txtContactNumber.Text + ");";

                    int count = this.da.ExecuteUpdateQuery(sql);
                    if (count == 1)
                    {
                        label5.Text = ("Teacher ID: " + this.txtTeacherId.Text + " Inserted Properly.");
                    }
                    else
                    {
                       
                    }
                    string sql2 = "select * from Teacher order by userId desc;";
                    this.PopulateGridView(sql2);
                    this.ClearAll();
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.Message);
                }
            }
            else
            {
                label5.Text = ("Student ID: " + this.txtTeacherId.Text + " Already Insert.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql3 = "select userId from Teacher where userId = '" + this.txtTeacherId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);


            if (ds.Tables[0].Rows.Count == 1)
            {
                try
                {
                    string teacher_id = this.dgvTeacher.CurrentRow.Cells[0].Value.ToString();
                    string fullname = this.dgvTeacher.CurrentRow.Cells["fullname"].Value.ToString();

                    string sql = @"delete from Teacher where userId = '" + teacher_id + "';";
                    int count = this.da.ExecuteUpdateQuery(sql);

                    if (count == 1)
                    {
                        label5.Text = ("Teacher ID: " + this.txtTeacherId.Text + " has been deleted.");
                    }
                    else
                    {
                        
                    }
                    string sql2 = "select * from Teacher order by userId desc;";
                    this.PopulateGridView(sql2);
                    this.ClearAll();
                }   
                catch (Exception ea)
                {
                    MessageBox.Show(ea.Message);
                }
            }
            else
            {
                label5.Text = ("Please Click Insert Button for Insert.");
            }
        }
        private void dgvTeacher_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.label5.Text = "";
                this.txtTeacherId.ReadOnly = true;
                this.txtTeacherId.Text = this.dgvTeacher.CurrentRow.Cells["userId"].Value.ToString();
                this.txtFullName.Text = this.dgvTeacher.CurrentRow.Cells["fullname"].Value.ToString();
                this.txtEmail.Text = this.dgvTeacher.CurrentRow.Cells["email"].Value.ToString();
                this.cmbGender.Text = this.dgvTeacher.CurrentRow.Cells["gender"].Value.ToString();
                this.dtpdob.Text = this.dgvTeacher.CurrentRow.Cells["dateofbirth"].Value.ToString();
                this.txtNationality.Text = this.dgvTeacher.CurrentRow.Cells["nationality"].Value.ToString();
                this.txtReligion.Text = this.dgvTeacher.CurrentRow.Cells["religion"].Value.ToString();
                this.txtBloodGroup.Text = this.dgvTeacher.CurrentRow.Cells["bloodgroup"].Value.ToString();
                this.txtFatherName.Text = this.dgvTeacher.CurrentRow.Cells["fathername"].Value.ToString();
                this.txtMotherName.Text = this.dgvTeacher.CurrentRow.Cells["mothername"].Value.ToString();
                this.dtpJoingDate.Text = this.dgvTeacher.CurrentRow.Cells["joiningdate"].Value.ToString();
                this.dtpLeftDate.Text = this.dgvTeacher.CurrentRow.Cells["leftdate"].Value.ToString();
                this.txtSalary.Text = this.dgvTeacher.CurrentRow.Cells["salary"].Value.ToString();
                this.txtQualification.Text = this.dgvTeacher.CurrentRow.Cells["qualification"].Value.ToString();
                this.txtSubject.Text = this.dgvTeacher.CurrentRow.Cells["subject"].Value.ToString();
                this.txtPresentAddress.Text = this.dgvTeacher.CurrentRow.Cells["presentaddress"].Value.ToString();
                this.txtParmanentAddress.Text = this.dgvTeacher.CurrentRow.Cells["parmanentaddress"].Value.ToString();
                this.txtContactNumber.Text = this.dgvTeacher.CurrentRow.Cells["contactnumber"].Value.ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql3 = "select userId from Teacher where userId = '" + this.txtTeacherId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);


            if (ds.Tables[0].Rows.Count == 1)
            {
                try
                {
                    string sql = @"update Teacher 
                                set fullname = '" + this.txtFullName.Text + @"',
                                email = '" + this.txtEmail.Text + @"',
                                gender = '" + this.cmbGender.Text + @"',
                                dateofbirth = '" + this.dtpdob.Text + @"' ,
                                nationality = '" + this.txtNationality.Text + @"' ,
                                religion = '" + this.txtReligion.Text + @"' ,
                                bloodgroup = '" + this.txtBloodGroup.Text + @"' ,
                                fathername = '" + this.txtFatherName.Text + @"' ,
                                mothername =  '" + this.txtMotherName.Text + @"' ,
                                joiningdate = '" + this.dtpJoingDate.Text + @"' ,
                                leftdate = '" + this.dtpLeftDate.Text + @"' ,
                                salary = '" + this.txtSalary.Text + @"' ,
                                qualification = '" + this.txtQualification.Text + @"' ,
                                subject = '" + this.txtSubject.Text + @"' ,
                                presentaddress = '" + this.txtPresentAddress.Text + @"' ,
                                parmanentaddress = '" + this.txtParmanentAddress.Text + @"' ,
                                contactnumber = " + this.txtContactNumber.Text + @"
                                where userId = '" + this.txtTeacherId.Text + "';";
                    int count = this.da.ExecuteUpdateQuery(sql);

                    if (count == 1)
                    {
                        label5.Text = ("Teacher ID: " + this.txtTeacherId.Text + " has been Updated.");
                    }
                    else
                    {
                        
                    }
                    string sql2 = "select * from Teacher order by userId desc;";
                    this.PopulateGridView(sql2);
                    this.ClearAll();
                }
                catch (Exception ea)
                {
                MessageBox.Show(ea.Message);
                }
            }
            else
            {
                label5.Text = ("Please Click Insert Button for Insert.");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Text = "";
            this.label5.Text = "";
            this.ClearAll();
        }
       
        private void ClearAll()
        {
            try
            {
                this.txtTeacherId.Clear();
                this.txtFullName.Clear();
                this.txtEmail.Clear();
                this.cmbGender.SelectedIndex = -1;
                this.dtpdob.Text = "";
                this.txtNationality.Clear();
                this.txtReligion.Clear();
                this.txtBloodGroup.Clear();
                this.txtFatherName.Clear();
                this.txtMotherName.Clear();
                this.dtpJoingDate.Text = "";
                this.dtpLeftDate.Text = "";
                this.txtSalary.Clear();
                this.txtQualification.Clear();
               // this.txtSubject.Clear();
                this.txtPresentAddress.Clear();
                this.txtParmanentAddress.Clear();
                this.txtContactNumber.Text = "01";
                this.label2.Text = "";
                this.GenerateTeacherID();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void GenerateTeacherID()
        {
            try
            {
                string sql = "select * from Teacher order by userId desc;";
                DataTable dt = this.da.ExecuteQueryTable(sql);
                string id = dt.Rows[0]["userId"].ToString();
                string[] str = id.Split('T');
                int number = Convert.ToInt32(str[1]);
                string newId = "T" + (++number).ToString("d4");
                this.txtTeacherId.Text = newId;
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void FormTeacherInfo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //e.Handled = true;
                label2.Text = "Only Digit.";
            }
        }
    }
}
