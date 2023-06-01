using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AppKasir
{
    public partial class FormMasterCashier : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void showLevel()
        {
            comboBox1.Items.Add("ADMIN");
            comboBox1.Items.Add("USER");

        }
        void FirstCondtion()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            showLevel();
        }
        public FormMasterCashier()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ShowCashierData()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from TBL_Cashier", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_Cashier");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_Cashier";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }
        private void FormMasterCashier_load(object sender, EventArgs e)
        {
            FirstCondtion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Make sure all forms are filled");
            }
            else
            {
                SqlConnection conn = konn.GetConn();

                cmd = new SqlCommand("Insert TBL_Cashier values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Input Successful");
                FirstCondtion();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection conn = konn.GetConn();

                cmd = new SqlCommand("Select * from  TBL_Cashier where CashierCode= '" + textBox1.Text +"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    textBox1.Text = rd[0].ToString();
                    textBox2.Text = rd[1].ToString();
                    textBox3.Text = rd[2].ToString();
                    comboBox1.Text = rd[3].ToString();
                }
                else
                {
                    MessageBox.Show("Data Not Found");
                }

            }
        }
    }
}
