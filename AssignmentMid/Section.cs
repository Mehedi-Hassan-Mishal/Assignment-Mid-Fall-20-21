using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Section
    {
        private string sectionName;
        Faculty teacherName;

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
        public Section(string sectionName)
        {
            this.sectionName = sectionName;
        }

        public void AddTeacher(Faculty teacherName)
        {
            if (teacherName.totalHourOfClass < 21)
            {
                this.teacherName = teacherName;
            }
            else
            {
                Console.WriteLine("course can't add");
            }

        }

        public void ShowDetails()
        {
            Console.WriteLine("Section:" + sectionName);
            teacherName.ShowTeacherDetails();
        }
    }
}
