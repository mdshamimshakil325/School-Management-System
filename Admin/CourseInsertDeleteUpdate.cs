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
    public partial class CourseInsertDeleteUpdate : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        private DataAccess da4 { get; set; }
        private DataSet ds4 { get; set; }

        public CourseInsertDeleteUpdate()
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.da4 = new DataAccess();

            string sql = "select * from Course;";
            this.PopulateGridView(sql);
            this.GenerateCourseID();
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.DataSource = this.ds.Tables[0];
        }
        private void GenerateCourseID()
        {
            try
            {
                string sql = "select * from Course order by courseId desc;";
                DataTable dt = this.da.ExecuteQueryTable(sql);
                string id = dt.Rows[0]["courseId"].ToString();
                string[] str = id.Split('C');
                int number = Convert.ToInt32(str[1]);
                string newId = "C" + (++number).ToString("d4");

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
                this.txtReligion.Clear();
                this.txtBloodGroup.Clear();
                this.txtFatherName.Clear();
                this.label6.Text = "";
                this.GenerateCourseID();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }

        private void CourseInsertDeleteUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.label6.Text = "";
            txtAutoSearch.Text = "";
            try
            {
                this.txtAutoSearch.Text = "";
                string sql = "select * from Course;";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.label6.Text = "";
            this.ClearAll();
            try
            {
                string sql = "select * from Course where courseId like '" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtAutoSearch.Text = "";
                this.txtStudentId.ReadOnly = true;
                this.txtStudentId.Text = this.dgvStudent.CurrentRow.Cells["courseId"].Value.ToString();
                this.txtFullName.Text = this.dgvStudent.CurrentRow.Cells["coursename"].Value.ToString();
                this.txtEmail.Text = this.dgvStudent.CurrentRow.Cells["classdescrip"].Value.ToString();
                this.txtReligion.Text = this.dgvStudent.CurrentRow.Cells["section"].Value.ToString();
                this.txtBloodGroup.Text = this.dgvStudent.CurrentRow.Cells["year"].Value.ToString();
                this.txtFatherName.Text = this.dgvStudent.CurrentRow.Cells["teacherId"].Value.ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql3 = "select courseId from Course where courseId = '" + this.txtStudentId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);


            if (ds.Tables[0].Rows.Count == 0)
            {
                string sql4 = "select userId from Teacher where userId = '" + this.txtFatherName.Text + "';";
                DataAccess da4 = new DataAccess();
                DataSet ds4 = da4.ExecuteQuery(sql4);


                if (ds4.Tables[0].Rows.Count == 1)
                {
                    try
                    {
                        string sql = @"insert into Course 
                                values('" + this.txtStudentId.Text + "','" + this.txtFullName.Text + "', '" + this.txtEmail.Text + "', '" + this.txtReligion.Text + "', '" + this.txtBloodGroup.Text + "', '" + this.txtFatherName.Text + "');";

                        int count = this.da.ExecuteUpdateQuery(sql);
                        if (count == 1)
                        {
                            label6.Text = ("Course ID: " + this.txtStudentId.Text + " Inserted Properly.");
                        }
                        else
                        {
                        
                        }
                        string sql2 = "select * from Course;";
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
                    label6.Text = ("Teacher ID Invalid.");
                }
            }
            else
            {
                label6.Text = ("Course ID: " + this.txtStudentId.Text + " Already Insert.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql3 = "select courseId from Course where courseId = '" + this.txtStudentId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);

            if (ds.Tables[0].Rows.Count == 1)
            {
                try
                {
                    string course_id = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();

                    string sql = @"delete from Course where courseId = '" + course_id + "';";
                    int count = this.da.ExecuteUpdateQuery(sql);

                    if (count == 1)
                    {
                        label6.Text = ("Course ID: " + this.txtStudentId.Text + " has been deleted.");
                    }
                    else
                    {
                        
                    }
                    string sql2 = "select * from Course;";
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
            string sql3 = "select courseId from Course where courseId = '" + this.txtStudentId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);

            if (ds.Tables[0].Rows.Count == 1)
            {
                string sql4 = "select userId from Teacher where userId = '" + this.txtFatherName.Text + "';";
                DataAccess da4 = new DataAccess();
                DataSet ds4 = da4.ExecuteQuery(sql4);

                if (ds4.Tables[0].Rows.Count == 1)
                {
                    try
                    {
                        string sql = @"update Course 
                                    set coursename = '" + this.txtFullName.Text + @"',
                                    classdescrip = '" + this.txtEmail.Text + @"',
                                    section = '" + this.txtReligion.Text + @"' ,
                                    year = '" + this.txtBloodGroup.Text + @"' ,
                                    teacherId = '" + this.txtFatherName.Text + @"' 
                                    where courseId = '" + this.txtStudentId.Text + "';";
                        //int count7 = this.da.ExecuteUpdateQuery(sql);

                        //if (count7 == 1)
                        //{
                        //    //label6.Text = ("Course ID: " + this.txtStudentId.Text + " has been Updated.");
                        //    label6.Text = ("Course ID: " + this.txtStudentId.Text + " has been Updated.");
                        //}
                        //else
                        //{
                        
                        //}
                        //string sql2 = "select * from Course order by courseId desc;";
                        //this.PopulateGridView(sql2);
                        //this.ClearAll();

                        int count4 = this.da.ExecuteUpdateQuery(sql);

                        if (count4 == 1)
                        {
                            label6.Text = ("Course ID: " + this.txtStudentId.Text + " has been Updated.");
                        }
                        else
                        {

                        }
                        string sql2 = "select * from Course;";
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
                    label6.Text = ("Teacher ID Invalid.");
                }
            }
            else
            {
                label6.Text = ("Please Click Insert Button for Insert.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Text = "";
            this.label6.Text = "";
            this.ClearAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
