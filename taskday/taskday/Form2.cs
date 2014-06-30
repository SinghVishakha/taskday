using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taskday
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void radioButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UserControl8 ob = new UserControl8();
            panel1.Controls.Add(ob);
            ob.Show();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl9 ob = new UserControl9();
            panel1.Controls.Add(ob);
            ob.Show();
        }
    }
}
