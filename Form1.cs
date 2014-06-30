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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UserControl4 ob = new UserControl4();
            panel2.Controls.Add(ob);
            ob.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UserControl5 ob = new UserControl5();
            panel2.Controls.Add(ob);
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UserControl1 ob = new UserControl1();
            panel2.Controls.Add(ob);
            ob.Show();

        }


        
    }
}
