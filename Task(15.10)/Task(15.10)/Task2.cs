namespace Task_15._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Xaqan", "Ismayilov", "BP-215", 63);
            student1.GetInfo();
            student1.GetDiplomDegree();
            student1.CheckGraduation();
        }
    }


    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public double Point;
        public bool isGraduated;





        public Student(string name, string surname, string group, double point)
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
            this.Point = point;

            if (point >= 65)
            {
               isGraduated = true;
            }
        }



        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}");
        }

        public void CheckGraduation()
        {
            if (isGraduated)
            {
                Console.WriteLine("Bu telebe mezun olub");
            }
            else
            {
                Console.WriteLine("Bu telebe mezun olmayib");
            }
        }

        public void GetDiplomDegree()
        {
            if (Point > 90)
            {
                Console.WriteLine("Yuksek Seref:" + Point);
            }
            else if (Point > 80)
            {
                Console.WriteLine("Seref:" + Point);
            }
            else if (Point >= 65)
            {
                Console.WriteLine("Adi:" + Point);
            }
            else
            {
                Console.WriteLine("Diplomu yoxdur");
            }
        }

    }


}
