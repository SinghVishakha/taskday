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
    public partial class UserControl7 : UserControl
    {
        string cs = @"Data Source=long\beach;Initial Catalog=KopalTraining;Integrated Security=True";
        public UserControl7()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            comboBox1.DataSource = (from p in db.Projects
                                    where p.status == "pending"
                                    select p.projectName);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            comboBox1.DataSource = (from p in db.Projects
                                    where p.status == "pending"
                                    select p.projectName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ProjectName = comboBox1.Text;

            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            var result = db.CheckFreeTeams(ProjectName, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            int flag = 0;
            foreach (CheckFreeTeamsResult r in result)
            {
                flag = 1;
                Project ob= db.Projects.Single(c => c.projectName == ProjectName);
                ob.startDate =  dateTimePicker1.Value.Date;
                ob.endDate =dateTimePicker2.Value.Date ;
                ob.status = "ongoing";
                ob.teamId = r.teamId;
                ob.report = "started";
                db.SubmitChanges();
                Team ch = db.Teams.Single(c => c.teamId == r.teamId);
                ch.nextBooking = ob.startDate;
                db.SubmitChanges();
                string MessageBoxTitle = "Error";
                string MessageBoxContent = "Project Scheduled";

                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.OKCancel);
                break;
            }
            if (flag == 0)
            {
               
                string MessageBoxTitle = "Error";
                string MessageBoxContent = "No Teams Available";

                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.OKCancel);
            }
        }
    }
}
