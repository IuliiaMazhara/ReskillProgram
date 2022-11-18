using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram
{
    public class Student
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string City { get; set; }
        public List<int> Scores { get; set; }

        public Student(string firstName, string lastName, int iD, string city, List<int> scores)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            City = city;
            Scores = scores;
        }
    }
}
