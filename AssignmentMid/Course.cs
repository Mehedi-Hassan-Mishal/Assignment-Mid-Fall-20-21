using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Course
    {
        private string courseName;
        private string courseId;
        private float teachingHour;
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
        public float TeachingHour
        {
            get { return teachingHour; }
            set { teachingHour = value; }
        }
        public Course(string courseName, string courseId, float teachingHour)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.teachingHour = teachingHour;
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
