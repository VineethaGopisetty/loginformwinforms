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

namespace loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbUserType.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main2 ss = new Main2();
            ss.Show();
            if (cmbUserType.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Connected!!!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=INBLL000519;Initial Catalog=Schoolform;
             Integrated Security=True");
             SqlCommand cmd = new SqlCommand("select * form TableLogin", con);
             DataTable tb = new DataTable();
             con.Open();
        }
    }
}
