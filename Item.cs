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
    public partial class Item : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C# project management\WIndows Application in VIsual studio\SuperMarketProject\DB\ItemsDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Item()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void lbl6_Click(object sender, EventArgs e)
        {

        }

        private void txtbx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnitem1_Click(object sender, EventArgs e)
        {
            if (txtbx1.Text == "" || txtbx2.Text == "" || txtbx3.Text == "" || txtbx4.Text == "" || txtbx5.Text == "" || txtbx6.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data");
            }
            else
            {
                conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand("update item set ItemCode='" + txtbx1.Text + "',ItemName='" + txtbx2.Text + "',Company='" + txtbx3.Text + "',Category='" + txtbx4.Text + "' ,Price='" + txtbx5.Text + "',Stocks='" + txtbx6.Text + "' where ItemCode='" + txtbx1.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Data Successfully");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parent.Hide();
            NewItem new1 = new NewItem();
            new1.Show();
            Parent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtbx1.Text == "")
            {
                MessageBox.Show("Item Code Field Must Not Empty ");
            }
            else {
                conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete Item where ItemCode='" + txtbx1.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted successfully");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text != "" && comboBoxCategory.Text == "")
            {
                ListViewItem.Items.Clear();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                conn.Close();
                conn.Open();
                cmd.CommandText = "select * from Item Where ItemName='" + txtBoxSearch.Text + "'";
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
                    ListViewItem.Items.Add(lv);
                }
                int count = ListViewItem.Items.Count;
                MessageBox.Show("Total Items Found=" + count.ToString());
            }
 /*                                           -------From Here----
                                       --------Category Box coding----                                                                */
            else if (txtBoxSearch.Text == "" && comboBoxCategory.Text != "")
            {
                if (comboBoxCategory.SelectedItem.ToString() == "Antipyretics")
                {
                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Analgesics")
                {

                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Antimalarial")
                {

                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Antibiotics")
                {
                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Antiseptics")
                {

                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Mood Stabilizers")
                {

                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Hormone replacements")
                {

                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Oral contraceptives")
                {
                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Stimulants")
                {
                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Tranquilizers")
                {
                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else if (comboBoxCategory.SelectedItem.ToString() == "Statins")
                {
                    OnlyCategory(comboBoxCategory.SelectedItem.ToString());
                }
                else
                {
                    int x = 0;
                    x++;
                }

            }
            /*                                     ------------
                                  ---------Category Box Coding ends Here----------                                               */




            /*                                      -------------
             *                    ---------Search && Categories Section Starts Here---------                                     */
            else if (txtBoxSearch.Text == "" && comboBoxCategory.Text == "")
            {
                ListViewItem.Items.Clear();
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Antipyretics" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());  
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Analgesics" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Antimalarial" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Antibiotics" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Antiseptics" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Mood Stabilizers" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Hormone replacements" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Oral contraceptives" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Stimulants" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Tranquilizers" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Statins" && txtBoxSearch.Text != "")
            {
                SearchAndCategory(comboBoxCategory.SelectedItem.ToString());
            }
            else
            {
                int x = 3;
                x++;
            }
            /*                                      -------------
            *                    ---------Search && Categories Section Ends Here Here---------                                     */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBoxSearch.Text = "";
            comboBoxCategory.Text = "";

            if (txtBoxSearch.Text == "" && comboBoxCategory.Text == "")
            {
                ListViewItem.Items.Clear();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                conn.Close();
                conn.Open();
                cmd.CommandText = "select * from Item";
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
                    ListViewItem.Items.Add(lv);
                }
                int count = ListViewItem.Items.Count;
                MessageBox.Show("Total Items Found="+count.ToString());

            }
        }
        public void OnlyCategory(String x)
        {
            ListViewItem.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            conn.Close();
            conn.Open();
            cmd.CommandText = "select * from Item Where Category= '"+x+"'";
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
                ListViewItem.Items.Add(lv);
            }
            int count = ListViewItem.Items.Count;
            MessageBox.Show("Total Items Found=" + count.ToString());
        }
        public void SearchAndCategory(String y)
        {
            string selected = comboBoxCategory.SelectedItem.ToString();
            ListViewItem.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            conn.Close();
            conn.Open();
            cmd.CommandText = "select * from Item Where ItemName='" + txtBoxSearch.Text + "'AND Category='" + y + "'";
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
                ListViewItem.Items.Add(lv);
            }
         }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void ListViewItem_MouseClick(object sender, MouseEventArgs e)
        {
            String ItemCode = ListViewItem.SelectedItems[0].SubItems[0].Text;
            String ItemName = ListViewItem.SelectedItems[0].SubItems[1].Text;
            String Description = ListViewItem.SelectedItems[0].SubItems[2].Text;
            String Category = ListViewItem.SelectedItems[0].SubItems[3].Text;
            String Price = ListViewItem.SelectedItems[0].SubItems[4].Text;
            String Stock = ListViewItem.SelectedItems[0].SubItems[5].Text;
            txtbx1.Text = ItemCode;
            txtbx2.Text = ItemName;
            txtbx3.Text = Description;
            txtbx4.Text = Category;
            txtbx5.Text = Price;
            txtbx6.Text = Stock;

        }
    }
}
