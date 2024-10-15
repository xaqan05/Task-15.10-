using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15._10_2
{
    internal class Student
    {
        public string FullName;

        public Student(string fullName)
        {
            FullName = fullName;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Sagirdin ad ve soyadi: {FullName}");
        }
    }
}
