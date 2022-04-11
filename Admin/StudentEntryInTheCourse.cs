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
    public partial class StudentEntryInTheCourse : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public StudentEntryInTheCourse()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from studentenrollment;";
            this.PopulateGridView(sql);
            this.GenerateStudentEnrollmentID();
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.DataSource = this.ds.Tables[0];
        }
        private void GenerateStudentEnrollmentID()
        {
            try
            {
                string sql = "select * from studentenrollment order by studentenrollmentId desc;";
                DataTable dt = this.da.ExecuteQueryTable(sql);
                string id = dt.Rows[0]["studentenrollmentId"].ToString();
                string[] str = id.Split('E');
                int number = Convert.ToInt32(str[1]);
                string newId = "E" + (++number).ToString("d4");

                this.txtStudentId.Text = newId;
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }
        private void ClearAll()
        {
            try
            {
                this.txtStudentId.Clear();
                this.txtFullName.Clear();
                this.txtEmail.Clear();
                this.txtAutoSearch.Clear();
    
                this.GenerateStudentEnrollmentID();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }

        private void StudentEntryInTheCourse_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                this.label6.Text = "";
                this.txtAutoSearch.Text = "";
                string sql = "select * from studentenrollment;";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from studentenrollment where studentenrollmentId like '" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtStudentId.ReadOnly = true;
                this.txtStudentId.Text = this.dgvStudent.CurrentRow.Cells["studentenrollmentId"].Value.ToString();
                this.txtFullName.Text = this.dgvStudent.CurrentRow.Cells["studentId"].Value.ToString();
                this.txtEmail.Text = this.dgvStudent.CurrentRow.Cells["courseId"].Value.ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.label6.Text = "";
            this.ClearAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql3 = "select studentenrollmentId from studentenrollment where studentId = '" + this.txtFullName.Text + "' and courseId = '" + this.txtEmail.Text + "'";
            //string sql3 = "select courseId from Course where courseId = '" + this.txtStudentId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);


            if (ds.Tables[0].Rows.Count == 0)
            {
                string sql4 = "select userId from Student where userId = '" + this.txtFullName.Text + "';";
                DataAccess da1 = new DataAccess();
                DataSet ds1 = da1.ExecuteQuery(sql4);

                if (ds1.Tables[0].Rows.Count == 1)
                {
                    string sql5 = "select courseId from Course where courseId = '" + this.txtEmail.Text + "';";
                    DataAccess da5 = new DataAccess();
                    DataSet ds5 = da5.ExecuteQuery(sql5);

                    if (ds5.Tables[0].Rows.Count == 1)
                    {
                        try
                        {
                            string sql = @"insert into studentenrollment 
                                    values('" + this.txtStudentId.Text + "','" + this.txtFullName.Text + "', '" + this.txtEmail.Text +  "');";

                            int count = this.da.ExecuteUpdateQuery(sql);
                            if (count == 1)
                            {
                                label6.Text = ("Studentenrollment: " + this.txtStudentId.Text + " Inserted Properly.");
                            }
                            else
                            {
                            
                            }
                            string sql2 = "select * from studentenrollment;";
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
                        label6.Text = ("Course ID Invalid.");
                    }
                }
                else
                {
                    label6.Text = ("Student ID Invalid.");
                }
            }
            else
            {
                label6.Text = ("Student ID: " + this.txtFullName.Text + " Already Insert In the Course ID: " + this.txtEmail.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql3 = "select studentenrollmentId from studentenrollment where studentenrollmentId = '" + this.txtStudentId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);

            if (ds.Tables[0].Rows.Count == 1)
            {
                try
                {
                    string course_id = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();
                    // string course_name = this.dgvStudent.CurrentRow.Cells["coursename"].Value.ToString();

                    string sql = @"delete from studentenrollment where studentenrollmentId = '" + course_id + "';";
                   // string sql1 = @"delete from result where studentenrollmentId = '" + course_id + "';";
                    int count = this.da.ExecuteUpdateQuery(sql);

                    if (count == 1)
                    {
                        label6.Text = ("Studentenrollment ID: " + this.txtStudentId.Text + " has been deleted.");
                    }
                    else
                    {
                        
                    }
                    string sql2 = "select * from studentenrollment;";
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
                label6.Text = ("Please Click Insert Button for Insert.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql3 = "select studentenrollmentId from studentenrollment where studentenrollmentId = '" + this.txtStudentId.Text + "';";
            DataAccess da17 = new DataAccess();
            DataSet ds17 = da17.ExecuteQuery(sql3);
            if (ds17.Tables[0].Rows.Count == 1)
            {
                string sql4 = "select userId from Student where userId = '" + this.txtFullName.Text + "';";
                DataAccess da1 = new DataAccess();
                DataSet ds1 = da1.ExecuteQuery(sql4);

                if (ds1.Tables[0].Rows.Count == 1)
                {
                    string sql5 = "select courseId from Course where courseId = '" + this.txtEmail.Text + "';";
                    DataAccess da5 = new DataAccess();
                    DataSet ds5 = da5.ExecuteQuery(sql5);

                    if (ds5.Tables[0].Rows.Count == 1)
                    {
                        string sql6 = "select studentenrollmentId from studentenrollment where studentId = '" + this.txtFullName.Text + "' and courseId = '" + this.txtEmail.Text + "'";
                        //string sql3 = "select courseId from Course where courseId = '" + this.txtStudentId.Text + "';";
                        DataAccess da6 = new DataAccess();
                        DataSet ds6 = da6.ExecuteQuery(sql6);


                        if (ds6.Tables[0].Rows.Count == 0)
                        {
                            try
                            {
                                string sql = @"update studentenrollment 
                                        set studentId = '" + this.txtFullName.Text + @"',
                                        courseId = '" + this.txtEmail.Text + @"' 
                                        where studentenrollmentId = '" + this.txtStudentId.Text + "';";
                                int count4 = this.da.ExecuteUpdateQuery(sql);

                                if (count4 == 1)
                                {
                                    label6.Text = ("Studentenrollment ID: " + this.txtStudentId.Text + " has been Updated.");
                                }
                                else
                                {
                        
                                }
                                string sql2 = "select * from studentenrollment;";
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
                            label6.Text = ("Student ID: " + this.txtFullName.Text + " Already Insert In the Course ID: " + this.txtEmail.Text);
                        }


                    }
                    else
                    {
                        label6.Text = ("Course ID Invalid.");
                    }
                }
                else
                {
                    label6.Text = ("Student ID Invalid.");
                }
            }
            else
            {
                label6.Text = ("Please Click Insert Button for Insert.");
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
