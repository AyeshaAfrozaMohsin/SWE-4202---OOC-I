using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Professional : Participant
    {


        public Professional(string Name, string RegNo, string ContactNo , string Email) : base(Name, RegNo, ContactNo , Email)
        {
        }

        public override double CalculateFee()
        {
            int fee = 0;
            for (int i = 0; i < EnrolledCourses.Count; i++)
            {
                fee += EnrolledCourses[i].Fee;
            }
            return 1.1*fee;
        }
    }
}
