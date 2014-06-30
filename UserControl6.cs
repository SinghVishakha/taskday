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
    public partial class UserControl6 : UserControl
    {
        string cs = @"Data Source=long\beach;Initial Catalog=KopalTraining;Integrated Security=True";
        public UserControl6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ProjectName = textBox1.Text;
           
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            var result = db.CheckFreeTeams(ProjectName, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            int flag = 0;
            foreach (CheckFreeTeamsResult r in result)
            {
                flag = 1;
                Project ob = new Project();
                ob.projectName = ProjectName;
               
                ob.startDate = dateTimePicker1.Value.Date;
                ob.endDate = dateTimePicker2.Value.Date;
                ob.report = "started";
                ob.status = "ongoing";
                ob.teamId = r.teamId;
                Team ch = db.Teams.Single(c => c.teamId == r.teamId);
                ch.nextBooking = ob.startDate;
                db.SubmitChanges();
                db.Projects.InsertOnSubmit(ob);
                db.SubmitChanges();
                string MessageBoxTitle = "status";
                string MessageBoxContent = "project scheduled and team assigned is"+ch.teamName;

                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.OKCancel);
                break;
            }
            if (flag == 0)
            {
                Project ob = new Project();
                ob.projectName = ProjectName;
                ob.startDate = dateTimePicker1.Value.Date;
                ob.endDate = dateTimePicker2.Value.Date;
                
                ob.report = "no team assigned";
                ob.status = "pending";
               
                db.Projects.InsertOnSubmit(ob);
                db.SubmitChanges();
                string MessageBoxTitle = "Error";
                string MessageBoxContent = "No Teams Available";

                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.OKCancel);
            }
        }
    }
}
