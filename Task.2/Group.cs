using System;
using System.Collections.Generic;
using System.Text;

namespace Task._2
{
    internal class Group
    {
        public string GroupNo { get; set; }
        public Student [] students=new Student [0];
        public string[] ArrS = new string[0];



        public void AddStudent (Student St)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length-1] = St;
        }

    }
}
