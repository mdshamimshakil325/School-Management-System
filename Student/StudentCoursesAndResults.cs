using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Information;
using WFASchoolManagementSystem.Student;

namespace WFASchoolManagementSystem.Student
{
    public partial class courseresult : Form
    {
        public string Username;

        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public courseresult()
        {
            InitializeComponent();
            this.da = new DataAccess();

        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.DataSource = this.ds.Tables[0];
        }

        private void courseresult_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            label39.Text = (dt1.ToString("yyyy"));
            label1.Text = Username;
            label3.Text = "0";
            for (int i = 0; i < dgvAdmin.Rows.Count; i++)
            {
                label3.Text = Convert.ToString(double.Parse(label3.Text) + double.Parse(dgvAdmin.Rows[i].Cells[2].Value.ToString()));
            }
            label4.Text = ds.Tables[0].Rows.Count.ToString();
            double firstnumber = Convert.ToDouble(label3.Text);
            double secondnumber = Convert.ToDouble(label4.Text);
            double result = firstnumber / secondnumber;
            label5.Text = Math.Round(result, 2, MidpointRounding.ToEven).ToString();


        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select Course.courseId,Course.coursename,result.result,Course.section,Teacher.fullname from Course inner join studentenrollment on Course.courseId = studentenrollment.courseId inner join result on result.studentenrollmentId = studentenrollment.studentenrollmentId inner join Teacher on Course.teacherId = Teacher.userId where studentenrollment.studentId = '" + this.label1.Text + "'and Course.year = '" + this.label39.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
