namespace AppKasir
{
    partial class FormMasterCashier
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Cashier Code";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 74);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Cashier Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 109);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 2;
            label3.Text = "Cashier Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 148);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Cashier Level";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(336, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(336, 23);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(21, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 77);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Process";
            // 
            // button4
            // 
            button4.Location = new Point(425, 23);
            button4.Name = "button4";
            button4.Size = new Size(75, 36);
            button4.TabIndex = 3;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(283, 23);
            button3.Name = "button3";
            button3.Size = new Size(75, 36);
            button3.TabIndex = 2;
            button3.Text = "Erase";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(146, 22);
            button2.Name = "button2";
            button2.Size = new Size(75, 37);
            button2.TabIndex = 1;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(15, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 0;
            button1.Text = "Input";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(589, 202);
            dataGridView1.TabIndex = 9;
            // 
            // FormMasterCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 521);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterCashier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMasterCashier";
            Load += FormMasterCashier_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormMasterCashier_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}