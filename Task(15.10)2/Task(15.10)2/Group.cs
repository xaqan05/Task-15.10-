using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15._10_2
{
    internal class Group
    {
        public int No;
        public Student[] Students;


        public Group(int no)
        {
            No = no;
            Students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            Student[] newStudents = new Student[Students.Length + 1];

            for (int i = 0; i < Students.Length; i++)
            {
                newStudents[i] = Students[i];
            }

            newStudents[newStudents.Length - 1] = student;

            Students = newStudents;

            

            /*Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;*/
        }

        public Student SearchStudent(string fullName)
        {
            Student student = null;
            for (int i = 0; i < Students.Length; i++)
            {
                if (fullName == Students[i].FullName)
                {
                    student = Students[i];
                    Console.WriteLine("Axtardiginiz sagird tapildi.");
                    return student;
                }

            }

            return student;
        }

        public void ShowAllStudent()
        {
            for (int i = 0;i < Students.Length; i++)
            {
                Console.WriteLine(Students[i].FullName);
            }
        }
    }
}
