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
    public partial class UserControl9 : UserControl
    {
       public string TeamId;
        string cs = @"Data Source=long\beach;Initial Catalog=KopalTraining;Integrated Security=True";
        public UserControl9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DataClasses1DataContext db = new DataClasses1DataContext(cs);
             TeamId = textBox1.Text;
            var ob2 = db.TeamPasswords.Any(c => c.teamId == Convert.ToInt32(TeamId));
            if (ob2 == false)
            {
                MessageBox.Show("NO such Team Exists", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                TeamPassword ob1 = db.TeamPasswords.Single(c => c.teamId == Convert.ToInt32(TeamId));
                if (ob1.Passwd == textBox2.Text)
                {
                    Form3 ob = new Form3();
                    ob.TeamId = TeamId;
                    ob.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OKCancel);
                }
            }
        }
    }
}
