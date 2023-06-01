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

        private void FormMasterCashier_load(object sender, EventArgs e) 
        { 
         FirstCondtion();
        }
       
    }
}
