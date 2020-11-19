using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Course {

        private string cName;
        public string Name
        {
            get { return cName; }
            set { cName = value; }
        }

        private string cId;
        public string Id
        {
            get { return cId; }
            set { cId = value; }
        }
        private Section [] sections;
        private int sectioncount;
        public int sectionCount
        {
            get { return sectionCount; }

            set { sectionCount = value; }
        }

        public Course () {
            {
                section = new Section[100];
                sectionCount = 0;

            }
            Public Course (string name)
            {
                this.name = name;
                sections = new Section[100];
                sectionCount = 0;
            }
            public void AddSection(params section[] section)
            {
                foreach (var sec in section)
                {
                    if (sectionCount < 100)
                        this.sections[sectionCount++] = sec;
                    else
                        Console.WriteLine("No available sections");
                }

            }

        }
        public void ShowAllSections()
        {
            for (int i = 0; i < sectionCount; i++)
            {
                section[i].ShowInfo();
            }
        }

        public Section SearchSections(string id)
        {
            Sections s = null;
            for (int i = 0; i < sectionCount; i++)
            {
                if (id.Equals(Sections[i].Id))
                {
                    s = sections[i];
                    break;
                }
            }

            return c;
        }




    } }
