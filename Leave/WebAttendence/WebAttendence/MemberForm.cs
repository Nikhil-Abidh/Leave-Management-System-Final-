using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAttendence
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
            fillData();
        }

        public void fillData() {
            string constr = "user id=root;server=localhost;database=webattend";
            string query = "select Name,Email,Designation,in_sts from users";
            try
            {
                MySqlConnection con = new MySqlConnection(constr);
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    label2.Text = rd.GetString("name");
                    label3.Text = rd.GetString("designation");
                    label5.Text = rd.GetString("age");
                    label7.Text = rd.GetString("gender");
                    label9.Text = rd.GetString("email");
                    label11.Text = rd.GetString("password");
                    label13.Text = rd.GetString("address");
                    label15.Text = rd.GetString("phone");
                    if (rd.GetByte("image").Equals("null"))
                        pictureBox1.Text = "Null";
                    else {
                        byte[] img = (byte[])rd["image"];
                        if (img == null)
                            pictureBox1.Image = null;
                        else
                        {
                            MemoryStream mst = new MemoryStream(img);
                            pictureBox1.Image = System.Drawing.Image.FromStream(mst);
                        }
                    }
                    }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
                ;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UpdateForm().Show();
            this.Hide();
        }
    }
}
