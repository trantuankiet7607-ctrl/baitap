 using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace baitap.ss4
{
    internal class ss4
    {
        public static void Main2cu(string[] args)
        {
            static void bai1()
            {
                //                Write a C# Sharp program that takes two numbers as input and
                //performs an operation(+,-,*,x,/) on them and displays the result of that
                //operation
                Console.Write("Nhap so a: ");
                double a = double.Parse(Console.ReadLine()!);
                Console.Write("Nhap so b: ");
                double b = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"{a} + {b} = {a + b}");
                Console.WriteLine($"{a} - {b} = {a - b}");
                Console.WriteLine($"{a} * {b} = {a * b}");
                Console.WriteLine($"{a} : {b} = {a / b:F2}");

            }
            static void bai2()
            {
                //                Write a C# Sharp program to display certain values of the function x = y2
                //+ 2y + 1(using integer numbers for y, ranging from - 5 to + 5)
                Console.WriteLine("Bieu thuc la: y^2 + 2y + 1");
                int giatri = 0;
                for (int y = -5; y <= 5; y++)
                {
                    giatri = y * y + 2 * y + 1;
                    Console.WriteLine($"Gia tri bieu thuc la: {giatri}");
                }

            }
            static void bai3()
            {
                //                . Write a C# Sharp program that takes distance and time (hours, minutes,
                //seconds) as input and displays speed in kilometers per hour(km / h) and
                //miles per hour(miles/ h)
                Console.Write("Nhap quang duong (met): ");
                double s = double.Parse(Console.ReadLine());
                Console.Write("Nhap gio: ");
                double h = double.Parse(Console.ReadLine());
                Console.Write("Nhap phut: ");
                double m = double.Parse(Console.ReadLine());
                Console.Write("Nhap giay: ");
                double se = double.Parse(Console.ReadLine());
                double tth = h + (m / 60) + (se / 3600);
                double v = (s / 1000) / tth;
                double V = (s / 1609.344) / tth;

                Console.WriteLine($"van toc (km/h): {v} km/h");
                Console.WriteLine($"van toc (dam/h): {V} dam/h");
            }
            static void bai4()
            {
                //                Write a C# Sharp program that takes the radius of a sphere as input and
                //calculates and displays the surface and volume of the sphere.V =
                //4 / 3 * π * r



                Console.Write("Enter the R: ");
                double R = double.Parse(Console.ReadLine()!);
                double S = 4 * Math.PI * R * R;
                double V = (4 / 3) * Math.PI * R * R * R;
                Console.WriteLine($"Surface is {S} and Volume is {V}");
            }
            static void bai5()
            {
                Console.Write("Nhập vào một ký tự bất kỳ: ");
                char inputChar = char.Parse(Console.ReadLine()!);
                char lowerChar = char.ToLower(inputChar);
                if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
                {
                    Console.WriteLine($"'{inputChar}' là một nguyên âm (vowel).");
                }
                else if (inputChar >= '0' && inputChar <= '9')
                {
                    Console.WriteLine($"'{inputChar}' là một chữ số (digit).");
                }
                else
                {
                    Console.WriteLine($"'{inputChar}' là một ký tự khác (other symbol).");

                }


            }
            static void ptbac2()
                {
                Console.WriteLine("y = ax^2 + bx + c");
                Console.Write("Nhap a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Nhap b: ");
                float b = float.Parse(Console.ReadLine()); 
                Console.Write("Nhap c: ");
                float c = float.Parse(Console.ReadLine());
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("pt vo so nghiem");
                        }
                        else
                        {
                            Console.WriteLine("vo nghiem");
                        }
                    }
                    else
                    {
                        float x = -c / b;
                        Console.WriteLine($"Nghiem la x: {x}");
                    }
                }
                else
                {
                    float delta = (float)Math.Pow(b, 2) - 4 * a * c;
                    if (delta < 0)
                    {
                        Console.WriteLine("phuong trinh vo nghiem");
                    }
                    else if (delta == 0)
                    {
                        Console.WriteLine("phuong trinh co nghiem kep la: ");
                        float x = -b/2*a;
                        Console.WriteLine($"x : {x} ");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                        Console.WriteLine($"x1 = {((-b) - Math.Sqrt(delta)) / (2 * a)}");
                        Console.WriteLine($"x2 = {((-b) + Math.Sqrt(delta) / (2 * a))}");
                    }
                        

                    
                }
                



            }
            ptbac2();









        }
    }
}