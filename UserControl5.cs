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
    public partial class UserControl5 : UserControl
    {
        string cs = @"Data Source=long\beach;Initial Catalog=KopalTraining;Integrated Security=True";
        public UserControl5()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.Rows.Clear();
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            var result = db.findCompleted();
            foreach (findCompletedResult r in result)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = r.projectId;
                row.Cells[1].Value = r.teamId;
                row.Cells[2].Value = r.projectName;
                row.Cells[3].Value = r.startDate;
                row.Cells[4].Value = r.endDate;

                dataGridView1.Rows.Add(row);
            }

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.Rows.Clear();
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            var result = db.findOngoing();
            foreach (findOngoingResult r in result)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = r.projectId;
                row.Cells[1].Value = r.teamId;
                row.Cells[2].Value = r.projectName;
                row.Cells[3].Value = r.startDate;
                row.Cells[4].Value = r.endDate;

                dataGridView1.Rows.Add(row);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.Rows.Clear();
            DataClasses1DataContext db = new DataClasses1DataContext(cs);
            var result = db.findPending();
            foreach (findPendingResult r in result)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = r.projectId;
                row.Cells[1].Value = r.teamId;
                row.Cells[2].Value = r.projectName;
                row.Cells[3].Value = r.startDate;
                row.Cells[4].Value = r.endDate;

                dataGridView1.Rows.Add(row);
            }
        }
    }
}
