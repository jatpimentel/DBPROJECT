using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJECT
{
    public partial class frmUserProfile : Form
    {
        long iduser;
        String loginname;
        public frmUserProfile(long liduser, String lname)
        {
            InitializeComponent();
            this.iduser = liduser;
            this.loginname = lname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.frmUserProfile_LoadUserData();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChangePasswordfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangePasswordfrm.Dispose();
        }


        private frmChangePassword ChangePasswordfrm;
        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm = new frmChangePassword(this.iduser, this.loginname);
            ChangePasswordfrm.FormClosed += ChangePasswordfrm_FormClosed;

            ChangePasswordfrm.ShowDialog();
        }

        private void frmUserProfile_LoadUserData()
        {
       //     String uname = "", uemail = "", ugender = "MALE", usmtphost = "", usmtpport = "";
        //    DateTime ubirthdate = Convert.ToDateTime("01/01/1900");

            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("select photo from users where iduser=@liduser", Globals.sqlconn);
                cmd.Parameters.AddWithValue("@lidUser", this.iduser);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                int rowcount = dt.Rows.Count;

                if (rowcount == 0)
                {
                    csMessageBox.Show("Invalid User Id", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(dt.Rows != null)
                    {
                        byte[] UserImg = (byte[])dt.Rows[0][0];
                        MemoryStream imgstream = new MemoryStream(UserImg);

                        if (imgstream.Length > 0)
                            this.picBoxUser.Image = Image.FromStream(imgstream);
                    }
                    da.Dispose();
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (csMessageBox.Show("Erase User Photo?", "Please confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(Globals.glOpenSqlConn())
                {
                    SqlCommand cmd = new SqlCommand("spGetUserProfile", Globals.sqlconn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@liduser", this.iduser);
                    cmd.ExecuteNonQuery();

                    this.picBoxUser.Image = null;
                }
                csMessageBox.Show("User Photo Erased", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}