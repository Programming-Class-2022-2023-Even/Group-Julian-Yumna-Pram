namespace AppKasir
{
    public partial class FormLogin : Form
    {

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
            if (textBox1.Text == "KSR001" && textBox2.Text == "admin")
            {
                MainMenuForm frmUtama = new MainMenuForm();
                frmUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}