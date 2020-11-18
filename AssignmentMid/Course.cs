using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Course
    {
        private string courseName;
        private string courseId;
        Section[] sectionName = new Section[50];
        private int countSection = 0;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        public Course(string courseName, string courseId)
        {
            this.courseName = courseName;
            this.courseId = courseId;
        }

        public void AddSection(Section sectionName)

        {

            this.sectionName[countSection++] = sectionName;
        }
        public void ShowSectionTeacher()
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
