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
    public partial class Form1 : Form
    {

        List<Course> allCourses = new List<Course>();
        List<Course> mySchedule = new List<Course>();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblIntructor_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allCourses.Add(new Course("Communications 101", "Mon & Wed 9-11AM", "C250", "O. Winfrey", 3));
            allCourses.Add(new Course("Intro. to Finance", "Tues & Thurs 10-Noon", "B112", "W.Buffet", 3));
            allCourses.Add(new Course("Intro. to Engineering", "Mon & Wed 11-1PM", "E220", "E.Musk", 4));
            allCourses.Add(new Course("Physical Science I", "Mon & Wed Noon-4PM", "S260", "N. Degrasse Tyson", 4));
            allCourses.Add(new Course("Intro. to Health & Fitness", "Tues & Thurs 8-10AM", "H260", "D. 'The Rock' Johnson", 2));
            allCourses.Add(new Course("C# Programming II", "Wed 6-10PM", "T951", "B. Gates", 3));
            allCourses.Add(new Course("Social Media Marketing", "Mon 6-10PM", "T950", "M. Zuckerberg", 3));
            allCourses.Add(new Course("Intro. to Drama/Performance", "Thurs 6-10PM", "F100", "D. Washington", 3));

            foreach (Course c in allCourses)
            {
                lstCourses.Items.Add(c.CourseName);
            }
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex >= 0)
            {
                Course c = allCourses[lstCourses.SelectedIndex];

                lblCourse.Text = c.CourseName;
                lblTimes.Text = c.MeetingTimes;
                lblLocation.Text = c.Location;
                lblInstructor.Text = c.Instructor;
                lblHours.Text = c.CreditHours.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)

        {
            if (lstCourses.SelectedIndex < 0)
            {
                MessageBox.Show("Select a course from the list before adding", "No Selection");
            }
            else
            {
                Course c = allCourses[lstCourses.SelectedIndex];
                mySchedule.Add(c);

                MessageBox.Show(c.CourseName + " has been added to your Schedule", "COURSE ADDED");
            }
        }

        private void bntView_Click(object sender, EventArgs e)
        {
            FrmSchedule f = new FrmSchedule(mySchedule);
            f.Show();
        }
    }
}
