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

namespace WFASchoolManagementSystem.Information
{
    public partial class formStudentInindividualInfo : Form
    {
        public string Username;
        public string password;
        public double result1;
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        private DataAccess da40 { get; set; }
        private DataSet ds40 { get; set; }

        public formStudentInindividualInfo()
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.da40 = new DataAccess();
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            //this.dgvStudent.AutoGenerateColumns = false;
           // this.dgvStudent.DataSource = this.ds.Tables[0];
        }
        private void PopulateGridView1(string sql40)
        {
            this.ds40 = this.da40.ExecuteQuery(sql40);
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.DataSource = this.ds40.Tables[0];
        }

        private void formStudentInindividualInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void formStudentInindividualInfo_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            label39.Text = (dt1.ToString("yyyy"));
            UserId.Text = Username;
            UserPassword.Text = password;

            


            string sql = "select * from Student where userId = '" + this.UserId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
            this.PopulateGridView(sql);

            string sql1 = "select userId from student where userId = '" + this.UserId.Text + "'";
            DataAccess da1 = new DataAccess();
            DataSet ds1 = da1.ExecuteQuery(sql1);
            label1.Text = ds1.Tables[0].Rows[0][0].ToString();

            string sql2 = "select fullname from student where userId = '" + this.UserId.Text + "'";
            DataAccess da2 = new DataAccess();
            DataSet ds2 = da2.ExecuteQuery(sql2);
            label2.Text = ds2.Tables[0].Rows[0][0].ToString();

            label37.Text = "0";
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                label37.Text = Convert.ToString(double.Parse(label37.Text) + double.Parse(dgvStudent.Rows[i].Cells[0].Value.ToString()));
            }
            label38.Text = ds40.Tables[0].Rows.Count.ToString();
            double firstnumber = Convert.ToDouble(label37.Text);
            double secondnumber = Convert.ToDouble(label38.Text);
            double result = firstnumber / secondnumber;
            label5.Text = Math.Round(result, 2, MidpointRounding.ToEven).ToString();

            string sql14 = "select result from student where userId = '" + this.UserId.Text + "'";
            DataAccess da14 = new DataAccess();
            DataSet ds14 = da14.ExecuteQuery(sql14);
        

            string sql3 = "select email from student where userId = '" + this.UserId.Text + "'";
            DataAccess da3 = new DataAccess();
            DataSet ds3 = da3.ExecuteQuery(sql3);
            label8.Text = ds3.Tables[0].Rows[0][0].ToString();

            string sql4 = "select gender from student where userId = '" + this.UserId.Text + "'";
            DataAccess da4 = new DataAccess();
            DataSet ds4 = da4.ExecuteQuery(sql4);
            label10.Text = ds4.Tables[0].Rows[0][0].ToString();

            string sql5 = "select FORMAT(dateofbirth,'dd-MM-yyyy') from student where userId = '" + this.UserId.Text + "'";
            DataAccess da5 = new DataAccess();
            DataSet ds5 = da5.ExecuteQuery(sql5);
            label12.Text = ds5.Tables[0].Rows[0][0].ToString();

            string sql6 = "select nationality from student where userId = '" + this.UserId.Text + "'";
            DataAccess da6 = new DataAccess();
            DataSet ds6 = da6.ExecuteQuery(sql6);
            label14.Text = ds6.Tables[0].Rows[0][0].ToString();

            string sql7 = "select religion from student where userId = '" + this.UserId.Text + "'";
            DataAccess da7 = new DataAccess();
            DataSet ds7 = da7.ExecuteQuery(sql7);
            label16.Text = ds7.Tables[0].Rows[0][0].ToString();

            string sql8 = "select bloodgroup from student where userId = '" + this.UserId.Text + "'";
            DataAccess da8 = new DataAccess();
            DataSet ds8 = da8.ExecuteQuery(sql8);
            label18.Text = ds8.Tables[0].Rows[0][0].ToString();

            string sql9 = "select fathername from student where userId = '" + this.UserId.Text + "'";
            DataAccess da9 = new DataAccess();
            DataSet ds9 = da9.ExecuteQuery(sql9);
            label20.Text = ds9.Tables[0].Rows[0][0].ToString();

            string sql10 = "select mothername from student where userId = '" + this.UserId.Text + "'";
            DataAccess da10 = new DataAccess();
            DataSet ds10 = da10.ExecuteQuery(sql10);
            label22.Text = ds10.Tables[0].Rows[0][0].ToString();

            string sql11 = "select FORMAT(admissiondate,'dd-MM-yyyy') from student where userId = '" + this.UserId.Text + "'";
            DataAccess da11 = new DataAccess();
            DataSet ds11 = da11.ExecuteQuery(sql11);
            label24.Text = ds11.Tables[0].Rows[0][0].ToString();

            string sql12 = "select FORMAT(graduationdate,'dd-MM-yyyy') from student where userId = '" + this.UserId.Text + "'";
            DataAccess da12 = new DataAccess();
            DataSet ds12 = da12.ExecuteQuery(sql12);
            label26.Text = ds12.Tables[0].Rows[0][0].ToString();

            string sql13 = "select paymentstatus from student where userId = '" + this.UserId.Text + "'";
            DataAccess da13 = new DataAccess();
            DataSet ds13 = da13.ExecuteQuery(sql13);
            label28.Text = ds13.Tables[0].Rows[0][0].ToString();

            string sql15 = "select presentaddress from student where userId = '" + this.UserId.Text + "'";
            DataAccess da15 = new DataAccess();
            DataSet ds15 = da15.ExecuteQuery(sql15);
            label30.Text = ds15.Tables[0].Rows[0][0].ToString();

            string sql16 = "select parmanentaddress from student where userId = '" + this.UserId.Text + "'";
            DataAccess da16 = new DataAccess();
            DataSet ds16 = da16.ExecuteQuery(sql16);
            label32.Text = ds16.Tables[0].Rows[0][0].ToString();

            string sql17 = "select contactnumber from student where userId = '" + this.UserId.Text + "'";
            DataAccess da17 = new DataAccess();
            DataSet ds17 = da17.ExecuteQuery(sql17);
            label34.Text = ds17.Tables[0].Rows[0][0].ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
        private void label39_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void UserId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql40 = "select Course.courseId,Course.coursename,result.result from Course inner join studentenrollment on Course.courseId = studentenrollment.courseId inner join result on result.studentenrollmentId = studentenrollment.studentenrollmentId  where studentenrollment.studentId = '" + this.UserId.Text + "' and Course.year = '" + this.label39.Text + "';";
                this.PopulateGridView1(sql40);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }


    }
}
