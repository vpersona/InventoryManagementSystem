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

        private void OrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
