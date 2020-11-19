using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    class section
    {

        private string name;
        private string id;
        private string faculty;
        private float time;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }



        public float time
        {
            set { time = value; }
            get { return time; }
        }
        public Section(string name, string id, float time)

        { this.Name = Name; }


        public void showInfo()

        {
            Console.WriteLine("Section: " + Name);



        }


    }
}
