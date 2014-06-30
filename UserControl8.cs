using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taskday
{
    public partial class UserControl8 : UserControl
    {
        public UserControl8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form1 ob = new Form1();
                ob.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username and Password", "Error", MessageBoxButtons.OKCancel);
            }
        }
    }
}
