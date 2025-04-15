using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace InventoryManagementSystem
{
    public partial class ManageUser : Form
    {
        public ManageUser()
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
                string MyQuery = "select * from UserTb";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        // Add user
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTb values('" + UsernameTb.Text + "','" + FullNameTb.Text + "','" + PasswordTb.Text + "','" + TelephoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }
        //show newly added user in database 
        private void ManageUser_Load(object sender, EventArgs e)
        {
            populate();
        }
        //Delete  user where the phone number is *** (primary key)
        private void button3_Click(object sender, EventArgs e)
        {
            if (TelephoneTb.Text == "")
            {
                MessageBox.Show("Enter The Users Phone Number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTb where UPhone ='" + TelephoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");

                Con.Close();
                populate();
            }
        }
        //If you click on data in db table, data will transfer to the labels on the left side

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)


        {

            if (e.RowIndex >= 0) // check if you clicked on the right place
            {
                DataGridViewRow row = UsersGV.Rows[e.RowIndex];

                if (row.Cells.Count >= 4) // check if there is enough data
                {
                    UsernameTb.Text = row.Cells[0].Value?.ToString();
                    FullNameTb.Text = row.Cells[1].Value?.ToString();
                    PasswordTb.Text = row.Cells[2].Value?.ToString();
                    TelephoneTb.Text = row.Cells[3].Value?.ToString();
                }
            }


        }
    }
}
    

