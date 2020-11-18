using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Program
    {
        static void Main(string[] args)
        {
            Department cse = new Department("CSE");
            Course csharp = new Course("OOP2", "111");
            Course java = new Course("JAVA", "222");
            cse.AddCourse(algo);
            cse.AddCourse(java);
            Section x = new Section("X");
            Section y = new Section("Y");
            algo.AddSection(x);
            java.AddSection(y);
            Faculty mrAlex = new Faculty("Mr. Alex", "112233", 12.0f);
            mrAlex.AddSection(x);
            mrAlex.AddSection(y);
            x.AddTeacher(mrAlex);
            y.AddTeacher(mrAlex);
            java.ShowSectionTeacher();
            mrAlex.ShowSectionDetails();
            Console.ReadLine();
        }
   
    }
}
