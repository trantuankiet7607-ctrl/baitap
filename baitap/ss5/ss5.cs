using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;

namespace baitap.ss5
{
    internal class ss5
    {
        public static void Main11(string[] args)
        {

            static void bangcuuchuong()
            {
                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{j} x {i} = {j * i} ");
                    }

                }
            }
            static void bai1()
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
            static void bai2()
            {
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Nhap so thu {i}: ");
                    int so = int.Parse(Console.ReadLine());
                    sum = sum + so;

                }
                Console.WriteLine($"Tong cac so la: {sum}");
                Console.WriteLine($"Trung binh cac so la: {sum / 10}");
            }
            static void bai3()
            {
                Console.Write("Ban muon bang cuu chuong nao: ");
                int bcc = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{bcc} x {i} = {bcc * i}");
                }
            }
            static void bai4()
            {
                Console.Write("Nhap so hang cua tam giac: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine("");
                }

            }
            //bai4();
            static void bai5()
            {
                Console.Write("Nhap so hang cua tam giac: ");
                int scc = int.Parse(Console.ReadLine());
                int dem = 1;
                for (int i = 1; i <= scc; i++ )
                {
                    for (int space = 1; space <= scc - i; space++)
                    {
                        Console.Write(" ");
                    }
                    for (int j =1; j <=i; j++)
                    {
                        Console.Write(dem + " ");
                        dem = dem + 1;
                    }
                    Console.WriteLine("");
                }

            }
            //bai5();
            static void bai6()
            {
                Console.Write("Nhap so so hang: ");
                int a = int.Parse(Console.ReadLine());
                double hsum = 0;
                for (int i = 1; i <= a; i++)
                {
                    hsum = hsum + (1 / i);
                    Console.WriteLine($"harmonic series: 1/{i}");
                  
                }
                Console.WriteLine($"sum of harmonic series: {hsum}");
            }
            //bai6();
            static void bai7()
            {
                Console.Write("Nhap so bat dau cua khoang: ");
                int d = int.Parse(Console.ReadLine());
                Console.Write("Nhap so cuoi cung cua khoang: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine($"Khoang ban nhap la: ({d} , {c})");
                for (int i = d; i <= c; i++)
                {
                    int tong = 0;
                    for (int j = 1; j <= i/2; j++)
                    {
                        if (i % j == 0)
                        {
                            tong = tong + j;
                          
                        }
                       
                    }
                    if (tong == i && i != 0)
                    {
                        Console.WriteLine($"{i} la so hoan hao");
                    }
                }
                
            }
            static void bai8()
            {
                Console.Write("Nhap so muon kiem tra: ");
                int snt = int.Parse(Console.ReadLine());
                bool TF = true;
                for (int i = 2; i < snt; i++)
                {
                    if (snt % i == 0 )
                    {
                        TF = false;
                        break;
                    }
                    
                }
                if (TF)
                    Console.WriteLine($"{snt} la so nguyen to");
                else
                    Console.WriteLine($"{snt} khong la so nguyen to");


            }
            static void doanso()
            {
                Console.WriteLine("--- TRÒ CHƠI ĐOÁN SỐ ---");
                Console.WriteLine("Máy tính đã giấu một số từ 0 đến 9. Hãy thử đoán xem!");

                // 1. Tạo công cụ sinh số ngẫu nhiên
                Random rnd = new Random();

                // 2. Yêu cầu máy tính chọn một số từ 0 đến 9
                // Lưu ý: Hàm Next(0, 10) sẽ lấy từ số 0 và DỪNG LẠI ở sát số 10 (tức là 9)
                int soBimMat = rnd.Next(0, 10);

                // Khởi tạo biến lưu số của người chơi (gán tạm số -1 để vòng lặp có thể bắt đầu)
                int soNguoiDoan = -1;

                // 3. Vòng lặp cho phép đoán liên tục nếu chưa trúng
                while (soNguoiDoan != soBimMat)
                {
                    Console.Write("\nNhập số bạn đoán (0-9): ");
                    soNguoiDoan = int.Parse(Console.ReadLine()!);

                    // 4. Sử dụng logic if-else để kiểm tra kết quả
                    if (soNguoiDoan == soBimMat)
                    {
                        Console.WriteLine($"🎉 CHÍNH XÁC! Số bí mật chính là {soBimMat}.");
                    }
                    else if (soNguoiDoan > soBimMat)
                    {
                        Console.WriteLine("📉 Bạn đoán hơi cao rồi, hãy thử một số nhỏ hơn nhé.");
                    }
                    else
                    {
                        Console.WriteLine("📈 Số bạn đoán hơi thấp, hãy thử một số lớn hơn nhé.");
                    }
                }
            }
        }    

    }
}
