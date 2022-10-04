using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociationRelationshipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department1 = new Department();

            department1.Name = "Computer Science & Engineering";
            department1.Code = "CSE";

            Course course1 = new Course();
            course1.Code = "CSE101";
            course1.Title = "Fundamentals of Computer System";
            course1.Credit = 2.0;
            
            Course course2 = new Course();
            course2.Code = "CSE102";
            course2.Title = "C Programming";
            course2.Credit = 3.0; 
            
            Course course3 = new Course();
            course3.Code = "CSE103";
            course3.Title = "Data Structure";
            course3.Credit = 3.5;     
            
            Course course4 = new Course();
            course4.Code = "CSE104";
            course4.Title = "Introduction to Algorithms";
            course4.Credit = 4.0;

            department1.Courses.Add(course1);
            department1.Courses.Add(course2);
            department1.Courses.Add(course3);
            department1.Courses.Add(course4);

            Console.WriteLine(department1.showDetails());
            Console.ReadKey();


        }
    }
}
