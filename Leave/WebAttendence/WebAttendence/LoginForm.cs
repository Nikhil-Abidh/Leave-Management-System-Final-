using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAttendence
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            Boolean flag = false;
            string constr = "user id=root;server=localhost;database=webattend";
            string query = "select * from users where email='"+mailtext.Text+"' and password='"+pwtext.Text+"' ";
            try {
                MySqlConnection con = new MySqlConnection(constr);
                MySqlCommand cmd = new MySqlCommand(query,con);
                con.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read()) {
                    count++;
                    string des = rd.GetString("Designation");
                    if (des.Equals("Admin"))
                        flag = true;
                }
                if (count == 1 && flag == true)
                {
                    new UserForm().Show();
                    this.Hide();
                }
                else
                {
                    new MemberForm().Show();
                    this.Hide();
                }

                con.Close();
            } catch (Exception ex) {
                MessageBox.Show("Error : "+ex);
            }

        }
    }
}
