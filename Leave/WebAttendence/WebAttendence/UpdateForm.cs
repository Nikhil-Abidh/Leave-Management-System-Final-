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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            comboBox3.Hide();
            comboBox4.Hide();
            valuetext.Hide();
            button1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new UserForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = comboBox2.Text;
            
            string query = "";
            if (item.Equals("Name"))
            {
                idtext.Show();
                label4.Show();
                query = "update users set name='" + valuetext.Text + "' where  id='" + idtext.Text + "' ";
            }
            else if (item.Equals("Email"))
            {
                query = "update users set email='" + valuetext.Text + "' where  id='" + idtext.Text + "' ";
                idtext.Show();
                label4.Show();
            }
            else if (item.Equals("Age"))
            {
                query = "update users set age='" + valuetext.Text + "' where  id='" + idtext.Text + "' ";
                idtext.Show();
                label4.Show();
            }
            else if (item.Equals("Password"))
            {
                query = "update users set password='" + valuetext.Text + "' where  id='" + idtext.Text + "' ";
                idtext.Show();
                label4.Show();
            }
            else if (item.Equals("Address"))
            {
                query = "update users set address='" + valuetext.Text + "' where  id='" + idtext.Text + "' ";
                idtext.Show();
                label4.Show();
            }
            else if (item.Equals("Designation"))
            {
                query = "update users set designation='" + comboBox3.Text + "' where  id='" + idtext.Text + "' ";
                comboBox3.Show();
                label2.Show();
            }
            else if (item.Equals("Gender"))
            {
                query = "update users set gender='" + comboBox4.Text + "' where  id='" + idtext.Text + "' ";
                comboBox4.Show();
                label3.Show();
            }
            else if (item.Equals("Phone Number"))
            {
                query = "update users set phone='" + valuetext.Text + "' where  id='" + idtext.Text + "' ";
                idtext.Show();
                label4.Show();
            }

            string constr = "user id=root;server=localhost;database=webattend";
            try
            {
                MySqlConnection con = new MySqlConnection(constr);
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                MessageBox.Show("User information updated");
                con.Close();
                new UserForm().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            
        }
    }
}
