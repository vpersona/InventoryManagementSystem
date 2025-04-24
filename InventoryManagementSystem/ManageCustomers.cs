using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\InventoryDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + CustomerIdTb.Text + "','" + CustomerNameTb.Text + "','" +CustomerPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustomerIdTb.Text == "")
            {
                MessageBox.Show("Enter The Customers Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTbl where CustId ='" + CustomerIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");

                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName = '" + CustomerNameTb.Text + "', CustPhone = '" + CustomerPhoneTb.Text + "'where CustId = '" + CustomerIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // check if you clicked on the right place
            {
                DataGridViewRow row = CustomersGV.Rows[e.RowIndex];

                if (row.Cells.Count >= 3) // check if there is enough data
                {
                    CustomerIdTb.Text = row.Cells[0].Value?.ToString();
                    CustomerNameTb.Text = row.Cells[1].Value?.ToString();
                    CustomerPhoneTb.Text = row.Cells[2].Value?.ToString();
                   
                }
            }

            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count (*) from OrdersTbl where CustId = "+CustomerIdTb.Text+"",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderLabel.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum (TotalAmt) from OrdersTbl where CustId = " + CustomerIdTb.Text + "", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLabel.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from OrdersTbl where CustId = " + CustomerIdTb.Text + "", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DateLabel.Text = dt2.Rows[0][0].ToString();

            Con.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm hm = new HomeForm();
            hm.Show();
            this.Hide();
        }
    }
}
