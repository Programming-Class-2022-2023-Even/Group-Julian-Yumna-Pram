namespace AppKasir
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            loginMenu = new ToolStripMenuItem();
            logoutMenu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            masterMenu = new ToolStripMenuItem();
            cashierToolStripMenuItem = new ToolStripMenuItem();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            transactionMenu = new ToolStripMenuItem();
            reportMenu = new ToolStripMenuItem();
            lapDataMasterToolStripMenuItem = new ToolStripMenuItem();
            lapPenjualanToolStripMenuItem = new ToolStripMenuItem();
            utilityMenu = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileMenu, masterMenu, transactionMenu, reportMenu, utilityMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(560, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { loginMenu, logoutMenu, toolStripMenuItem1, exitToolStripMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(40, 20);
            fileMenu.Text = " File";
            // 
            // loginMenu
            // 
            loginMenu.Name = "loginMenu";
            loginMenu.Size = new Size(112, 22);
            loginMenu.Text = "Login";
            loginMenu.Click += loginMenu_Click;
            // 
            // logoutMenu
            // 
            logoutMenu.Name = "logoutMenu";
            logoutMenu.Size = new Size(112, 22);
            logoutMenu.Text = "Logout";
            logoutMenu.Click += logoutMenu_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // masterMenu
            // 
            masterMenu.DropDownItems.AddRange(new ToolStripItem[] { cashierToolStripMenuItem, itemsToolStripMenuItem });
            masterMenu.Name = "masterMenu";
            masterMenu.Size = new Size(55, 20);
            masterMenu.Text = "Master";
            // 
            // cashierToolStripMenuItem
            // 
            cashierToolStripMenuItem.Name = "cashierToolStripMenuItem";
            cashierToolStripMenuItem.Size = new Size(180, 22);
            cashierToolStripMenuItem.Text = "Cashier";
            cashierToolStripMenuItem.Click += cashierToolStripMenuItem_Click;
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(180, 22);
            itemsToolStripMenuItem.Text = "Items";
            // 
            // transactionMenu
            // 
            transactionMenu.Name = "transactionMenu";
            transactionMenu.Size = new Size(84, 20);
            transactionMenu.Text = "Transactions";
            // 
            // reportMenu
            // 
            reportMenu.DropDownItems.AddRange(new ToolStripItem[] { lapDataMasterToolStripMenuItem, lapPenjualanToolStripMenuItem });
            reportMenu.Name = "reportMenu";
            reportMenu.Size = new Size(54, 20);
            reportMenu.Text = "Report";
            // 
            // lapDataMasterToolStripMenuItem
            // 
            lapDataMasterToolStripMenuItem.Name = "lapDataMasterToolStripMenuItem";
            lapDataMasterToolStripMenuItem.Size = new Size(159, 22);
            lapDataMasterToolStripMenuItem.Text = "Lap Data Master";
            // 
            // lapPenjualanToolStripMenuItem
            // 
            lapPenjualanToolStripMenuItem.Name = "lapPenjualanToolStripMenuItem";
            lapPenjualanToolStripMenuItem.Size = new Size(159, 22);
            lapPenjualanToolStripMenuItem.Text = "Lap Penjualan";
            // 
            // utilityMenu
            // 
            utilityMenu.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, toolStripMenuItem3 });
            utilityMenu.Name = "utilityMenu";
            utilityMenu.Size = new Size(58, 20);
            utilityMenu.Text = "Utilities";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(168, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(168, 22);
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            WindowState = FormWindowState.Maximized;
            Load += MainMenuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem cashierToolStripMenuItem;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem lapDataMasterToolStripMenuItem;
        private ToolStripMenuItem lapPenjualanToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem fileMenu;
        public ToolStripMenuItem loginMenu;
        public ToolStripMenuItem logoutMenu;
        public ToolStripMenuItem masterMenu;
        public ToolStripMenuItem transactionMenu;
        public ToolStripMenuItem reportMenu;
        public ToolStripMenuItem utilityMenu;
    }
}