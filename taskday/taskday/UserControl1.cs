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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UserControl2 ob = new UserControl2();
            panel2.Controls.Add(ob);
            ob.Show();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UserControl3 ob = new UserControl3();
            panel2.Controls.Add(ob);
            ob.Show();
        }
    }
}
