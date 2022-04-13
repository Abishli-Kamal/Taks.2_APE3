using System;
using System.Collections.Generic;
using System.Text;

namespace Task._2
{
    internal class Teacher : Person
    {
        public int Id { get; set; }
        public static int num=1;
        private int _experience;
        public int Experince
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value>0&&value<80)
                {
                    _experience = value;
                }
            }
        }

        public Teacher(string name,string surname,int age,int experince):base(name,surname,age)
        {
            Id = num;
            num++;
            Experince = experince;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Age:{Age} Experince:{Experince}");
        }
    }
}
