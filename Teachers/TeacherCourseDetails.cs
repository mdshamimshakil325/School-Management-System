using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Teachers
{
    public partial class TeacherCourseDetails : Form
    {
        public string Username;
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public TeacherCourseDetails()
        {
            InitializeComponent();
            this.da = new DataAccess();

           // string sql = "select * from Course";
           // this.PopulateGridView(sql);
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.DataSource = this.ds.Tables[0];
        }

        private void coursedetails_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            label39.Text = (dt1.ToString("yyyy"));
            label1.Text = Username;
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Course where teacherId = '" + this.label1.Text + "'and year = '" + this.label39.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
