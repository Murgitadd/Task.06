using System;

namespace codek
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Doe", "GroupA", 70);
            Student student2 = new Student("Alice", "Smith", "GroupB", 85);

            Console.WriteLine("Student 1 Info:");
            student1.GetInfo();

            Console.WriteLine("Student 2 Info:");
            student2.GetInfo();

            Console.WriteLine("Checking Graduation Status:");
            student1.CheckGraduation();
            student2.CheckGraduation();

            Console.WriteLine("Diploma Degrees:");
            student1.GetDiplomDegree();
            student2.GetDiplomDegree();
        }
    }
}
