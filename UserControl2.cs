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
    public partial class UserControl2 : UserControl

    {
        string cs = @"Data Source=long\beach;Initial Catalog=KopalTraining;Integrated Security=True";
        public UserControl2()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Available Teams")
            {
                label2.Visible = true;
                label3.Visible = true;
              textBox1.Visible = true;
                textBox2.Visible = true;
                
                

               
            }
            else
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "TeamId";
            dataGridView1.Columns[1].Name = "TeamName";
            dataGridView1.Columns[2].Name = "status";
            dataGridView1.Columns[3].Name = "NextBooking";
            if (comboBox1.Text == "All Teams")
            {
                dataGridView1.Rows.Clear();
                DataClasses1DataContext db = new DataClasses1DataContext(cs);
                
                var result = db.ViewAllTeams();
                foreach (var r in result)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = r.teamId;
                    row.Cells[1].Value = r.teamName;
                    row.Cells[2].Value = r.status;
                    row.Cells[3].Value = r.nextBooking;
                    dataGridView1.Rows.Add(row);

                }

            }
            else
            {
                if (comboBox1.Text == "Currently available teams")
                {
                    dataGridView1.Rows.Clear();
                    DataClasses1DataContext db = new DataClasses1DataContext(cs);
                    var result = db.ViewAvailableTeams();
                    foreach (ViewAvailableTeamsResult r in result)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = r.teamId;
                        row.Cells[1].Value = r.teamName;
                        row.Cells[2].Value = r.status;
                        row.Cells[3].Value = r.nextBooking;
                        dataGridView1.Rows.Add(row);

                    }
                }
            }
        }
    }
}
