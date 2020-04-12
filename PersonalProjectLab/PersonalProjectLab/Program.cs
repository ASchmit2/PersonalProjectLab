using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cartype;
            string Input;
            double Mileage = 0;
            double Tanksize = 0;
            int Fuellevel = 0;
            int Milespertank = 0;
            int Drivelocation = 0;

            Console.WriteLine("***Vehicle Mileage and Miles left to Empty Calculator\n");
            Console.WriteLine("Choose the number of one option:");
            Console.WriteLine("1: Ford Taurus");
            Console.WriteLine("2: Chevy Camaro");
            Console.WriteLine("3: Ford F-250");
            Console.WriteLine("4: Bugatti Divo");
            Console.WriteLine("5: Custom options\n");

            Input = Console.ReadLine();
            Cartype = int.Parse(Input);

            Console.WriteLine("\nWhere do you usually drive you car?\n");
            Console.WriteLine("Choose the number of one option.");
            Console.WriteLine("1: City");
            Console.WriteLine("2: Highway");
            Console.WriteLine("3: Both\n");
            Input = Console.ReadLine();
            Drivelocation = int.Parse(Input);

            if (Cartype < 1 || Cartype > 5 )
            {
                Console.WriteLine("That was not an option. Try again.");
            }
            else
            {
                if (Cartype == 1)
                {
                    Tanksize = 19;
                    if (Drivelocation == 1)
                    {
                        Mileage = 18;
                    }
                    if (Drivelocation == 2)
                    {
                        Mileage = 26;
                    }
                    if (Drivelocation == 3)
                    {
                        Mileage = 22;
                    }
                }

                if (Cartype == 2)
                {
                    Tanksize = 19;
                    if (Drivelocation == 1)
                    {
                        Mileage = 22;
                    }
                    if (Drivelocation == 2)
                    {
                        Mileage = 31;
                    }
                    if (Drivelocation == 3)
                    {
                        Mileage = 26.5;
                    }
                }

                if (Cartype == 3)
                {
                    Tanksize = 41;
                    if (Drivelocation == 1)
                    {
                        Mileage = 14.6;
                    }
                    if (Drivelocation == 2)
                    {
                        Mileage = 15.5;
                    }
                    if (Drivelocation == 3)
                    {
                        Mileage = 15.05;
                    }
                }

                if (Cartype == 4)
                {
                    Tanksize = 26.4;
                    if (Drivelocation == 1)
                    {
                        Mileage = 8.77664;
                    }
                    if (Drivelocation == 2)
                    {
                        Mileage = 14.16955;
                    }
                    if (Drivelocation == 3)
                    {
                        Mileage = 10.59525;
                    }
                }

                if (Cartype == 5)
                {

                }
                Console.WriteLine("Your Tank size is " + Tanksize + " gallons and your mileage is " + Mileage + " miles per gallon.");
            }
            
        }
    }
}