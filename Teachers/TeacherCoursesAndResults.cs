using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Teachers;

namespace WFASchoolManagementSystem.Student
{
    public partial class Resultinfo : Form
    {
        public string Username;
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public Resultinfo()
        {
            InitializeComponent();
            this.da = new DataAccess();

          //  string sql = "select * from Course where teacherId like '" + this.label4.Text + "%';"; 
          //  this.PopulateGridView(sql);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvResult.AutoGenerateColumns = false;
            this.dgvResult.DataSource = this.ds.Tables[0];
            
        }

        private void ClearAll()
        {
            this.txtStudentId.Clear();
            this.txtStudentId.ReadOnly = false;
        }

        private void btnAlluser_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Course where teacherId like '" + this.label4.Text + "%';";
                this.PopulateGridView(sql);
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

        private void Resultinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

  

        private void dgvResult_DoubleClick(object sender, EventArgs e)
        {
            //this.txtStudentId.ReadOnly = true;
           // this.textBox1.ReadOnly = true;
          //  this.textBox2.ReadOnly = true;
          //  this.textBox3.ReadOnly = true;
            this.txtStudentId.Text = this.dgvResult.CurrentRow.Cells["courseId"].Value.ToString();
            this.label7.Text = this.dgvResult.CurrentRow.Cells["coursename"].Value.ToString();
            this.label8.Text = this.dgvResult.CurrentRow.Cells["classdescrip"].Value.ToString();
            this.label9.Text = this.dgvResult.CurrentRow.Cells["section"].Value.ToString();
            //this.txtResult.Text = this.dgvResult.CurrentRow.Cells["teacherId"].Value.ToString();
        }



        private void Resultinfo_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            label39.Text = (dt1.ToString("yyyy"));
            label4.Text = Username;

        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Course where teacherId = '" + this.label4.Text + "' and year = '" + this.label39.Text + "';";
            this.PopulateGridView(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Resultinfo1 sd1 = new Resultinfo1();
            sd1.Username = this.txtStudentId.Text;
            sd1.TopLevel = false;
            panel2.Controls.Add(sd1);
            sd1.BringToFront();
            sd1.Show();
            panel1.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Visible = true;
        }

        private void panelPasswordAU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
