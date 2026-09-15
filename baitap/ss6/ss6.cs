using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace baitap.ss6
{
    public class ss6
    {
        static int solonnhat(int a, int b, int c)
        {
            //1.Write a C# function to find the maximum of three numbers
            if (a > b && b > c)
            {
                return a;
            }
            else if (b > a && a > c)
            {
                return b;
            }
            else
            {
                return c;
            }




        }
        static int giaithua(int a)
        {
            //            2.Write a C# function to calculate the factorial of a number (a non-negative
            //integer). The function accepts the number as an argument.

            if (a == 0)
            {
                return 1;
            }

            int giaithua = 1;

            for (int i = 1; i <= a; i++)
            {
                giaithua = giaithua * i;
            }

            return giaithua;
        }
        static bool songuyento(int a)
        {
            //            3.Write a C# function that takes a number as a parameter and checks whether
            //the number is prime or not.

            if (a < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;

                }

            }
            return true;
        }
        static void bai4a(int a)
        { 
        
            //            Viết một hàm C# để in ra:

            //Tất cả các số nguyên tố nhỏ hơn một số cho trước(số này được nhập từ bàn phím).

            Console.Write($"So nguyen to truoc {a} la: ");

            for (int i =2; i <= a; i++)
            {
                if (songuyento(i) == true)
                {
                    Console.WriteLine(i + " ");
                }
            }
         }
        //static int bai4b(int a)
        //{
        //    int dem = 0;
        //    for (int i = 0; i <= a; i++)
        //    {

        //    }
        //}
        public static void Main11(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = 4;
            Console.WriteLine("nhap so gioi han cua bai 4a: ");
            int bai4aa = int.Parse(Console.ReadLine());
            Console.WriteLine(solonnhat(a, b, c));
            Console.WriteLine(giaithua(4));
            Console.WriteLine(songuyento(13));
            bai4a(bai4aa);
        }
    }
}
