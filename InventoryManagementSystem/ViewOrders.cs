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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\InventoryDb.mdf;Integrated Security=True;Connect Timeout=30");
        void populateOrders()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from OrdersTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrderGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int ordId;
        int customerId;
        string custName;
        string ordDate;
        int total;
        private void OrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = OrderGV.Rows[e.RowIndex];
            ordId = Convert.ToInt32(row.Cells[0].Value?.ToString());
            customerId = Convert.ToInt32(row.Cells[1].Value?.ToString());
            custName = row.Cells[2].Value?.ToString();
            ordDate= row.Cells[3].Value?.ToString();
            total = Convert.ToInt32(row.Cells[4].Value?.ToString());


            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {               
                printDocument1.Print();
            }
            
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateOrders();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.BlueViolet, new PointF(250, 100));
            e.Graphics.DrawString("Order Id: "+ordId, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80,150));
            e.Graphics.DrawString("Customer Id: " + customerId, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80, 190));
            e.Graphics.DrawString("Customer Name: " + custName, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80, 230));
            e.Graphics.DrawString("Order Date: " + ordDate, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80, 270));
            e.Graphics.DrawString("Total Amount: " + total, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new PointF(80, 310));


        }
    }
}
