using System;

namespace Task._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age = 0;
            int Experince = 0;
            int Sage = 0;


            do
            {
                Console.Write("Teacher Age:");
                Age = Convert.ToInt32(Console.ReadLine());

            } while (Age < 0);

            do
            {
                Console.Write("Experince:");
                Experince = Convert.ToInt32(Console.ReadLine());
            } while (Experince < 0 || Experince > 80);
            Teacher teacher = new Teacher("Sunal", "Jabili", Age, Experince);
            teacher.ShowInfo();

            do
            {
                Console.Write("Student Age:");
                Sage = Convert.ToInt32(Console.ReadLine());

            } while (Sage < 0);
            Student student = new Student("Kamal", "Abishli", Sage);
            student.ShowInfo();


            Console.WriteLine("Group:");
            Group group = new Group();
            group.AddStudent(student);
            foreach (var item in group.students)
            {
                item.ShowInfo();
            }
            group.AddStudent(student);
            foreach (var item in group.ArrS)
            {
                Console.WriteLine(item);
            }

        }
    }
}
