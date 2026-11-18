using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOUniversity
{
    public partial class FrmSchedule : Form
    {
        int credHrs = 0;
        List<Course> schedule;
        public FrmSchedule(List<Course> courses)
        {
            InitializeComponent();
            schedule = courses;
        }

        private void FrmSchedule_Load(object sender, EventArgs e)
        {
            foreach (Course c in schedule) 
            {
                
                string[] details = { c.CourseName, c.MeetingTimes, c.Location, c.CreditHours.ToString(), c.Instructor };
                
                ListViewItem lvi = new ListViewItem(details);
                
                lstvSchedule.Items.Add(lvi);
                credHrs += c.CreditHours; 
            }
            lblTotal.Text = credHrs.ToString(); 
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lstvSchedule.CheckedItems)
            {
               
                credHrs -= int.Parse(i.SubItems[3].Text);
                lstvSchedule.Items.Remove(i); 
            }
            lblTotal.Text = credHrs.ToString(); 
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lstvSchedule.CheckedItems)
            {
                credHrs -= int.Parse(i.SubItems[3].Text);
                lstvSchedule.Items.Remove(i);
            }

            lblTotal.Text = credHrs.ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                "You are now registered!",
                "Thank You and Goodbye",
                MessageBoxButtons.OK);

                if (result == DialogResult.OK)
                {
                    Application.Exit();

                }
            }
        }

        private void lstvSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
