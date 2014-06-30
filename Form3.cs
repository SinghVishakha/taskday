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
    public partial class Form3 : Form
    {
        public string TeamId;
        string cs = @"Data Source=long\beach;Initial Catalog=KopalTraining;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, System.EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            label3.Visible = true;
            button3.Visible = true;
            textBox2.Visible = true;
           
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            comboBox1.DataSource = (from p in db.Projects
                                    where p.teamId == Convert.ToInt32(TeamId)
                                    select p.projectName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            Project ob = db.Projects.Single(c => c.projectName == comboBox1.Text);
            ob.report = textBox2.Text;
            db.SubmitChanges();
        }
    }
}
