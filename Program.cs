using System;

namespace std
{
    class Program
    {
        static void Main(string[] args)
        {

            Department d1 = new Department("ENGLISH", "1122");

            Department d2 = new Department("BBA", "1133");

            Department d3 = new Department("CSE", "1144");

            a1.AddDepartment(d1, d2, d3);

            a1.ShowAllDepartment();

            Course c1 = new Course("ENGLISH", "ENG101", "A");

            Course c2 = new Course("BANGLADESH STUDIES", "ARTS555", "B");

            Course c3 = new Course("ACCOUNTING", "BBA889", "C");

            d1.AddCourse(c1, c2, c3);

            d1.ShowInfo();



            Faculty f1 = new Faculty("Maliha", "151728", "CSE-A ");

            Faculty f2 = new Faculty("Tabassum", "151728", "ENGLISH-A ");

            a1.AddFaculty(f1, f2);

            a1.ShowAllFaculty();

            Section s1 = new Section("A");

            Section s2 = new Section("B");

            Section s3 = new Section("C");

            c1.AddSection(s1, s2, s3);

            c2.AddSection(s1, s2, s3);

            c3.AddSection(s1, s2, s3);

            c1.ShowAllSection();

            c2.ShowAllSection();


            f1.AddSection(s1, s2);

            f2.AddSection(s1, s2);

            f1.ShowInfo();

            f2.ShowInfo();



        }
    }
}