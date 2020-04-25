using System;
namespace PersonalProjectLab
{
    public class MileageCalculator
    {

        public MileageCalculator()
        {
        }

        public double MilesToEmpty(double mileage, double tankSize, double fuelLevel)
        {
            double output = 0;

            output = tankSize * fuelLevel * mileage;
            
            return output;
        }

        public double MilesToEmpty2(double milesPerTank, double fuelLevel)
        {
            double output = 0;

            output = milesPerTank * fuelLevel;

            return output;
        }

        public double CalculateMileage(double milesPerTank, double tankSize)
        {
            double output = 0;

            output = milesPerTank / tankSize;

            return output;
        }
    }   
}
