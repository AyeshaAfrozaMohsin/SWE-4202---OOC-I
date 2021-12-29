using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Participant
    {
        string Name;
        string RegNo;
        string ContactNo;
        string Email;
        string Level = "Beginner";
        

        public List<Course> EnrolledCourses = new List<Course>();

        //getters 
        public string GetName()
        {
            return Name;
        }
        public string GetRegNo()
        {
            return RegNo;
        }
        public string GetContactNo()
        {   
            return ContactNo;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetLevel()
        {
            return Level;
        }
        //setters
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetRegNo(string RegNo)
        {
            this.RegNo = RegNo;
        }
        public void SetContactNo(string ContactNo)
        {
            this.ContactNo = ContactNo;
        }
        public void SetEmail(string Email)
        {
            this.Email = Email;
        }
        public void SetLevel(string Level)
        {
            this.Level = Level;
        }
        //Constructor
        public Participant(string Name, string RegNo, string ContactNo, string Email)
        {
            SetName(Name);
            SetRegNo(RegNo);
            SetContactNo(ContactNo);
            SetEmail(Email);
        }
        //methods
        public virtual double CalculateFee()
        {
            double fee = 0;
            for ( int i = 0; i<EnrolledCourses.Count; i++)
            {
                fee += EnrolledCourses[i].Fee;
            }
            return fee;
        }
    }
}
