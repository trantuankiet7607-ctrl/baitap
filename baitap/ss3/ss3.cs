using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace baitap.ss3
{
    internal class ss3
    {
        public static void Main(string[] args)
        { //            ▸The Celsius scale is centigrade, 100 divisions separate the freezing point
          //from the boiling point of water.On the Fahrenheit scale of Anglo - Saxons,
          //these two points are 180 degrees apart.The Kelvin scale is an absolute
          //scale used in science.
          //▸Create a C# program to convert from degrees Celsius to Kelvin and
          //Fahrenheit. Request the user the number of degrees celsius to convert
          //them using the following conversion tables 
            Console.Write("Celsius: ");
            int celsius = int.Parse(Console.ReadLine()!);
            int Kelvin = celsius + 273;
            int Fahrenheit = celsius *18 / 10 + 32;
            Console.WriteLine($"{celsius} Celsius = {Kelvin} Kelvin");
            Console.WriteLine($"{celsius} Celsius = {Fahrenheit} Fahrenheit");


            //            Create a program in C# for calculate the surface and volume of a sphere, given its
            //radius.
            //-surface = 4 * pi * radius squared
            //- volume = 4 / 3 * pi * radius cubed
            //- Input
            //• 60
            //- Output
            //• Surface: 45238,93
            //• Volume: 678584,1
         

            Console.Write("Enter the R: ");
            double R = double.Parse(Console.ReadLine()!);
            double S = 4 * Math.PI * R * R;
            double V = (4 / 3) * Math.PI * R * R * R;
            Console.WriteLine($"Surface is {S} and Volume is {V}");

            //            ▸Write a program in C# that calculates the result of adding, subtracting,
            //multiplying and dividing two numbers entered by the user.
            //-In addition you should also calculate the rest of the division on the last

            Console.Write("Enter number1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number2: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int minus = a - b;
            int mul = a * b;
            double div = a / b;
            double mod = a % b;
            Console.WriteLine($"sum is: {sum}");
            Console.WriteLine($"minus is: {minus}");
            Console.WriteLine($"mul is: {mul}");
            Console.WriteLine($"div is: {div}");
            Console.WriteLine($"mod is: {mod}");


















        }

    }
}
