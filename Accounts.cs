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
    public partial class Accounts : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# project management\WIndows Application in VIsual studio\SuperMarketProject\DB\ItemsDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Accounts()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            NewUser obj = new NewUser();
            obj.Show();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtboxSearch.Text == "")
            {
                ListViewItem.Items.Clear();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                conn.Close();
                conn.Open();
                cmd.CommandText = "select ID,UserID,Password,FirstName,LastName,Age,Gender from Accounts";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lv.SubItems.Add(dr[4].ToString());
                    lv.SubItems.Add(dr[5].ToString());
                    lv.SubItems.Add(dr[6].ToString());
                    ListViewItem.Items.Add(lv);
                }
            }
            else if (txtboxSearch.Text != "")
            {
                ListViewItem.Items.Clear();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                conn.Close();
                conn.Open();
                cmd.CommandText = "select ID,UserID,Password,FirstName,LastName,Age,Gender from Accounts where UserId='" + txtboxSearch.Text + "'";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lv.SubItems.Add(dr[4].ToString());
                    lv.SubItems.Add(dr[5].ToString());
                    lv.SubItems.Add(dr[6].ToString());
                    ListViewItem.Items.Add(lv);
                    
                }
            }
            else
            {
                int x = 3;
                x++;
            }
        
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (txtbx1.Text == "" || txtbx2.Text == "" || txtbx3.Text == "" || txtbx4.Text == "" || txtbx5.Text == "" || txtbx6.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data");
            }
            else
            {
                conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Accounts set UserID='"+txtbx1.Text+"',Password='"+txtbx2.Text+ "',Password='" + txtbx2.Text + "',FirstName='" + txtbx3.Text + "',LastName='" + txtbx4.Text + "',Age='" + txtbx5.Text + "',Gender='" + txtbx6.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Data Successfully");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void ListViewItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewItem_MouseClick(object sender, MouseEventArgs e)
        {
            String UserId =ListViewItem.SelectedItems[0].SubItems[0].Text;
            String Password = ListViewItem.SelectedItems[0].SubItems[1].Text;
            String FirstName = ListViewItem.SelectedItems[0].SubItems[2].Text;
            String LastName = ListViewItem.SelectedItems[0].SubItems[3].Text;
            String Age = ListViewItem.SelectedItems[0].SubItems[4].Text;
            String Gender = ListViewItem.SelectedItems[0].SubItems[5].Text;
            txtbx1.Text = UserId;
            txtbx2.Text = Password;
            txtbx3.Text = FirstName;
            txtbx4.Text = LastName;
            txtbx5.Text = Gender;
            txtbx6.Text = Age;



        }

        private void txtbx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Accounts_Load(object sender, EventArgs e)
        {

        }
    }
}
