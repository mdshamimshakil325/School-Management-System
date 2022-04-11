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
    public partial class AdminPersonalInformation : Form
    {
        public string Username;
        public AdminPersonalInformation()
        {
            InitializeComponent();
        }

        private void PersonalInformationForAdmin_Load(object sender, EventArgs e)
        {
            UserId.Text = Username;


            string sql1 = "select userId from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da1 = new DataAccess();
            DataSet ds1 = da1.ExecuteQuery(sql1);
            label1.Text = ds1.Tables[0].Rows[0][0].ToString();

            string sql2 = "select fullname from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da2 = new DataAccess();
            DataSet ds2 = da2.ExecuteQuery(sql2);
            label2.Text = ds2.Tables[0].Rows[0][0].ToString();

            string sql14 = "select salary from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da14 = new DataAccess();
            DataSet ds14 = da14.ExecuteQuery(sql14);
            label5.Text = ds14.Tables[0].Rows[0][0].ToString();

            string sql3 = "select email from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da3 = new DataAccess();
            DataSet ds3 = da3.ExecuteQuery(sql3);
            label8.Text = ds3.Tables[0].Rows[0][0].ToString();

            string sql4 = "select gender from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da4 = new DataAccess();
            DataSet ds4 = da4.ExecuteQuery(sql4);
            label10.Text = ds4.Tables[0].Rows[0][0].ToString();

            string sql5 = "select FORMAT(dateofbirth,'dd-MM-yyyy') from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da5 = new DataAccess();
            DataSet ds5 = da5.ExecuteQuery(sql5);
            label12.Text = ds5.Tables[0].Rows[0][0].ToString();

            string sql6 = "select nationality from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da6 = new DataAccess();
            DataSet ds6 = da6.ExecuteQuery(sql6);
            label14.Text = ds6.Tables[0].Rows[0][0].ToString();

            string sql7 = "select religion from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da7 = new DataAccess();
            DataSet ds7 = da7.ExecuteQuery(sql7);
            label16.Text = ds7.Tables[0].Rows[0][0].ToString();

            string sql8 = "select bloodgroup from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da8 = new DataAccess();
            DataSet ds8 = da8.ExecuteQuery(sql8);
            label18.Text = ds8.Tables[0].Rows[0][0].ToString();

            string sql9 = "select fathername from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da9 = new DataAccess();
            DataSet ds9 = da9.ExecuteQuery(sql9);
            label20.Text = ds9.Tables[0].Rows[0][0].ToString();

            string sql10 = "select mothername from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da10 = new DataAccess();
            DataSet ds10 = da10.ExecuteQuery(sql10);
            label22.Text = ds10.Tables[0].Rows[0][0].ToString();

            string sql11 = "select FORMAT(joiningdate,'dd-MM-yyyy') from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da11 = new DataAccess();
            DataSet ds11 = da11.ExecuteQuery(sql11);
            label24.Text = ds11.Tables[0].Rows[0][0].ToString();

            string sql12 = "select FORMAT(leftdate,'dd-MM-yyyy') from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da12 = new DataAccess();
            DataSet ds12 = da12.ExecuteQuery(sql12);
            label26.Text = ds12.Tables[0].Rows[0][0].ToString();

            string sql13 = "select qualification from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da13 = new DataAccess();
            DataSet ds13 = da13.ExecuteQuery(sql13);
            label28.Text = ds13.Tables[0].Rows[0][0].ToString();

            string sql15 = "select presentaddress from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da15 = new DataAccess();
            DataSet ds15 = da15.ExecuteQuery(sql15);
            label30.Text = ds15.Tables[0].Rows[0][0].ToString();

            string sql16 = "select parmanentaddress from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da16 = new DataAccess();
            DataSet ds16 = da16.ExecuteQuery(sql16);
            label32.Text = ds16.Tables[0].Rows[0][0].ToString();

            string sql17 = "select contactnumber from Admin where userId = '" + this.UserId.Text + "'";
            DataAccess da17 = new DataAccess();
            DataSet ds17 = da17.ExecuteQuery(sql17);
            label34.Text = ds17.Tables[0].Rows[0][0].ToString();
        }
    }
}
