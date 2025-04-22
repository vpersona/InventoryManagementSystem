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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\InventoryDb.mdf;Integrated Security=True;Connect Timeout=30");

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
        void populateProducts()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        void FillCategory()
        {
            string query = "select * from CategoryTb";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);      
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        int num = 0;
        int uprice, totprice, qty;
        string product;
        int flag = 0;

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProducts();
            FillCategory();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = CustomersGV.Rows[e.RowIndex];
            CustomerIdTb.Text = row.Cells[0].Value?.ToString();
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
            product = row.Cells[0].Value.ToString();
            //qty = Convert.ToInt32(QuantityTb.Text);
            uprice = Convert.ToInt32(row.Cells[3].Value.ToString());
            // totprice = qty*uprice;
            flag = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from ProductTbl where ProdCat ='" + SearchCombo.Text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
