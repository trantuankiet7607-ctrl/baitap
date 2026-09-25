using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Resources;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace baitap.ss7
{
    public class ss7
    {

        // Create a random integer values array, then create functions that:
        // 1.to calculate the average value of array elements.
        static float average(int[] arr)
        {
            float sum = 0;
            foreach (int i in arr)
            {
                sum = sum + i;
            }
            return( float) sum / arr.Length;
        }

        //2.to test if an array contains a specific value.
        static bool kiemtragiatri(int[] arr, int a)
        {
            foreach (int i in arr)
            {
                if (a == i)
                {
                    return true;
                }
               
            }
            return false;
        }
        //3.to find the index of an array element.
        static int index(int[] arr, int a)
        {
            for (int i =0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    return i;
                }
            }
            return -1;
        }
        //4.to remove a specific element from an array.
        static void remove(int[] arr, int a)
        {
            int n = 0;
            foreach (int i in arr)
            {
                if (i != a)
                {
                    n++;
                }
            }
            int[] mangmoi = new int[n];
            int b = 0;
            foreach (int i in arr)
            {
                if ( i != a)
                {
                    mangmoi[b] = i;
                    b = b + 1;

                }
            }
            foreach(int so in mangmoi)
    {
                Console.Write(so + " ");
            }
            Console.WriteLine();
        }
        //5.to find the maximum and minimum value of an array.
        static (int,int) maxmin(int[] arr)
        {
            int n = arr[0];
            int m = arr[0];
                foreach (int i in arr)
            {
                if (n> i)
                {
                    n = i;
                }
            }
                foreach (int j in arr)
            {
                if( m <j)
                {
                    m = j;
                }
            }
            return (m,n);
        }
        //6.to reverse an array of integer values.
        static void reverse(int[] arr)
        {
            int n = arr.Length;
            int  [] nm = new int[n];
            int a = 0;
            for (int i = n -1;i >=0;i--)
            {
                nm[a] = arr[i];
                a++;
            }
            foreach (int so in nm)
            {
                Console.Write(so + " ");
            }
            Console.WriteLine();
        }
        //7.to find duplicate values in an array of values.
        static void TimTrungLap(int[] arr)
        {
            Console.Write("Các phần tử trùng lặp là: ");
            int n = arr.Length;

            // Tạo một mảng đánh dấu xem vị trí đó đã bị tính là trùng hay chưa
            // Mặc định tạo ra, tất cả các ô đều là false
            bool[] daKiemTra = new bool[n];

            for (int i = 0; i < n - 1; i++)
            {
                // Nếu số ở vị trí i đã được kiểm tra ở vòng lặp trước đó rồi thì bỏ qua
                if (daKiemTra[i] == true)
                {
                    continue;
                }

                bool coTrungLap = false;

                // Quét các phần tử đứng phía sau i
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        coTrungLap = true;
                        daKiemTra[j] = true; // Đánh dấu vị trí j để sau này không kiểm tra lại nữa
                    }
                }

                // Nếu phát hiện có sự trùng lặp, in con số đó ra
                if (coTrungLap == true)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
        //8.to remove duplicate elements from an array

        static int[] XoaTrungLapThuCong(int[] arr)
        {
            int n = arr.Length;
            bool[] laSoTrung = new bool[n];

            // --- BƯỚC 1: Đánh dấu các số bị trùng và đếm số lượng phần tử DUY NHẤT ---
            int soLuongDuyNhat = 0;

            for (int i = 0; i < n; i++)
            {
                if (laSoTrung[i] == false) // Nếu con số này chưa bị đánh dấu là đồ bỏ đi
                {
                    soLuongDuyNhat++; // Nó là số độc nhất, đếm nó lại

                    // Tìm tất cả các bản sao của nó ở phía sau và đánh dấu "đồ bỏ đi" (true)
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            laSoTrung[j] = true;
                        }
                    }
                }
            }

            // --- BƯỚC 2: Tạo mảng mới với độ dài chuẩn xác ---
            int[] mangmoi = new int[soLuongDuyNhat];

            // --- BƯỚC 3: Chép dữ liệu sang mảng mới (bỏ qua những số bị đánh dấu true) ---
            int b = 0;
            for (int i = 0; i < n; i++)
            {
                if (laSoTrung[i] == false)
                {
                    mangmoi[b] = arr[i];
                    b++;
                }
            }

            return mangmoi;
        }
    //        ▸Create a C# program that
    //- requests 10 integers from the user and orders them by implementing the bubble sort algorithm.

        static void bubblesort()
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int a = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = a;
                    }
                }
            }
         
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[" + i + "] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

          
            Console.WriteLine("Mang sau khi sap xep:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
     //-Request a sentence from the user, then ask to enter a word.Search if the word appears in the phrase using the linear search algorithm.

        static void linearsearch()
        {
            Console.Write("Nhap cau: ");
            string sentence = Console.ReadLine();

            Console.Write("Nhap tu can tim: ");
            string word = Console.ReadLine();
            string[] words = sentence.Split(' ');
            int a = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    a = 1;
                }
                else
                {
                    a = -1;
                }
            }
            if (a == 1 )
            {
                Console.WriteLine("Co");

            }
            else
            {
                Console.WriteLine("Khong");
            }
            
        }

        //▸Create a program with following functions

        //-Create an integer matrix N x M(N, M was prompted from user) randomly.
        //-Print the matrix.
        static void matrix()
        {
            Console.WriteLine("nhap so hang: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so cot: ");
            int M = int.Parse(Console.ReadLine());
            int[,] matran = new int[N, M];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matran[i, j] = rand.Next(1, 100);
                    Console.Write(matran[i, j] + " ");
                   
                }
                 Console.WriteLine();
            }
          
        }

        //-Print the ith row/column. (i was prompted from user)
        static void chonhangcot()
        {
            Console.Write("Nhap so hang N: ");
            int N = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so cot M: ");
            int M = int.Parse(Console.ReadLine()!);

            int[,] matran = new int[N, M];
            Random rand = new Random();

            Console.WriteLine("\n--- MA TRAN KHOI TAO ---");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matran[i, j] = rand.Next(1, 100);

                    Console.Write(matran[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.Write($"\nNhap vi tri hang can in (tu 0 den {N }): ");
            int chonHang = int.Parse(Console.ReadLine()!);

            if (chonHang > 0 && chonHang <= N)
            {
                Console.Write($"Cac gia tri o hang {chonHang} la: ");
                for (int j = 0; j < M; j++)
                {
                    Console.Write(matran[chonHang - 1, j] + "\t");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("-> Loi: Vi tri hang khong hop le!");
            }


            Console.Write($"\nNhap vi tri cot can in (tu 0 den {M }): ");
            int chonCot = int.Parse(Console.ReadLine());


            if (chonCot > 0 && chonCot <= M)
            {
                Console.WriteLine($"Cac gia tri o cot {chonCot} la: ");
                for (int i = 0; i < N; i++)
                {

                    Console.WriteLine(matran[i, chonCot - 1]);
                }
            }
            else
            {
                Console.WriteLine("-> Loi: Vi tri cot khong hop le!");
            }
        }
        //-Find the max value of the matrix.
        static int max(int[,] matrix)
        {
            int soHang = matrix.GetLength(0);
            int soCot = matrix.GetLength(1);
            int max = matrix[0, 0];
            for (int i = 0; i < soHang; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (matrix[i,j] >= max)
                    {
                        max = matrix[i,j];
                    }
                }
            }
            return max;
        }
        //-Find the min value of ith row / col of the matrix.
        static void minhangcot()
        {
            Console.Write("Nhap so hang N: ");
            int N = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap so cot M: ");
            int M = int.Parse(Console.ReadLine()!);

            int[,] matran = new int[N, M];
            Random rand = new Random();

            Console.WriteLine("\n--- MA TRAN KHOI TAO ---");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matran[i, j] = rand.Next(1, 100);

                    Console.Write(matran[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
            Console.Write($"\nNhap vi tri hang can tim min (tu 0 den {N}): ");
            int chonHang = int.Parse(Console.ReadLine()!);
            int minHang = matran[N -1 , 0];
            if (chonHang > 0 && chonHang <= N)
            {
                Console.Write($" gia tri min o hang {chonHang} la: ");
                for (int j = 0; j < M; j++)
                {
                    if (minHang > matran[N-1, j])
                    {
                        minHang = matran[N-1, j];
                    }
                }
                Console.WriteLine(minHang);
            }
            else
            {
                Console.WriteLine("-> Loi: Vi tri hang khong hop le!");
            }


            Console.Write($"\nNhap vi tri cot can in (tu 0 den {M}): ");
            int chonCot = int.Parse(Console.ReadLine());

            int minCot = matran[0, M-1];
            if (chonCot > 0 && chonCot <= M)
            {
                Console.WriteLine($" gia tri min o cot {chonCot} la: ");
                for (int i = 0; i < N; i++)
                {

                    if (minCot > matran[i, M-1])
                    {
                        minCot = matran[i, M-1];
                    }

                }
                Console.WriteLine(minCot);
            }
            else
            {
                Console.WriteLine("-> Loi: Vi tri cot khong hop le!");
            }
        }
        //-Transpose the matrix.
        static int[,] ChuyenViMaTran(int[,] matrix)
        {
            int soHangCu = matrix.GetLength(0);
            int soCotCu = matrix.GetLength(1);

            int[,] maTranMoi = new int[soCotCu, soHangCu];


            for (int i = 0; i < soHangCu; i++)
            {
                for (int j = 0; j < soCotCu; j++)
                {

                    maTranMoi[j, i] = matrix[i, j];
                }
            }

            return maTranMoi;
        }
        //-Print the main / secondary diagonal values of the matrix.(square maxtrix)
        static void duongcheochinh(int[,] matrix)
        {
            int sohang = matrix.GetLength(0);
            int socot = matrix.GetLength(1);
            for(int i = 0; i < sohang; i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    if (i == j )
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            int[,] maTranMau = new int[,]
    {
        { 5, 12, 7 },
        { 9, 88, 3 }, // Max là 88
        { 2, 8, 14 }
    };
            duongcheochinh(maTranMau);
         }


    }
}
