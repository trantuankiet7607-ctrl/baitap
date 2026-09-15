using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;
using System.Net;
using System.Text;

namespace baitap.ss6
{
    public class baitapfunction
    {
        //bai1
        static int tinhtong(int a, int b)
        {
            return a + b;
        }
        //bai2
        static bool chanle(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //bai3
        static int solonnhat(int a, int b, int c)
        {
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
        //bai4
        static long giaithua(int a)
        {
            long ketqua = 1;
            for (int i = 1; i <= a; i++)
            {
                ketqua = ketqua * i;
            }
            return ketqua;
        }
        //bai5
        static string daonguocchuoi(string input)
        {
            char[] a = input.ToCharArray();
            Array.Reverse(a);
            string b = new string(a);
            return b;
        }
        //bai6
        static bool songuyento(int a)
        {
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
        //bai7
        static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int c = a + b;
                a = b;
                b = c;
            }
        }
        //bai8
        static int DemNguyenAm(string s)
        {
            char[] a = s.ToCharArray();
            int dem = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' ||
                    a[i] == 'o' || a[i] == 'u')
                {
                    dem++;
                }
            }

            return dem;
        }
        public static void Main(string[] args)
        {
            Console.Write(DemNguyenAm("Tuan Kiet"));
        }
    }
}
