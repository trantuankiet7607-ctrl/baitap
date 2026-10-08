using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace baitap.file
{
    public class baitapfile
    {
        public static void Main(string[] args)
        {
            //            1.Write a program in C# Sharp
            //1.to create a blank file on the disk.
            File.Create("sotay1.txt").Close();
            //2.to remove a file from the disk.
            File.Delete("sotay1.txt");
            //3.to create a file and add some text.
            File.Create("sotay2.txt").Close();
            File.WriteAllText("sotay2.txt", "Toi la Tuan Kiet");

            //4.create a text file and read it.
            string docfile = File.ReadAllText("sotay2.txt");
            Console.WriteLine(docfile);
            //5.to create a file and write an array of strings to the file.
            File.Create("sotay3.txt").Close();
            string[] mang = { "mot", "hai", "ba" };
            File.WriteAllLines("sotay3.txt", mang);
            //6.to append some text to an existing file.
            File.AppendAllText("sotay3.txt", "bon");
            //7.to create and copy the file to another name and display the content.
            File.Copy("sotay3.txt", "copy.txt", true);
            Console.Write(File.ReadAllText("copy.txt"));
            //8.create a file and move it into the same directory with another name.
            File.Create("sotay4.txt").Close();
            File.Move("sotay4.txt", "sotay4moi.txt");
            //9.read the first line of a file.
            string[] cacdong = File.ReadAllLines("sotay3.txt"); 
            Console.WriteLine(cacdong[0]);
            //10.to create and read the last line of a file.
            Console.WriteLine(cacdong[cacdong.Length - 1]);
            //11.create and read the last n lines of a file.
            static void ndongcuafile(int n)
            {
                string[] cacdong = File.ReadAllLines("sotay3.txt");
                for (int i = 0; i <= n -1; i++)
                Console.WriteLine(cacdong[i]);
            }
            ndongcuafile(2);
            //12.to read a specific line from a file.
            static void specificline(int n)
            {
                string[] cacdong = File.ReadAllLines("sotay3.txt");
                Console.WriteLine(cacdong[n -1]);
            }
            //13.to count the number of lines in a file.
            Console.WriteLine("Tong so dong: " + cacdong.Length);
            //14.To print the structure of specific folder(include files)
            static void cautruc(string a)
            {
                string[] thumuc = Directory.GetDirectories(a);

                foreach (string x in thumuc)
                {
                    Console.WriteLine("[Thu Muc] " + x);
                }
                string[] tep = Directory.GetFiles(a);

                foreach (string x in tep)
                {
                    Console.WriteLine("[File] " + x);
                }
            }
        }
    }
}
