using static System.Reflection.Metadata.BlobBuilder;

namespace Task_15._10_2
{
    internal class Task1
    {
        static void Main(string[] args)
        {

            Group fullStack = new Group(215);

            Student student2 = new Student("Xaqan Ismayilov");
            fullStack.AddStudent(student2);

            Student student3 = new Student("Anar Balacayev");
            fullStack.AddStudent(student3);
            Student student4 = new Student("Nicat Ibrahimli");
            fullStack.AddStudent(student4);

            while (true)
            {
                Console.WriteLine("1.Sagird elave etmek ucun 1 secin.");
                Console.WriteLine("2.Sagird axtarmaq ucun 2 secin.");
                Console.WriteLine("3.Sagirdlerin siyahisini gormek ucun 3 secin.");
                Console.WriteLine("Cixis etmek ucun 0 secin.");
                Console.WriteLine(" ");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {

                    Console.WriteLine("Elave etmek istediyiniz sagirdin ad ve soyadini daxil edin:");
                    string fullName = Console.ReadLine();
                    Student student1 = new Student(fullName);
                    fullStack.AddStudent(student1);
                    Console.WriteLine("Daxil etdiyiniz sagird qrupa elave olundu.");
                    Console.WriteLine("");
                    continue;
                }

                else if (input == 2)
                {
                    Console.WriteLine("Axtarmaq istediyiniz sagirdin ad ve soyadini daxil edin:");
                    string fullName = Console.ReadLine();

                    Student foundStudent = fullStack.SearchStudent(fullName);

                    if (foundStudent != null)
                    {
                        foundStudent.ShowInfo();
                    }
                    else
                    {
                        Console.WriteLine("Axtardiginiz sagird tapilmadi.");
                    }
                    Console.WriteLine("");
                    continue;

                }
                else if (input == 3)
                {
                    fullStack.ShowAllStudent();
                    Console.WriteLine("");
                    continue;
                }
                else if (input == 0)
                {
                    Console.WriteLine("Programndan cixilir");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlis secim etdiniz");
                    Console.WriteLine(" ");
                }
            }


        }
    }
}