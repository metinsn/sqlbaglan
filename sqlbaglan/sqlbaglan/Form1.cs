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

namespace sqlbaglan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Server=ALS-YG39506-J06;Database=Northwind;UID=sa;PWD=1");
            SqlDataAdapter dap = new SqlDataAdapter("select * from Employees", baglan);
            DataTable dt = new DataTable();
            try
            {
                dap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
