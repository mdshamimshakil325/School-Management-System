using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Admin;

namespace WFASchoolManagementSystem.Admin
{
    public partial class AdminPasswordChange : Form
    {
        public string Username;
        public string password;

        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public AdminPasswordChange()
        {
            InitializeComponent();
            this.da = new DataAccess();

            string sql = "select * from AllUser;";
            this.PopulateGridView(sql);
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select type from AllUser where userId = '" + this.label3.Text + "' and password = '" + this.txtPassword.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    string sql1 = @"update AllUser
                                    set password = '" + this.textBox1.Text + @"'
                                    where userId = '" + this.label3.Text + "';";
                    int count = this.da.ExecuteUpdateQuery(sql1);

                    if (count == 1)
                    {
                        textBox1.Text = "";
                        txtPassword.Text = "";
                        label1.Text = "Password Changed Successfully.";
                    }
                    else
                    {
                        label1.Text = "Password Change Failed.";
                    }
                }
                else
                {
                    textBox1.Text = "";
                    txtPassword.Text = "";
                    label1.Text = "Old Password Not Match.";
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void AdminPasswordChange_Load(object sender, EventArgs e)
        {
            label3.Text = Username;
        }
    }
}
