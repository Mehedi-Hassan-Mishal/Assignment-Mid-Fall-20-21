using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Faculty
    {
        private string teacherName;
        private string teacherId;
        public float totalHourOfClass;
        Section[] sectionName = new Section[50];
        private int countSection = 0;

        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }

        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }
        
        public float TotalHourOfClass
        {
            get { return totalHourOfClass; }
            set { totalHourOfClass = value; }
        }
        public Faculty(string teacherName, string teacherId, float totalHourOfClass)
        {
            this.teacherName = teacherName;
            this.teacherId = teacherId;
            this.totalHourOfClass = totalHourOfClass;
        }

        public void AddSection(Section sectionName)
        {
            this.sectionName[countSection] = sectionName;
            countSection++;
            totalHourOfClass += 2.0f;
        }

        public void ShowTeacherDetails()
        {
            Console.WriteLine("Teacher's Name: " + teacherName);
            Console.WriteLine("Teacher's Id: " + teacherId);
            Console.WriteLine("Total hour of teaching:" + totalHourOfClass);
        }

        public void ShowSectionDetails()
        {
            for(int i=0;i<10;i++)
            {
                if (sectionName[i] != null)
                {
                    sectionName[i].ShowDetails();
                }
                else { break; }
            }
        }
    }
}
