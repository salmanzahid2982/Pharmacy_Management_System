using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarketProject
{
    public partial class NewUser : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# project management\WIndows Application in VIsual studio\SuperMarketProject\DB\ItemsDB.mdf;Integrated Security=True;Connect Timeout=30");
        public NewUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "" || txtbox2.Text == "" || txtbox3.Text == "" || txtbox4.Text == ""||txtbx5.Text==""|| comboBox1.Text =="")
            {
                MessageBox.Show("Data Field Cannot be Empty");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Accounts(UserID,Password,FirstName,LastName,Age,Gender) Values('" + txtbox1.Text + "','" + txtbox2.Text + "','" + txtbox3.Text + "','" + txtbox4.Text + "' ,'" + txtbx5.Text + "','" + comboBox1.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Data Inserted Successfully");
            }
        }
    }
}
