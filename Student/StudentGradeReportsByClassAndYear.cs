using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Student;

namespace WFASchoolManagementSystem.Student
{
    public partial class previousresultbyclassandyear : Form
    {
        public string Username;
        public string year;

        public previousresultbyclassandyear()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void previousresultbyclassandyear_Load(object sender, EventArgs e)
        {
            label5.Text = Username;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string sql = "select Course.courseId,Course.coursename,result.result,Course.section,Teacher.fullname from Course inner join studentenrollment on Course.courseId = studentenrollment.courseId inner join result on result.studentenrollmentId = studentenrollment.studentenrollmentId inner join Teacher on Course.teacherId = Teacher.userId where studentenrollment.studentId = '" + this.label5.Text + "' and Course.year = '" + this.textBox2.Text + "' and Course.classdescrip = '" + this.textBox1.Text + "';";
                string sql = "select Course.courseId,Course.coursename,result.result,Course.section,Teacher.fullname from Course inner join studentenrollment on Course.courseId = studentenrollment.courseId inner join result on result.studentenrollmentId = studentenrollment.studentenrollmentId inner join Teacher on Course.teacherId = Teacher.userId where studentenrollment.studentId = '" + this.label5.Text + "' and Course.year = '" + this.textBox2.Text + "' and Course.classdescrip = '" + this.textBox1.Text + "';";
                //this.PopulateGridView(sql);
                DataAccess da1 = new DataAccess();
                DataSet ds1 = da1.ExecuteQuery(sql);

                if (ds1.Tables[0].Rows.Count >= 1)
                {
                    panel2.Controls.Clear();
                    previousresultbyclassandyear1 ps1 = new previousresultbyclassandyear1();
                    ps1.Username = label5.Text;
                    ps1.year1 = textBox2.Text;
                    ps1.class1 = textBox1.Text;
                    ps1.TopLevel = false;
                    panel2.Controls.Add(ps1);
                    ps1.BringToFront();
                    ps1.Show();
                    textBox2.Text = "";
                    textBox1.Text = "";
                    label4.Text = "";
                }
                else
                {
                    label4.Text = "Not Match Class and Year.";
                    textBox2.Text = "";
                    textBox1.Text = "";
                    panel2.Controls.Clear();
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
