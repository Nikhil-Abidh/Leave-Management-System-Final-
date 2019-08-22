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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new UserForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "user id=root;server=localhost;database=webattend";
            string query = "delete from users where id='"+textBox1.Text+"' ";
            try
            {
                MySqlConnection con = new MySqlConnection(constr);
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader rd = cmd.ExecuteReader();
                MessageBox.Show("User infromation is Deleted");
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
