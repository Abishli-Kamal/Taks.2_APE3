using System;
using System.Collections.Generic;
using System.Text;

namespace Task._2
{
    internal class Student:Person
    {
        public int Id { get; set; }
        public static int num1=1;
        public string[] Lessons;

        public Student(string name,string surname,int age):base(name,surname,age)
        {
            Id = num1;
            num1++;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Age:{Age} ");
        }
    }
}
