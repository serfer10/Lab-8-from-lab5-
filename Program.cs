using System;

namespace Lab_5
{

    public delegate void EvDel();
    public delegate int ChildsDel(int childs);
    class Event
    {
        public event EvDel ev;

        public void Choice()
        {
            ev();
        }

    }

    struct user
    {
        public int height;
        public int experience;
    }

    class Program
    {
        public static void StructShow(user personS)
        {
            Console.WriteLine($"Height: {personS.height}");
            Console.WriteLine($"Work Experience: {personS.experience}");
        }


        public static void Profession()
        {
            if (ProfBuf == 1)
                Console.WriteLine("You choosed builder\n");
            else if (ProfBuf == 2)
                Console.WriteLine("You choosed programmer\n");
            else
                Console.WriteLine("You are workless\n");
        }
        static int ProfBuf;

        static void Main(string[] args)
        {
            Event ev = new Event();
            ev.ev += Profession;

            EvDel message = delegate
            {
                Console.WriteLine("You should Work Harder");
            };
        
            int child=0;
            user personS = new user();
            people Tom = new people();
            Console.WriteLine("Write Fist name");
            Tom.FirstName = Console.ReadLine();
            Console.WriteLine("Write Last name");
            Tom.LastName = Console.ReadLine();
            Console.WriteLine("Write father name");
            Tom.FatherName = Console.ReadLine();
            Console.WriteLine("Enter count of your childs: ");
            bool check = false;
            check = false;
            while (!check)
            {
                try
                {
                    child = Convert.ToInt32(Console.ReadLine());
                    check = true;

                }
                catch
                {
                    Console.WriteLine("You shuld enter a number");
                }
            }

            ChildsDel money = x => x*1000;

            Console.WriteLine($"For your childs you need: {money(child)} rub");

            check = false;
            Console.WriteLine("Enter age");         
            while (!check)
            {
                    try
                    {
                        Tom.Age= Convert.ToInt32(Console.ReadLine());
                        check = true;

                    }
                    catch
                    {
                        Console.WriteLine("You shuld enter a number");
                    }
            }

            Console.WriteLine("Enter height");
            check = false;
            while (!check)
            {
                try
                {
                    personS.height = Convert.ToInt32(Console.ReadLine());
                    check = true;

                }
                catch
                {
                    Console.WriteLine("You shuld enter a number");
                }
            }
            Console.WriteLine("Enter experience");
            check = false;
            while (!check)
            {
                try
                {
                    personS.experience = Convert.ToInt32(Console.ReadLine());
                    check = true;

                }
                catch
                {
                    Console.WriteLine("You shuld enter a number");
                }
            }

            Console.WriteLine("Choose your profession\n1:Builder\n2:Programmer\nElse:WorkLess");
            check = false;
            while (!check)
            {
                try
                {
                    ProfBuf = Convert.ToInt32(Console.ReadLine());
                    check = true;

                }
                catch
                {
                    Console.WriteLine("You shuld enter a number");
                }
            }

            ev.Choice();
            switch (ProfBuf)
            {
                case 1: Builder TomB = new Builder();
                    TomB.EnterCategory();
                    TomB.StartWork();
                    message();
                    people.Print(Tom);
                    StructShow(personS);
                    TomB.Profession();
                    TomB.ShowCategory(); break;
                case 2: Programmer TomP = new Programmer();
                    TomP.EnterCategory();
                    Tom.StartWork();
                    message();
                    people.Print(Tom);
                    StructShow(personS);
                    TomP.Profession();
                    TomP.ShowCategory(); break;
                default: WotkLess TomW = new WotkLess();
                    message();
                    TomW.StartWork();
                    people.Print(Tom);
                    StructShow(personS);
                    TomW.Profession();
                    TomW.ShowCategory(); break;
            }

        }
    }
}
