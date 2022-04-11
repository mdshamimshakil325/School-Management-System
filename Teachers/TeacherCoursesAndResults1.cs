using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Student
{
    public partial class Resultinfo1 : Form
    {
        public string Username;
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public Resultinfo1()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }
        private void ClearAll()
        {
          //  this.txtStudentId.Clear();
           // this.txtStudentId.ReadOnly = false;
            this.txtResult.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.DataSource = this.ds.Tables[0];
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select studentenrollment.studentId,result.result,result.resultid from studentenrollment inner join result on studentenrollment.studentenrollmentId = result.studentenrollmentId where studentenrollment.courseId = '" + this.label1.Text + "'";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void Resultinfo1_Load(object sender, EventArgs e)
        {
            label1.Text = Username;
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //string sql = "select * from Student where userId like '" + this.txtAutoSearch.Text + "%';";
                string sql = "select studentenrollment.studentId,result.result,result.resultid from studentenrollment inner join result on studentenrollment.studentenrollmentId = result.studentenrollmentId where studentenrollment.studentId like '" + this.txtAutoSearch.Text + "%' and studentenrollment.courseId like '" + this.label1.Text + "%';";

                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvAdmin_DoubleClick(object sender, EventArgs e)
        {
            //this.txtResult.ReadOnly = true;
            this.txtResult.Text = this.dgvAdmin.CurrentRow.Cells["result"].Value.ToString();
            this.textBox1.ReadOnly = true;
            this.textBox1.Text = this.dgvAdmin.CurrentRow.Cells["studentId"].Value.ToString();
            this.textBox2.ReadOnly = true;
            this.textBox2.Text = this.dgvAdmin.CurrentRow.Cells["resultId"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                txtAutoSearch.Text = "";
                string sql = @"update result set result = " + this.txtResult.Text + @" where resultId = '" + this.textBox2.Text + "';";


                int count = this.da.ExecuteUpdateQuery(sql);

                if (count == 1)
                {
                   // MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data Update Failed");
                }
                string sql2 = "select studentenrollment.studentId,result.result,result.resultid from studentenrollment inner join result on studentenrollment.studentenrollmentId = result.studentenrollmentId where studentenrollment.courseId = '" + this.label1.Text + "'";
                this.PopulateGridView(sql2);
                txtResult.Text = "";
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txtAutoSearch.Text = "";
            txtResult.Text = "";
            //this.ClearAll();
        }

        private void btnAlluser_Click(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = "";
                txtAutoSearch.Text = "";
                txtResult.Text = "";
                string sql = "select studentenrollment.studentId,result.result,result.resultid from studentenrollment inner join result on studentenrollment.studentenrollmentId = result.studentenrollmentId where studentenrollment.courseId = '" + this.label1.Text + "'";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }
    }
}
