using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/* Task: 
1) Create class “Student” with the next fields:
   FirstName (string)
   LastName (string)
   ID (int)
   City (string)
   Scores (List<int>)

2) Create List< Student > and add at least 3 Student objects into least 
3) Using LINQ from the List< Student > select student for which average score is high than 60 and City is “NYC”, students should be order ascending by the first name
4) Output in the console First and Last name of students which was selected by LINQ query

Definition of done: 
-	Build performed with no errors.
-	Code executes with output in the console.
-	Required class is implemented 
-	Filtering performed using LINQ */


namespace ReskillProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Student> StudentList = new List<Student>();
            StudentList.Add(new Student("Iuliia", "Mazhara", 1, "Kyiv", new List<int> { 60, 80, 100, 12 }));
            StudentList.Add(new Student("Olga", "Mazhara", 1, "NYC", new List<int> { 100, 100, 100, 100 }));
            StudentList.Add(new Student("Bred", "Pitt", 1, "NYC", new List<int> { 100, 50, 30, 100 }));

            IEnumerable<Student> students = from student in StudentList
                                            where student.Scores.Average() > 60
                                            where student.City == "NYC"
                                            orderby student.FirstName ascending
                                            select student;


            foreach (Student student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName );
            }
            
        }
    }
}





