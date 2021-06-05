using System;

namespace CSharpEx_1
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");
            
            double meter, feet,lbs,kg,frhn,celsius;
            
            Console.WriteLine("Enter feet :");
            Console.WriteLine("Enter meteres :");
            Console.WriteLine("Enter the value in kilograms :");
            Console.WriteLine("Enter the value in pounds :");
            Console.WriteLine("Enter the value in celsius :");
            Console.WriteLine("Enter the value in farahnite :");
            feet = Convert.ToInt32(Console.ReadLine());
            meter = Convert.ToInt32(Console.ReadLine());
            kg = Convert.ToInt32(Console.ReadLine());
            lbs = Convert.ToInt32(Console.ReadLine());
            celsius = Convert.ToInt32(Console.ReadLine());
            frhn = Convert.ToInt32(Console.ReadLine());
            meter = feet / 3.2808399;
            feet = meter / 0.3048;
            lbs=kg / 0.45359237;
            kg=lbs*0.45359237;
            frhn = (celsius*1.8) + 32;
            celsius = (frhn - 32) / 1.8;
            Console.WriteLine("\nFeet in meter : " + meter);
            Console.WriteLine("\nmeter in feet : " + feet);
            Console.WriteLine("\nKilograms in pounds : " + lbs);
            Console.WriteLine("\nPounds in Kg : " + kg); 
            Console.WriteLine("\nFarehnite in Celsius : " + frhn );
            Console.WriteLine("\nCelsius in farhanite : " + celsius);

                     
            Console.ReadKey();
        }
    }
}
