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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            showTable();
        }

        public void showTable() {

            string constr = "user id=root;server=localhost;database=webattend";
            string query = "select Name,Email,Designation,in_sts from users";
            try {
                MySqlConnection con = new MySqlConnection(constr);
                MySqlCommand cmd = new MySqlCommand(query,con);
                con.Open();
                
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;

                DataTable dbtable = new DataTable();
                sda.Fill(dbtable);

                BindingSource bsrc = new BindingSource();
                bsrc.DataSource = dbtable;
                dataGridView1.DataSource = bsrc;
                sda.Update(dbtable);

                con.Close();
            } catch (Exception ex) {
                MessageBox.Show("Error : "+ex);
;
            }

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void addmembtn_Click(object sender, EventArgs e)
        {
            new AddForm().Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            new UpdateForm().Show();
            this.Hide();
        }

        private void remobebtn_Click(object sender, EventArgs e)
        {
            new DeleteForm().Show();
            this.Hide();
        }
    }
}
