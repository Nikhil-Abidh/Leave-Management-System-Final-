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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "user id=root;server=localhost;database=webattend";
            string query = "insert into users (name,email,password,designation,phone,gender,age,address) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + richTextBox1.Text + "')";
            try {
                MySqlConnection con = new MySqlConnection(constr);
                MySqlCommand cmd = new MySqlCommand(query,con);
                con.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                MessageBox.Show("User "+textBox1.Text+" is created");
                con.Close();
                new UserForm().Show();
                this.Hide();
            }
            catch (Exception ex) {
                MessageBox.Show("Error : "+ex);
            }
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new UserForm().Show();
            this.Hide();
        }
    }
}
