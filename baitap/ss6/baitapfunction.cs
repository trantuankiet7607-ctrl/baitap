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
        //bai9
        static double tinhluythua(double x, int y)

        {
            double luythua = 1;
            for (int i = 1; i <= y; i++)
            {
                luythua = luythua * x;
            }
            return luythua;
        }
        //bai10
        static double tinhtrungbinh(int[] arr)
        {
            if (arr. Length == 0)
            {
                return 0;
            }
            double tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tong = tong + arr[i];
            }
            return (tong / (arr.Length));
        }
        //bai11
        static bool chuoidoixung(string s)
        {
            char[] a = s.ToCharArray();
            int k = a.Length - 1;
            for (int i = 0; i < k; i++)
            {
                if (a[i] != a[k])
                {
                    return false;
                }
                k = k - 1;
            }
            return true;
        }
        //bai12
        static double CelsiusToFahrenheit(double c)
        {
            double f = (1.8 * c) + 32;
            return f;
        }
        //bai13
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i =0; i < arr.Length; i++)
            {
                if (arr[i] <= min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        //bai14
        static int TongCacChuSo(int n)
        {
            int tong = 0;
            while (n > 0)
            {
                tong = tong + (n % 10);
                n = n / 10;
            }
            return tong;
        }
        //bai15
        static void SapXepMang(int[] arr)
        {
            for (int i =0; i < arr.Length; i++)
            {
                for (int j = i +1; j< arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }

                }
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");
            }


        }
        //bai16
        static string XoaTrungLap(string s)
        {
            string ketqua = "";
            for (int i=0; i < s.Length; i++)
            {
                if (ketqua.IndexOf(s[i]) == -1)
                {
                    ketqua = ketqua + s[i];
                }
            }
            return ketqua;
        }
        //bai17
        static int UCLN(int a, int b)
        {
            while (b != 0 )
            {
                int du = a % b;
                a = b;
                b = du;
            }
            return a;
        }
        //bai18
        static string DecimalToBinary(int n)
        {
            string ketqua = "";
            while (n != 0)
            {
                int a = n / 2;
                int b = n % 2;
                n = a;
                ketqua = b.ToString() + ketqua;
            }
            return ketqua;
        }
        //bai19
        static bool KiemTraNamNhuan(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }
        //bai20
        static int DemSoTu(string sentence)
        {
            string[] tu = sentence.Split(' ', ',', ';', '.');
            int dem = 0;
            for(int i=0;i<tu.Length;i++)
            {
                dem = dem + 1;
            }
            return dem;
        }

        public static void Main99(string[] args)
        {
            Console.Write(DemSoTu("Học lập trình C#,rất thú vị"));
            //SapXepMang([3 ,2 ,4 ,6]);

        }
    }
}
