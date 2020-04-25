using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int carType;
            string input;
            double mileage = 0;
            double tankSize = 0;
            double fuelLevel = 0;
            double milesPerTank = 0;
            double milesToEmpty = 0;
            int driveLocation = 0;
            int optionChoice;

            Console.WriteLine("***Vehicle Mileage and Miles left to Empty Calculator***\n");
            Console.WriteLine("Choose the number of one option:");
            Console.WriteLine("1: Ford Taurus");
            Console.WriteLine("2: Chevy Camaro");
            Console.WriteLine("3: Ford F-250");
            Console.WriteLine("4: Bugatti Divo");
            Console.WriteLine("5: Custom options\n");

            input = Console.ReadLine();
            carType = int.Parse(input);

            Console.WriteLine("\nWhere do you usually drive you car?\n");
            Console.WriteLine("Choose the number of one option:");
            Console.WriteLine("1: City");
            Console.WriteLine("2: Highway");
            Console.WriteLine("3: Both\n");
            input = Console.ReadLine();
            driveLocation = int.Parse(input);

            Console.WriteLine("\nWhat is your current fuel level? (type fraction of tank in decimal form)");
            input = Console.ReadLine();
            fuelLevel = double.Parse(input);

            if (carType < 1 || carType > 5 )
            {
                Console.WriteLine("That was not an option. Try again.");
            }
            else
            {
                if (carType == 1)
                {
                    tankSize = 19;
                    if (driveLocation == 1)
                    {
                        mileage = 18;
                    }
                    if (driveLocation == 2)
                    {
                        mileage = 26;
                    }
                    if (driveLocation == 3)
                    {
                        mileage = 22;
                    }
                }

                if (carType == 2)
                {
                    tankSize = 19;
                    if (driveLocation == 1)
                    {
                        mileage = 22;
                    }
                    if (driveLocation == 2)
                    {
                        mileage = 31;
                    }
                    if (driveLocation == 3)
                    {
                        mileage = 26.5;
                    }
                }

                if (carType == 3)
                {
                    tankSize = 41;
                    if (driveLocation == 1)
                    {
                        mileage = 14.6;
                    }
                    if (driveLocation == 2)
                    {
                        mileage = 15.5;
                    }
                    if (driveLocation == 3)
                    {
                        mileage = 15.05;
                    }
                }

                if (carType == 4)
                {
                    tankSize = 26.4;
                    if (driveLocation == 1)
                    {
                        mileage = 8.77664;
                    }
                    if (driveLocation == 2)
                    {
                        mileage = 14.16955;
                    }
                    if (driveLocation == 3)
                    {
                        mileage = 10.59525;
                    }
                }

                MileageCalculator calculator = new MileageCalculator();

                if (carType == 5)
                {
                    Console.WriteLine("\nWhat are your choices of input?");
                    Console.WriteLine("\nChoose the number of one option:");
                    Console.WriteLine("1: Tank size and mileage");
                    Console.WriteLine("2: Miles per tank and tank size");
                    Console.WriteLine("3: Miles per tank and mileage");
                    input = Console.ReadLine();
                    optionChoice = int.Parse(input);

                    if (optionChoice == 1)
                    {
                        Console.WriteLine("\nWhat is your car's tank size in gallons?\n");
                        input = Console.ReadLine();
                        tankSize = int.Parse(input);

                        Console.WriteLine("\nWhat is your car's mileage?\n");
                        input = Console.ReadLine();
                        mileage = int.Parse(input);
                    }
                    if (optionChoice == 2)
                    {
                        Console.WriteLine("\nWhat is your car's miles per tank?\n");
                        input = Console.ReadLine();
                        milesPerTank = int.Parse(input);

                        Console.WriteLine("\nWhat is your car's tank size?\n");
                        input = Console.ReadLine();
                        tankSize = int.Parse(input);

                        mileage = calculator.CalculateMileage(milesPerTank, tankSize);
                    }
                    if (optionChoice == 3)
                    {
                        Console.WriteLine("\nWhat is your car's miles per tank?\n");
                        input = Console.ReadLine();
                        milesPerTank = int.Parse(input);

                        Console.WriteLine("\nWhat is your car's mileage?\n");
                        input = Console.ReadLine();
                        mileage = int.Parse(input);

                    }


                }

                

                if (carType != 5)
                {
                    milesToEmpty = calculator.MilesToEmpty(mileage, tankSize, fuelLevel);
                }
                else
                {
                    milesToEmpty = calculator.MilesToEmpty2(milesPerTank, fuelLevel);
                }

                Console.WriteLine("\nYour Miles per gallon are " + mileage + " miles per gallon and your miles until empty are " + milesToEmpty + " miles.");
            }
            
        }
    }
}