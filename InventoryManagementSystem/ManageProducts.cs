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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\InventoryDb.mdf;Integrated Security=True;Connect Timeout=30");
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
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

       
        void populate()
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

        void FilterByCategory()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from ProductTbl where ProdCat ='"+SearchCombo.Text+"' ";
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
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            populate();
            FillCategory();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + ProductIdTb.Text + "','" + ProductNameTb.Text + "','"+ProductQtyTb.Text + "','"+ProductPriceTb.Text + "','"+DescriptionTb.Text + "','"+CatCombo.Text+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProdName = '" + ProductNameTb.Text +"', ProdQty = '"+ProductQtyTb.Text+"', ProdPrice ='"+ProductPriceTb.Text+"', ProdDesc ='"+DescriptionTb.Text+"', ProdCat = '"+CatCombo.Text+ "'where ProdId = '" + ProductIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ProductIdTb.Text == "")
            {
                MessageBox.Show("Enter The Product Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTbl where ProdId ='" + ProductIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");

                Con.Close();
                populate();
            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // check if you clicked on the right place
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];

                if (row.Cells.Count >= 6) // check if there is enough data
                {
                    ProductIdTb.Text = row.Cells[0].Value?.ToString();
                    ProductNameTb.Text = row.Cells[1].Value?.ToString();
                    ProductQtyTb.Text = row.Cells[2].Value?.ToString();
                    ProductPriceTb.Text = row.Cells[3].Value?.ToString();
                    DescriptionTb.Text = row.Cells[4].Value?.ToString();
                    CatCombo.Text = row.Cells[5].Value?.ToString();


                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
