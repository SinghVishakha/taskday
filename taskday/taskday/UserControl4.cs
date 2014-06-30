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
    public partial class UserControl4 : UserControl
    {
        string cs = @"Data Source=long\beach;Initial Catalog=KopalTraining;Integrated Security=True";
        public UserControl4()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UserControl7 ob = new UserControl7();
            panel2.Controls.Add(ob);
            ob.Show();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            
            panel2.Controls.Clear();
            UserControl6 ob = new UserControl6();
            panel2.Controls.Add(ob);
            ob.Show();
        }
    }
}
