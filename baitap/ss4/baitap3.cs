using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace baitap.ss4
{
    internal class baitap3
    {
        public static void Main(string[]args)
        {
            static void bai1()
            {
                Console.Write("Nhap so muon kiem tra: ");
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine($"{a} la so chan");
                }
                else
                {
                    Console.WriteLine($"{a} la so le");
                }
            }
            static void bai2()
            {
                Console.Write("Nhap so thu nhat: ");
                double so1 = double.Parse(Console.ReadLine());
                Console.Write("Nhap so thu hai: ");
                double so2 = double.Parse(Console.ReadLine());
                Console.Write("Nhap so thu ba: ");
                double so3 = double.Parse(Console.ReadLine());
                if (so1 >= so2 && so1 >= so3)
                {
                    Console.WriteLine($"so lon nhat la: {so1}");
                }
                else if (so2 >= so1 && so2 >= so3)
                {
                    Console.WriteLine($"So lon nhat la: {so2}");
                }
                else
                {
                    Console.WriteLine($"so lon nhat la: {so3}");
                }
            }
            static void bai3()
            {
                Console.Write("Canh thu nhat: ");
                float ab = float.Parse(Console.ReadLine()!);

                Console.Write("Canh thu hai: ");
                float ac = float.Parse(Console.ReadLine()!);

                Console.Write("Canh thu ba: ");
                float bc = float.Parse(Console.ReadLine()!);


               if (ab + ac > bc && ab + bc > ac && ac + bc > ab)
                {
                  
                    if (ab == ac && ac == bc)
                    {
                        Console.WriteLine("=> Day la Tam giac deu (Equilateral triangle).");
                    }
                    else if (ab == ac || ab == bc || ac == bc)
                    {
                        Console.WriteLine("=> Day la Tam giac can (Isosceles triangle).");
                    }
                    else
                    {
                        Console.WriteLine("=> Day la Tam giac thuong (Scalene triangle).");
                    }
                }
                else
                {
                    Console.WriteLine("=> LOI: Ba canh vua nhap khong the tao thanh mot tam giac!");
                }
            }
            static void bai4()
            {
                Console.Write("Nhập giá trị tọa độ X: ");
                int x = int.Parse(Console.ReadLine()!);

                Console.Write("Nhập giá trị tọa độ Y: ");
                int y = int.Parse(Console.ReadLine()!);

                if (x > 0 && y > 0)
                {
                    Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở Góc phần tư thứ Nhất (First quadrant).");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở Góc phần tư thứ Hai (Second quadrant).");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở Góc phần tư thứ Ba (Third quadrant).");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở Góc phần tư thứ Tư (Fourth quadrant).");
                }
                else if (x == 0 && y == 0)
                {
                    Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ngay tại Gốc tọa độ (Origin).");
                }
                else if (x == 0 && y != 0)
                {
                    Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm trên Trục tung (Y-axis).");
                }
                else
                {
                    Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm trên Trục hoành (X-axis).");
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
                        float x = -b / 2 * a;
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
        }

    }
}
