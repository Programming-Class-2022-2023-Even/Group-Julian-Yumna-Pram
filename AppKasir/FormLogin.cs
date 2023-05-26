using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppKasir
{
    public partial class FormLogin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        Koneksi Konn = new Koneksi();

        public FormLogin()
        {
            InitializeComponent();
            {
                
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataReader reader = null;
            SqlConnection conn = Konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_KASIR WHERE NamaKasir='" + textBox1.Text + "' AND PasswordKasir='" + textBox2.Text + "'", conn);

                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MainMenuForm.menu.loginMenu.Enabled = false;
                    MainMenuForm.menu.logoutMenu.Enabled = true;
                    MainMenuForm.menu.masterMenu.Enabled = true;
                    MainMenuForm.menu.transactionMenu.Enabled = true;
                    MainMenuForm.menu.reportMenu.Enabled = true;
                    MainMenuForm.menu.utilityMenu.Enabled = true;
                    //MainMenuForm frmUtama = new MainMenuForm();
                    //frmUtama.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }

            //if (textBox1.Text == "KSR001" && textBox2.Text == "admin")
            //{
            //    MainMenuForm frmUtama = new MainMenuForm();
            //    frmUtama.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong Password");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}