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
    public partial class StudentEntryInTheResultSheet : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public StudentEntryInTheResultSheet()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from result;";
            this.PopulateGridView(sql);
            this.GenerateresultID();
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.DataSource = this.ds.Tables[0];
        }
        private void GenerateresultID()
        {
            try
            {
                string sql = "select * from result order by resultId desc;";
                DataTable dt = this.da.ExecuteQueryTable(sql);
                string id = dt.Rows[0]["resultId"].ToString();
                string[] str = id.Split('R');
                int number = Convert.ToInt32(str[1]);
                string newId = "R" + (++number).ToString("d4");

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
                this.GenerateresultID();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }

        private void StudentEntryInTheResultSheet_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtAutoSearch.Text = "";
                string sql = "select * from result;";
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
                string sql = "select * from result where resultId like '" + this.txtAutoSearch.Text + "%';";
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
                this.txtStudentId.Text = this.dgvStudent.CurrentRow.Cells["resultId"].Value.ToString();
                this.txtFullName.Text = this.dgvStudent.CurrentRow.Cells["studentenrollmentId"].Value.ToString();
                this.txtEmail.Text = this.dgvStudent.CurrentRow.Cells["result"].Value.ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                this.ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql3 = "select resultId from result where resultId = '" + this.txtStudentId.Text + "';";
            DataAccess da17 = new DataAccess();
            DataSet ds17 = da17.ExecuteQuery(sql3);
            if (ds17.Tables[0].Rows.Count == 1)
            {
                string sql4 = "select studentenrollmentId from studentenrollment where studentenrollmentId = '" + this.txtFullName.Text + "';";
                DataAccess da18 = new DataAccess();
                DataSet ds18 = da18.ExecuteQuery(sql4);
                if (ds18.Tables[0].Rows.Count == 1)
                {
                    try
                    {
                        string sql = @"update result 
                                     set studentenrollmentId = '" + this.txtFullName.Text + @"',
                                     result = '" + this.txtEmail.Text + @"' 
                                     where resultId = '" + this.txtStudentId.Text + "';";
                        int count4 = this.da.ExecuteUpdateQuery(sql);

                        if (count4 == 1)
                        {
                            label6.Text = ("Result ID: " + this.txtStudentId.Text + " has been Updated.");
                        }
                        else
                        {
                            
                        }
                        string sql2 = "select * from result;";
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
                    label6.Text = ("Studentenrollment ID Invalid.");
                }
            }
            else
            {
                label6.Text = ("Please Click Insert Button for Insert.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql3 = "select studentenrollmentId from result where studentenrollmentId = '" + this.txtFullName.Text + "';";
            DataAccess da17 = new DataAccess();
            DataSet ds17 = da17.ExecuteQuery(sql3);
            if (ds17.Tables[0].Rows.Count == 1)
            {
                try
                {
                    string course_id = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();

                    //string sql = @"delete from studentenrollment where studentenrollmentId = '" + course_id + "';";
                    string sql1 = @"delete from result where resultId = '" + course_id + "';";
                    int count = this.da.ExecuteUpdateQuery(sql1);

                    if (count == 1)
                    {
                        label6.Text = ("Result ID: " + this.txtStudentId.Text + " has been deleted.");
                    }
                    else
                    {
                      
                    }
                    string sql2 = "select * from result;";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sql3 = "select resultId from result where resultId = '" + this.txtStudentId.Text + "'";
            //string sql3 = "select courseId from Course where courseId = '" + this.txtStudentId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);


            if (ds.Tables[0].Rows.Count == 0)
            {
                string sql5 = "select studentenrollmentId from studentenrollment where studentenrollmentId = '" + this.txtFullName.Text + "';";
                DataAccess da5 = new DataAccess();
                DataSet ds5 = da5.ExecuteQuery(sql5);

                if (ds5.Tables[0].Rows.Count == 1)
                {
                    string sql6 = "select studentenrollmentId from result where studentenrollmentId = '" + this.txtFullName.Text + "';";
                    DataAccess da17 = new DataAccess();
                    DataSet ds17 = da17.ExecuteQuery(sql6);
                    if (ds17.Tables[0].Rows.Count == 0)
                    {

                        try
                        {
                            string sql = @"insert into result 
                                        values('" + this.txtStudentId.Text + "','" + this.txtFullName.Text + "', '" + this.txtEmail.Text + "');";

                            int count = this.da.ExecuteUpdateQuery(sql);
                            if (count == 1)
                            {
                                label6.Text = ("Studentenrollment: " + this.txtStudentId.Text + " Inserted Properly.");
                            }
                            else
                            {

                            }
                            string sql2 = "select * from result;";
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
                        label6.Text = ("Result ID: " + this.txtFullName.Text + " Already Insert.");
                    }
                }
                else
                {
                    label6.Text = ("Studentenrollment ID Invalid.");
                }

            }
            else
            {
                label6.Text = ("Result ID: " + this.txtFullName.Text + " Already Insert For the Studentenrollment ID: " + this.txtEmail.Text);
            }
        }
    }
}
