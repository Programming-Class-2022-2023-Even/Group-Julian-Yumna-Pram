using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKasir
{
    public partial class MainMenuForm : Form
    {
        public static MainMenuForm menu;
        MenuStrip mnstrip;
        FormLogin frmLogin;

        void frmLogin_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }
        FormMasterCashier frmCashier;
        void frmCashier_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmCashier = null;
        }
        void lockedMenu()
        {
            loginMenu.Enabled = true;
            logoutMenu.Enabled = false;
            masterMenu.Enabled = false;
            transactionMenu.Enabled = false;
            reportMenu.Enabled = false;
            utilityMenu.Enabled = false;
            menu = this;
        }
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            lockedMenu();
        }

        private void loginMenu_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new FormLogin();
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_fromClosed);
                frmLogin.ShowDialog();
                //frmLogin.Show();
            }
            else
            {
                frmLogin.Activate();
            }
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            lockedMenu();
        }

        private void cashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCashier == null)
            {
                frmCashier = new FormMasterCashier();
                frmCashier.FormClosed += new FormClosedEventHandler(frmCashier_fromClosed);
                frmCashier.ShowDialog();
                //frmLogin.Show();
            }
            else
            {
                frmCashier.Activate();
            }
        }
    }
}
