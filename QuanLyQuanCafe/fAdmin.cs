using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            loadFoodList();
            loadAccountList();
        }

        void loadAccountList()
        {
            string query = "CALL USP_GetAccountByUserName('K9')";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadFoodList()
        {
            string query = "select * from Food";

            dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

    }
}
