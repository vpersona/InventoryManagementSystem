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

            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Qty", typeof(int));
            table.Columns.Add("UPrice", typeof(int));
            table.Columns.Add("TotalPrice", typeof(int));

            OrderGV.DataSource = table; 
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
        void UpdateProduct()
        {
            Con.Open();
            
          

            int newQty = stock - Convert.ToInt32(QuantityTb.Text);
            string query = "update ProductTbl set ProdQty = " + newQty + "where ProdId=" +prodId+";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            populateProducts();
        }


        DataTable table = new DataTable();
        int num = 0;
        int uprice, totprice, qty;
        string product;
        int flag = 0;
        int stock;
        int prodId;
        


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
            CustIdTb.Text = row.Cells[0].Value?.ToString();
            CustNameTb.Text = row.Cells[1].Value?.ToString();
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                stock = Convert.ToInt32(row.Cells[2].Value.ToString());
                product = row.Cells[1].Value.ToString();
                uprice = Convert.ToInt32(row.Cells[3].Value); 
                prodId = Convert.ToInt32(row.Cells[0].Value);
                flag = 1;
            }

        }
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (QuantityTb.Text == "")
            {
                MessageBox.Show("Enter the Quantity of Products");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the Product");
            }
            else if (Convert.ToInt32(QuantityTb.Text)>stock)
            {
                MessageBox.Show("Not Enough Stock Avaible");
            }
            else
            {
                
                num = num + 1;
                qty = Convert.ToInt32(QuantityTb.Text);
                totprice = qty*uprice;
        
                table.Rows.Add(num, product, qty, uprice, totprice);
                OrderGV.DataSource = table;
                flag = 0;
                UpdateProduct();
            }
            sum = sum + totprice;
            TotAmount.Text = sum.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OrderIdTb.Text == ""|| CustIdTb.Text ==""|| CustNameTb.Text==""|| TotAmount.Text == "")
            {
                MessageBox.Show("Fill the Data Correctly");

            }
            else
            {
                
                
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into OrdersTbl values('" + OrderIdTb.Text + "','" + CustIdTb.Text + "','" + CustNameTb.Text + "','" + OrderDt.Value.ToString("yyyy-MM-dd")
                     + "','" +TotAmount.Text+"')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Successfully Added");
                    Con.Close();
                //populate();
                try 
                { 
                
                }
                catch
                {
                    MessageBox.Show("Blad");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm hm = new HomeForm();
            hm.Show();
            this.Hide();
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
