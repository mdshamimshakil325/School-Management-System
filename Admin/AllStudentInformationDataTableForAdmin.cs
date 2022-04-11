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
    public partial class AllStudentInformationDataTableForAdmin : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public AllStudentInformationDataTableForAdmin()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from Student;";
            this.PopulateGridView(sql);
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.DataSource = this.ds.Tables[0];
        }

        private void AllStudentInformationDataTableForAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                string sql = "select * from Student;";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Student where userId like '" + this.textBox1.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
    }
}
