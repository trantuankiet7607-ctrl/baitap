using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Net;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace baitap.ss8
{
    public class ss8
    {
    //        ▸Write a program in C# Sharp
    //-to input a string and print it.
    static void bai1()
        {
            Console.Write("Nhap string cua ban: ");
           string a =  Console.ReadLine();
            Console.WriteLine($"string cua ban la: {a}");
        }
        //-to find the length of a string without using a library function.
        static int bai2(string a)
        {
            int dem = 0;
            foreach (int i in a)
            {
                dem = dem + 1;
            }
            return dem;
        }
        //-to separate individual characters from a string.
        static void bai3(string a)
        {
            foreach (char i in a)
            {
                Console.Write(i + " ");
            }
            
        }
        //-to print individual characters of the string in reverse order.
        static void bai4(string a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
        }

        //-to count the total number of words in a string.
        static int bai5(string a)
        {
            int dem = 0;
            int demdau = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ' || a[i] == '.' || a[i] == ',')
                {
                    demdau++;
                }
                dem++;
            }
            return (dem - demdau);
        }
        //-to compare two strings without using a string library functions.
        static bool bai6(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }    
            return true;
        }

        //-to count the number of alphabets, digits, and special characters in a string.
        static void bai7(string a)
        {
            int sochu = 0;
            int soso = 0;
            int sokytu = 0;
            foreach (var i in a)
            {
                if (i >= 'a' && i <= 'z' || i >= 'A' && i <= 'Z')
                {
                    sochu++;
                }

                else if (i >= '0' && i <= '9')
                {
                    soso++;

                }
                else
                {
                    sokytu++;
                }
            }
            Console.WriteLine($"so chu cai la: {sochu}");
            Console.WriteLine($"so chu so la: {soso}");
            Console.WriteLine($"so ky tu la: {sokytu}");

        }
        //-to count the number of vowels or consonants in a string.
        static void bai8(string a)
        {
            int vol = 0;
            int con = 0;
            foreach(char i in a)
            {
                if (i == 'a' || i == 'o' || i == 'e' || i == 'u' || i == 'i')
                {
                    vol++;
                }
                else
                {
                    con++;
                }

            }
            Console.WriteLine($"So vowels la: {vol}");
            Console.WriteLine($"So consonants la: {con}");
        }
        //-to check whether a given substring is present in the given string.
        static bool bai9(string a, string b)
        {
            bool found = false;

            for (int i = 0; i <= a.Length - b.Length; i++)
            {
                if (a.Substring(i, b.Length) == b)
                {
                    found = true;
                    break;
                }
            }

            return found;
        }
        //-to search for the position of a substring within a string.
        static int bai10(string a, string b)
        {
            for (int i = 0; i <= a.Length - b.Length; i++)
            {
                if (a.Substring(i, b.Length) == b)
                {
                    return i;
                }
            }

            return -1;
        }
        //-to check whether a character is an alphabet and not and if so, check for the case.
        static void bai11(char c)
        {
            if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("La chu cai - Chu hoa");
            }
            else if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine("La chu cai - Chu thuong");
            }
            else
            {
                Console.WriteLine("Khong phai chu cai");
            }
        }
        //-to find the number of times a substring appears in a given string.
        static int bai12(string a ,string b)
        {
            int dem = 0;


            for (int i = 0; i <= a.Length - b.Length; i++)
            {
                bool khop = true;

                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i + j] != b[j])
                    {
                        khop = false;
                        break;
                    }
                }

                if (khop)
                {
                    dem++;
                }
            }


        
            return dem;
        }
        //-to insert a substring before the first occurrence of a string.
        static string bai13(string a, string b, string c)
        {
            int vitri = -1;

            if (a.Length >= b.Length)
            {
                for (int i = 0; i <= a.Length - b.Length; i++)
                {
                    bool khop = true;
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i + j] != b[j])
                        {
                            khop = false;
                            break;
                        }
                    }

                    if (khop)
                    {
                        vitri = i;
                        break;
                    }
                }
            }

            if (vitri == -1)
            {
                return a;
            }

            string ketqua = "";

            for (int i = 0; i < vitri; i++)
            {
                ketqua += a[i];
            }

            ketqua += c;

            for (int i = vitri; i < a.Length; i++)
            {
                ketqua += a[i];
            }

            return ketqua;
        }
        public static void Main(string[] args)
        {
            //bai1();
            //Console.Write(bai2("a bcd"));
            //bai3("aedjdnfj");
            //bai4("abjnkdsnkncd");
            //Console.Write(bai5("a,s.d,e.e.a"));
            //Console.Write(bai6("ab,chdk", "abch,dk"));
            //bai7("abc123.,/'");
            //bai8("aoeuiccb");
            //Console.Write(bai9("abchd","abc"));
            //Console.Write(bai10("ab cd","cd"));
            //bai11('A');
            //Console.Write(bai12("abcdab","ab"));
            //Console.Write(bai13("xin chao moi nguoi", "moi", "tat ca "));
        }
    }

}
