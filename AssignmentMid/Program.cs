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

            Course c1 = new Course("OOP1", "111");
            Course c2 = new Course("OOP2", "222");

            cse.AddCourse(c1);
            cse.AddCourse(c2);

            Section x = new Section("X");
            Section y = new Section("Y");
            Section z = new Section("Z");

            c1.AddSection(x);
            c2.AddSection(y);

            Faculty f1 = new Faculty("Mr. Alex", "112233", 12.0f);
            Faculty f2 = new Faculty("Mr. Andray", "445566", 13.0f);

            c1.AddSection(x);
            c1.AddSection(y);
            c2.AddSection(z);

            x.AddTeacher(f1);
            y.AddTeacher(f1);
            z.AddTeacher(f2);

            c1.ShowSectionTeacher();
            c2.ShowSectionTeacher();

            f1.ShowSectionDetails();
            f2.ShowSectionDetails();
            Console.ReadLine();
        }
   
    }
}
