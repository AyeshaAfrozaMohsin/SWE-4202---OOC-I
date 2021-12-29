using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course_Enrollment
{
    public partial class Form1 : Form
    {
        StudentCourseEnrollment studentCourseEnrollment = new StudentCourseEnrollment();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void AddParticipant(object sender, EventArgs e)
        {
            if (EnterTypeStudentRadioButton.Checked == true)
            {
                Participant dummy = new Participant(EnterParticipantNameBox.Text,
                    EnterParticipantRegNoBox.Text, EnterParticipantContactNoBox.Text
                    , EnterParticipantEmailBox.Text);
                
                if (EnterLevelIntermediateRadioButton.Checked == true)
                {
                    dummy.SetLevel("Intermediate");
                }
                else if (EnterLevelAdvancedRadioButton.Checked == true)
                {
                    dummy.SetLevel("Advanced");
                }

                EnrollStudentCBox.Items.Add(dummy.GetName());
                ViewStudentCBox.Items.Add(dummy.GetName());

                studentCourseEnrollment.participants.Add(dummy);


                MessageBox.Show("Participant Added Sucessfully");
            }
            else if (EnterTypeProfessionalRadioButton.Checked == true)
            {
                Professional dummy = new Professional(EnterParticipantNameBox.Text,
                    EnterParticipantRegNoBox.Text, EnterParticipantContactNoBox.Text
                    , EnterParticipantEmailBox.Text);
                if (EnterLevelIntermediateRadioButton.Checked == true)
                {
                    dummy.SetLevel("Intermediate");
                }
                else if (EnterLevelAdvancedRadioButton.Checked == true)
                {
                    dummy.SetLevel("Advanced");
                }

                EnrollStudentCBox.Items.Add(dummy.GetName());
                ViewStudentCBox.Items.Add(dummy.GetName());

                studentCourseEnrollment.professionals.Add(dummy);

                MessageBox.Show("Professional Added Sucessfully");
            }
            else
                MessageBox.Show("Please Select Type of Participant");
        }

        private void AddCourse(object sender, EventArgs e)
        {
            Course dummy = new Course();
            dummy.Title = EnterCourseTitleBox.Text;
            dummy.Fee = Convert.ToInt32(EnterCourseFeeBox.Text);
            if (EnterCourseLevelIntermediateRadioButton.Checked == true)
            {
                dummy.Level = "Intermediate";
            }
            else if (EnterCourseLevelAdvancedRadioButton.Checked == true)
            {
                dummy.Level = "Advanced";
            }

            studentCourseEnrollment.courses.Add(dummy);

            EnrollCourseCBox.Items.Add(dummy.Title);

            MessageBox.Show("Course Added Sucessfully");

        }

        private void PayAndEnroll(object sender, EventArgs e)
        {
            if(EnrollStudentCBox.Text == string.Empty || EnrollCourseCBox.Text == string.Empty)
            {
                MessageBox.Show("Please select both Student and Course to Enroll");
                return;
            }
            else
            {
                int i, j, k;
                bool isProf = false; //is a professional or not
                for (j = 0; j< studentCourseEnrollment.courses.Count; j++)
                {
                    if(studentCourseEnrollment.courses[j].Title == EnrollCourseCBox.Text)
                    {
                        break;
                    }
                }
                for (i = 0; i < studentCourseEnrollment.participants.Count; i++)
                {
                    if (EnrollStudentCBox.Text == studentCourseEnrollment.participants[i].GetName())
                    {
                        isProf = false;
                        break;
                    }
                }
                for (k = 0; k < studentCourseEnrollment.professionals.Count; k++)
                {
                    if (EnrollStudentCBox.Text == studentCourseEnrollment.professionals[k].GetName())
                    {
                        isProf = true;
                        break;
                    }
                }

                if( !isProf ) //participant
                {
                    if (studentCourseEnrollment.participants[i].GetLevel() == studentCourseEnrollment.courses[j].Level)
                    {
                        Course dummy = studentCourseEnrollment.courses[j];
                        dummy.EnrolledDate = dateTimePicker1.Text;
                        studentCourseEnrollment.participants[i].EnrolledCourses.Add(studentCourseEnrollment.courses[j]);
                        MessageBox.Show("Transaction Sucessful!");
                    }
                    else
                    {
                        MessageBox.Show("The Level of the student and course donnot match\nTransaction Incomplete, Please Try again.");
                    }
                }
                else
                {
                    if (studentCourseEnrollment.professionals[k].GetLevel() == studentCourseEnrollment.courses[j].Level)
                    {
                        Course dummy = studentCourseEnrollment.courses[j];
                        dummy.EnrolledDate = dateTimePicker1.Text;
                        studentCourseEnrollment.professionals[i].EnrolledCourses.Add(studentCourseEnrollment.courses[j]);
                        MessageBox.Show("Transaction Sucessful!");
                    }
                    else
                    {
                        MessageBox.Show("The Level of the professional and course do not match\nTransaction Incomplete, Please Try again.");
                    }
                }

            }
        }

        private void ShowEnrolledCourses(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Course Title\tCourse Level\tCourse Fee\tEnrollmentDate");
            int i=0;
            foreach (Participant participant in studentCourseEnrollment.participants)
            {
                if (ViewStudentCBox.Text == participant.GetName())
                {
                    foreach (Course course in participant.EnrolledCourses)
                    {
                        listBox1.Items.Add(course.Title + "\t\t" + course.Level + "\t\t"
                            + Convert.ToString(course.Fee) + "\t\t" + course.EnrolledDate +
                            "\n" );
                        MessageBox.Show(i.ToString() );
                        i++;
                    }

                    listBox1.Items.Add(  "Total Paid: " +
                            Convert.ToString(participant.CalculateFee()) );
                    return;
                }
            }
            foreach (Professional professional in studentCourseEnrollment.professionals)
            {
                if (ViewStudentCBox.Text == professional.GetName())
                {
                    foreach (Course course in professional.EnrolledCourses)
                    {
                        listBox1.Items.Add(course.Title + "\t\t" + course.Level + "\t\t"
                            + Convert.ToString(course.Fee) + "\t\t" + course.EnrolledDate + "\n");
                        i++;
                    }

                    listBox1.Items.Add("Total Paid: " +
                            Convert.ToString(professional.CalculateFee()));
                    return;
                }
            }
        }

        private void EnrollStudentCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EnrollCourseCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (EnrollStudentCBox.Text == string.Empty)
            {
                foreach (Course course in studentCourseEnrollment.courses)
                {
                    if (EnrollCourseCBox.Text == course.Title)
                    {
                        ShowCourseFeeBox.Text = course.Fee.ToString();
                        break;
                    }
                }
            }

            else 
            {
                for (int i = 0; i < studentCourseEnrollment.participants.Count; i++)
                {
                    if (EnrollStudentCBox.Text == studentCourseEnrollment.participants[i].GetName())
                    {
                        foreach (Course course in studentCourseEnrollment.courses)
                        {
                            if (EnrollCourseCBox.Text == course.Title)
                            {
                                ShowCourseFeeBox.Text = course.Fee.ToString();
                                break;
                            }
                        }
                        return;
                    }
                }
                for (int i = 0; i < studentCourseEnrollment.professionals.Count; i++)
                {
                    if (EnrollStudentCBox.Text == studentCourseEnrollment.professionals[i].GetName())
                    {
                        foreach (Course course in studentCourseEnrollment.courses)
                        {
                            if (EnrollCourseCBox.Text == course.Title)
                            {
                                ShowCourseFeeBox.Text = Convert.ToString(course.Fee * 1.1);
                                break;
                            }
                        }
                        return;
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
