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
    public partial class UserAccountInsertDeleteUpdate : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }


        public UserAccountInsertDeleteUpdate()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from AllUser;";
            this.PopulateGridView(sql);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvAlluser.AutoGenerateColumns = false;
            this.dgvAlluser.DataSource = this.ds.Tables[0];
        }

        private void ClearAll()
        {
            this.txtUserID.Clear();
            this.txtUserID.ReadOnly = false;
            this.txtPassword.Clear();
            this.cmbType.SelectedIndex = -1;
        }

        private void btnAlluser_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.label6.Text = "";
            txtAutoSearch.Text = "";
            string sql = "select * from AllUser;";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Text = "";
            this.label6.Text = "";
            this.ClearAll();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            //string sql = "select * from AllUser where type = '" + this.comboBoxSearch.Text + "';";
            //this.PopulateGridView(this.sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql3 = "select userId from AllUser where userId = '" + this.txtUserID.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);


            if (ds.Tables[0].Rows.Count == 0)
            {
                if (this.txtUserID.Text != "")
                {
                    try
                    {
                        string sql = @"insert into AllUser 
                                values('" + this.txtUserID.Text + "', '" + this.txtPassword.Text + "', '" + this.cmbType.Text + "');";


                        int count = this.da.ExecuteUpdateQuery(sql);
                        if (count == 1)
                        {
                            label6.Text = ("User ID: " + this.txtUserID.Text + " Inserted Properly.");
                        }
                        else
                        {   
                       
                        }
                        string sql2 = "select * from AllUser;";
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
                    label6.Text = ("User ID Empty.");
                }
            }
            else
            {
                label6.Text = ("User ID: " + this.txtUserID.Text + " Already Insert.");
            }
        }

        private void PasswordIssu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.label6.Text = "";
            this.ClearAll();
            string sql = "select * from AllUser where type like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql3 = "select userId from AllUser where userId = '" + this.txtUserID.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);

            if (ds.Tables[0].Rows.Count == 1)
            {
                try
                {
                    string userid = this.dgvAlluser.CurrentRow.Cells[0].Value.ToString();


                    string sql = @"delete from AllUser where userId = '" + userid + "';";
                    int count = this.da.ExecuteUpdateQuery(sql);

                    if (count == 1)
                    {
                        label6.Text = ("User ID: " + this.txtUserID.Text + " has been deleted.");
                    }
                    else
                    {
                        
                    }
                    string sql2 = "select * from AllUser;";
                    this.PopulateGridView(sql2);
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

        private void dgvAlluser_DoubleClick(object sender, EventArgs e)
        {
            this.label6.Text = "";
            this.txtUserID.Text = this.dgvAlluser.CurrentRow.Cells["userId"].Value.ToString();
            this.cmbType.Text = this.dgvAlluser.CurrentRow.Cells["type"].Value.ToString();
            this.txtPassword.Text = this.dgvAlluser.CurrentRow.Cells["password"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql3 = "select userId from AllUser where userId = '" + this.txtUserID.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql3);


            if (ds.Tables[0].Rows.Count == 1)
            {
                try
                {
                    string sql = @"update AllUser
                            set password = '" + this.txtPassword.Text + @"',
                            type = '" + this.cmbType.Text + @"'
                            where userId = '" + this.txtUserID.Text + "';";
                    int count = this.da.ExecuteUpdateQuery(sql);

                    if (count == 1)
                    {
                        label6.Text = ("User ID: " + this.txtUserID.Text + " has been Updated.");
                    }
                    else
                    {
                        
                    }
                    string sql2 = "select * from AllUser;";
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

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelPasswordAU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvAlluser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
