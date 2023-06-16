using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;

namespace AppKasir
{
    public partial class FormMasterItem : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void showUnit()
        {
            comboBox1.Items.Add("BOX");
            comboBox1.Items.Add("BOTTLE");
            comboBox1.Items.Add("PAX");
            comboBox1.Items.Add("PCS");
            comboBox1.Items.Add("KILO");
            comboBox1.Items.Add("LITRE");
        }
        void FirstCondtion()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            showUnit();
            ShowItemData();
        }
        void ShowItemData()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from TBL_BARANG", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_BARANG");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_BARANG";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

        }
        public FormMasterItem()
        {
            InitializeComponent();
        }

        private void FormMasterItem_Load(object sender, EventArgs e)
        {
            FirstCondtion();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
