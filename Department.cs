using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Department
    {

        private string dName;
        public string Name
        {
            get { return dName; }
            set { dName = value; }
        }



        private Course[] courses;
        private int coursecount;
        public int courseCount
        {
            get { return courseCount; }

            set { courseCount = value; }
        }

        public Department()
        {
            course = new Course[100];
            courseCount = 0;
        }
        public Department(string name)
        {
            this.name = name;
            courses = new Course[100];
            courseCount = 0;
        }
        public void AddCourse(params Course[] course)
        {
            foreach (var cour in courses)
            {
                if (courseCount < 100)
                    this.courses[courseCount++] = cour;
                else
                    Console.WriteLine("no courses");
            }

        }


        public void ShowAllCourses()
        {
            for (int i = 0; i < courseCount; i++)
            {
                course[i].ShowInfo();
            }
        }

        public Course SearchCourses(string id)
        {
            Courses c = null;
            for (int i = 0; i < courseCount; i++)
            {
                if (id.Equals(Courses[i].Id))
                {
                    c = courses[i];
                    break;
                }
            }

            return c;
        }
    }
}



        

