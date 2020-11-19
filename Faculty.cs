using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class Faculty
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
       
        private Section[] sections;
        private int sectioncount;
        public int sectionCount
        {
            get { return sectionCount; }

            set { sectionCount = value; }
        }

        public Section()
        {
            section = new Section[100];
            sectionCount = 0;
        }
        public Faculty(string name)
        {
            this.name = name;
            sections = new Section[100];
            sectionCount = 0;
        }
        public void AddSection(params Section[] section)
        {
            foreach (var sec in section)
            {
                if (sectionCount < 100)
                    this.sections[sectionCount++] = sec;
                else
                    Console.WriteLine("No sections");
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

    public Sections SearchSections(string id)
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




}
