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
    public partial class UserControl3 : UserControl
    {
        string cs = @"Data Source=long\beach;Initial Catalog=KopalTraining;Integrated Security=True";
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            Team ob = new Team();
            ob.teamName = textBox1.Text;
            ob.status = "a";
            db.Teams.InsertOnSubmit(ob);
            db.SubmitChanges();
            BA b1 = new BA();
            b1.empName = textBox3.Text;
            b1.teamId = ob.teamId;
            db.BAs.InsertOnSubmit(b1);
            db.SubmitChanges();
            QA q1 = new QA();
            q1.empName = textBox4.Text;
            q1.teamId = ob.teamId;
            db.QAs.InsertOnSubmit(q1);
            db.SubmitChanges();
            Dev d1 = new Dev();
            d1.empName = textBox2.Text;
            d1.teamId = ob.teamId;
            db.Devs.InsertOnSubmit(d1);
            db.SubmitChanges();
            TeamPassword pwd = new TeamPassword();
            pwd.Passwd = textBox5.Text;
            pwd.teamId = ob.teamId;
            db.TeamPasswords.InsertOnSubmit(pwd);
            db.SubmitChanges();
        }
    }
}
