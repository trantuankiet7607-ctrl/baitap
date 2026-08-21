using System.Drawing;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class ss2
{
    public static void Main_CU1(string[] args)
    {
        // 1.to Add / Sum Two Numbers.
        Console.WriteLine("cau1");
        Console.Write("Nhap a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Tong la {a + b} ");

        //2.to Swap Values of Two Variables.
        int c = 3;
        int d = 4;
        int T = c;
        Console.WriteLine($"so C la {d}, so d la {T}");

        //3.to Multiply two Floating Point Numbers
        float v = 2.5f;
        float m = 3.5f;
        Console.WriteLine($"Tich m*v = {m * v}");
        //4.to convert feet to meter
        float rate = 0.304f;
        float feet = 3f;
        Console.WriteLine($"{feet} feet bang {feet * rate} met");
        //5.to convert Celsius to Fahrenheit and vice versa
        int C = 35;
        Console.WriteLine($"{C} Celsius = {1.8 * C + 32} Fahrenheit");
        //6.to find the Size of data types
        Console.WriteLine($" Size of double type = {sizeof(double)} bytes");
        //7.to Print ASCII Value(tip: read character, print number of this char)
        char ch = 'A';
        int asciiValue = (int)ch;
        Console.WriteLine($"ASCII of {ch} is: {asciiValue}");
        //8.to Calculate Area of Circle
        float r = 3f;
        Console.WriteLine($"Area of Circle = {r * r * Math.PI}");
        //9.to Calculate Area of Square
        float canh = 5f;
        Console.WriteLine($"area of square is {canh * canh}");
        //10.to convert days to years, weeks and days
        int totalDays = 376;
        int years = totalDays / 365;
        int weeks = (totalDays % 365) / 7;
        int days = (totalDays % 365) % 7;
        Console.WriteLine($"{totalDays} days = {years} years ,{weeks} weeks, and {days} days");
        
    }
}