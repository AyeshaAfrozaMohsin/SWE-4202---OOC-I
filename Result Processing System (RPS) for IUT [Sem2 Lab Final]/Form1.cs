using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Result_Processing_System__RPS__for_IUT__Sem2_Lab_Final_
{
    public partial class Form1 : Form
    {
        RPS rps = new RPS();

        public void Read_OOC_CSE()
        {
            using (var reader = new StreamReader(@"C:\Ayesha\Studies\SEM2\Visual Studio\Result Processing System (RPS) for IUT [Sem2 Lab Final]\SWE4201MarkSheet.csv"))
            {

                while (!reader.EndOfStream)
                {
                    Student Dummy = new Student();

                    var line = reader.ReadLine(); //single line
                    var values = line.Split(','); // list of values
                    
                    Dummy.ID = values[0];
                    Dummy.Name = Student.SpecificLength(values[1], 33);
                    if (values[2] != "")
                    {
                        Dummy.Attendance = Convert.ToDouble(values[2]);
                    }
                    else Dummy.Attendance = 0;
                    if (values[3] != "")
                    {
                        Dummy.Quizes[0] = Convert.ToDouble(values[3]);
                    }
                    if (values[4] != "")
                    {
                        Dummy.Quizes[1] = Convert.ToDouble(values[4]);
                    }
                    if (values[5] != "")
                    {
                        Dummy.Quizes[2] = Convert.ToDouble(values[5]);
                    }
                    if (values[6] != "")
                    {
                        Dummy.Quizes[3] = Convert.ToDouble(values[6]);
                    }
                    if (values[7] != "")
                    {
                         Dummy.Mid = Convert.ToDouble(values[7]);
                    }
                    else Dummy.Mid = 0;
                    if (values[8] != "")
                    {
                         Dummy.Final = Convert.ToDouble(values[8]);
                    }
                    else Dummy.Final = 0;
                    if (values[9] != "")
                    {
                         Dummy.Viva = Convert.ToDouble(values[9]);
                    }
                    else Dummy.Viva = 0;

                    StudentIDComboBox.Items.Add(Dummy.ID);
                    rps.Students.Add(Dummy);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            Read_OOC_CSE();
            
        }

        private void DisplayAllStudentInfo(object sender, EventArgs e)
        {
            if (CourseNameComboBox.Text == "Object Oriented Concepts 1")
            {
                listBox1.Items.Add("ID\t    " + Student.SpecificLength("Name", 33) +
                    "Percent\tGrade");
                foreach( Student s in rps.Students)
                {
                    listBox1.Items.Add(s.ID + "   " + s.Name +
                         Student.SpecificLength(Convert.ToString(s.CalculatePercentage()), 10)
                         + "\t" + s.CalculateGrade() );
                }
            }

        }

        private void DisplayIndividualStudentInfo(object sender, EventArgs e)
        {
            var studentlist = from student in rps.Students
                    where student.ID == StudentIDComboBox.Text
                    select student;
            listBox2.Items.Clear();

            foreach (var s in studentlist)
            {
                listBox2.Items.Add("Name : " + s.Name);
                listBox2.Items.Add("Attendance : " + Convert.ToString(s.Attendance));
                listBox2.Items.Add("Quiz 1 : " + Convert.ToString(s.Quizes[0]));
                listBox2.Items.Add("Quiz 2 : " + Convert.ToString(s.Quizes[1]));
                listBox2.Items.Add("Quiz 3 : " + Convert.ToString(s.Quizes[2]));
                listBox2.Items.Add("Quiz 4 : " + Convert.ToString(s.Quizes[3]));
                listBox2.Items.Add("Mid : " + Convert.ToString(s.Mid));
                listBox2.Items.Add("Final : " + Convert.ToString(s.Final));
                listBox2.Items.Add("Viva : " + Convert.ToString(s.Viva));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
