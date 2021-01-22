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
    public partial class NewItem : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# project management\WIndows Application in VIsual studio\SuperMarketProject\DB\ItemsDB.mdf;Integrated Security=True;Connect Timeout=30");
        public NewItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewItem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( txtbx2.Text == "" || txtbx3.Text == "" || txtbx4.Text == "" || txtbx5.Text == "" || txtbx6.Text == "")
            {
                MessageBox.Show("Data Field Cannot be Empty");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Item(ItemName,Company,Category,Price,Stocks) Values('" + txtbx2.Text + "','" + txtbx3.Text + "','" + txtbx4.Text + "' ,'" + txtbx5.Text + "','" + txtbx6.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Data Successfully");
            }
        }

        private void txtbx1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
