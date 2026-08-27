using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Transactions;

namespace baitap.ss3
{
    enum CurrencyType
    {
        USD = 1,
        EUR =2 ,
        JPY = 3,
        GBP = 4
    }
    internal class exercise2
    {
        public static void Main(string[] args)
        {
            static void bai1()
            {
                //            Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN)
                //Tình huống thực tế: Tập đoàn Điện lực Việt Nam(EVN) áp dụng biểu giá điện sinh hoạt bậc thang lũy tiến
                //để khuyến khích người dân tiết kiệm điện.Hãy viết chương trình tính hóa đơn tiền điện hàng tháng cho một
                //hộ gia đình.
                //Kiến thức trọng tâm: Kiểu decimal, ép kiểu dữ liệu, định dạng tiền tệ({ 0:C}
                //        hoặc #,##0 VNĐ), tính toán toán
                //học.
                //Yêu cầu bài toán:
                //• Nhập vào chỉ số điện cũ (kWh) và chỉ số điện mới (kWh). Kiểm tra điều kiện chỉ số mới phải lớn hơn hoặc
                //bằng chỉ số cũ.
                //• Tính lượng điện tiêu thụ trong tháng = Chỉ số mới - Chỉ số cũ.
                //• Tính tiền điện theo các bậc giá chưa thuế (Giá giả định năm 2026):
                //• + Bậc 1: Cho 50 kWh đầu tiên(từ 0 - 50 kWh) : 1.806 VNĐ/kWh
                //• + Bậc 2: Cho 50 kWh tiếp theo(từ 51 - 100 kWh) : 1.866 VNĐ/kWh
                //• + Bậc 3: Cho 100 kWh tiếp theo(từ 101 - 200 kWh) : 2.167 VNĐ/kWh
                //• + Bậc 4: Cho 100 kWh tiếp theo(từ 201 - 300 kWh) : 2.729 VNĐ/kWh
                //• + Bậc 5: Cho toàn bộ kWh từ 301 kWh trở lên: 3.050 VNĐ/kWh
                //• Cộng thêm 8 % Thuế Giá trị gia tăng(VAT).
                //• In hóa đơn chi tiết gồm: Số kWh tiêu thụ, Tiền điện chưa thuế, Tiền thuế VAT và Tổng tiền phải thanh toán
                //(làm tròn đến hàng đơn vị decimal).

                Console.Write("Enter the OE (kWh): ");
                Decimal OE = Decimal.Parse(Console.ReadLine()!);
                Console.Write("Enter the NE (KWh): ");
                Decimal NE = Decimal.Parse(Console.ReadLine()!);
                Decimal E = NE - OE;
                Decimal bill = 0;
                if (E < 0)
                {
                    Console.WriteLine("Error");
                }
                if (E <= 50)
                {
                    bill = 1.806m * E;
                    Console.WriteLine($"Electronic Bill is: {bill}");
                }
                else if (50 < E && E <= 100)
                {
                    bill = 1.806m * 50 + 1.866m * (E - 50);
                    Console.WriteLine($"Electronic Bill is: {bill}");

                }
                else if (100 < E && E <= 200)
                {
                    bill = 1.806m * 50 + 1.866m * 50 + 2.167m * (E - 100);
                    Console.WriteLine($"Electronic Bill is: {bill}");
                }
                else if (200 < E && E <= 300)
                {
                    bill = 1.806m * 50 + 1.866m * 50 + 2.167m * 100 + 2.729m * (E - 200);
                    Console.WriteLine($"Electronic Bill is: {bill}");
                }
                else
                {
                    bill = 1.806m * 50 + 1.866m * 50 + 2.167m * 100 + 2.729m * 100 + 3.050m * (E - 300);
                    Console.WriteLine($"Electronic Bill is: {bill}");
                }
                Decimal tax = 0.08m * bill;
                Console.WriteLine($"Electricity Consumption: {E} KWh");
                Console.WriteLine($"Electricity Bill before Tax: {bill} VND");
                Console.WriteLine($"Tax: {tax}");
                Console.WriteLine($"Total Bill: {bill + (tax)}");
            }
            static void bai2()
            {

                //            Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe
                //Tình huống thực tế: Một ứng dụng theo dõi sức khỏe cá nhân cần tính chỉ số khối cơ thể(BMI -Body Mass
                //Index) dựa trên chiều cao và cân nặng do người dùng cung cấp, đồng thời đưa ra lời khuyên về cân nặng lý
                //tưởng.
                //Kiến thức trọng tâm: Kiểu double, ép kiểu, Math.Pow(), định dạng số thập phân({ 0:F2}), cấu trúc rẽ nhánh.
                //Yêu cầu bài toán:
                //• Nhập vào chiều cao(tính bằng mét, ví dụ 1.72) và cân nặng(tính bằng kg, ví dụ 68.5).
                //• Tính chỉ số BMI theo công thức: BMI = Cân nặng / (Chiều cao ^ 2).
                //• Phân loại tình trạng sức khỏe theo chuẩn WHO dành cho người châu Á:
                //• +BMI < 18.5: Gầy(Thiếu cân)
                //• +18.5 <= BMI < 23.0: Bình thường(Lý tưởng)
                //• +23.0 <= BMI < 25.0: Thừa cân(Tiền béo phì)
                //• +BMI >= 25.0: Béo phì
                //• Tính dải cân nặng lý tưởng cho chiều cao đó(Cân nặng tối thiểu = 18.5 * Chiều cao^2; Cân nặng tối đa =
                //22.9 * Chiều cao ^ 2).
                //• Xuất ra chỉ số BMI(lấy 2 chữ số thập phân), phân loại và khoảng cân nặng lý tưởng

                Console.Write("Enter your mass: ");
                double m = double.Parse(Console.ReadLine()!);
                Console.Write("Enter your height: ");
                double h = double.Parse(Console.ReadLine()!);
                double BMI = m / (h * h);
                if (BMI < 18.5)
                {
                    Console.WriteLine("You are thin");
                }
                else if (18.5 <= BMI && BMI < 23)
                {
                    Console.WriteLine(" You are balanced");
                }
                else if (23 <= BMI && BMI < 25)
                {
                    Console.WriteLine("You are overweight");
                }
                else
                {
                    Console.WriteLine(" You are obesity");
                }
                double minw = 18.5 * h * h;
                double maxw = 22.9 * h * h;
                Console.WriteLine($"your BMI: {BMI:F2}");
                Console.WriteLine($"your min weight: {minw:F2}");
                Console.WriteLine($"your mac weight: {maxw:F2}");
            }
            static void bai3()
            {
                //            Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng
                //Tình huống thực tế: Một quầy đổi tiền tại sân bay cần ứng dụng tính toán nhanh số tiền khách hàng nhận
                //được khi đổi từ Việt Nam Đồng(VND) sang các loại ngoại tệ phổ biến(USD, EUR, JPY, GBP) có tính phí dịch
                //vụ.
                //Kiến thức trọng tâm: Kiểu decimal, enum (CurrencyType), switch-case, định dạng tiền tệ quốc tế.
                //Yêu cầu bài toán:
                //• Tạo một enum tên CurrencyType gồm: USD, EUR, JPY, GBP.
                //• Khai báo tỷ giá cố định(Ví dụ: 1 USD = 25,400 VNĐ; 1 EUR = 27,200 VNĐ; 1 JPY = 165 VNĐ; 1 GBP =
                //32,100 VNĐ).
                //• Nhập vào số tiền VNĐ cần đổi(decimal) và chọn loại ngoại tệ muốn đổi.
                //• Phí dịch vụ quy đổi là 0.5 % trên tổng số tiền VNĐ.
                //• Tính số tiền VNĐ thực tế sau khi trừ phí, sau đó quy đổi ra ngoại tệ tương ứng.
                //• In kết quả chính xác đến 2 chữ số thập phân kèm ký hiệu tiền tệ

                Console.Write("Enter amount to be exchanged: ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("type of currency to exchanged: 1-USD, 2-EUR, 3-JPY, 4-GBP: ");
                int b = int.Parse(Console.ReadLine());
                CurrencyType choice = (CurrencyType)b;
                decimal c = 0;
                switch (choice)
                {
                    case CurrencyType.USD:
                        c = 25400m;
                        break;
                    case CurrencyType.EUR:
                        c = 27200m;
                        break;
                    case CurrencyType.JPY:
                        c = 165m;
                        break;
                    case CurrencyType.GBP:
                        c = 32100m;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                decimal sf = 0.005m * a;
                decimal d = a - sf;
                decimal r = d / c;

                Console.WriteLine($"service fee: {sf}");
                Console.WriteLine($"converted amount: {d}");
                Console.WriteLine($"received amonut: {r}");
            }
            static void bai4()
            {
                //            Bài 4: Tính Tuổi Chính Xác &Đếm Ngược Ngày Sinh Nhật
                //Tình huống thực tế: Hệ thống chăm sóc khách hàng của một công ty bán lẻ cần tự động tính tuổi chính xác
                //của khách hàng và đếm số ngày còn lại đến sinh nhật tiếp theo để gửi voucher ưu đãi. 
                //Kiến thức trọng tâm: Kiểu DateTime, TimeSpan, DateTime.ParseExact, toán tử trừ hai ngày, ép kiểu. 
                //Yêu cầu bài toán: 
                //• Nhập ngày tháng năm sinh của người dùng dưới dạng chuỗi 'dd/MM/yyyy'(ví dụ: '25/10/2002').
                //• Chuyển đổi chuỗi thành DateTime sử dụng DateTime.TryParseExact để đảm bảo không bị lỗi định dạng.
                //• Lấy ngày hiện tại hệ thống(DateTime.Now.Date). 
                //• Tính tuổi chính xác tính theo số năm. 
                //• Xác định ngày sinh nhật tiếp theo trong năm nay hoặc năm sau.Tính số ngày còn lại đến sinh nhật đó. 
                //• Hiển thị: Tuổi hiện tại, Tổng số ngày đã sống từ lúc sinh ra, và Số ngày còn lại đến sinh nhật kế tiếp. 

                Console.Write("Enter your birth: ");
                DateTime bd = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                DateTime now = DateTime.Now.Date;
                TimeSpan delta = now - bd;
                int days = delta.Days;
                int Tuoi = now.Year - bd.Year;
                DateTime sn = new DateTime(now.Year, bd.Month, bd.Day);
                if (sn < now)
                {
                    sn = sn.AddYears(1);
                }
                TimeSpan dd = sn - now;
                Console.WriteLine($"Số ngày đã sống: {days}");
                Console.WriteLine($"Số tuổi hiện tại: {Tuoi}");
                Console.WriteLine($"Số ngày còn lại đến sinh nhật: {dd.Days}");
            }
            static void bai5()
            {
                Console.Write("Nhap diem co so lap trinh: ");
                double score1 = double.Parse(Console.ReadLine());
                Console.Write("Nhap so tin chi co so lap trinh: ");
                int tc1 = int.Parse(Console.ReadLine());
                Console.Write("Nhap diem toan roi rac: ");
                double score2 = double.Parse(Console.ReadLine());
                Console.Write("Nhap so tin chi toan roi rac: ");
                int tc2 = int.Parse(Console.ReadLine());
                Console.Write("Nhap diem Tieng Anh: ");
                double score3 = double.Parse(Console.ReadLine());
                Console.Write("Nhap so tin chi Tieng Anh: ");
                int tc3 = int.Parse(Console.ReadLine());

                double was = ((score1 * tc1) + (score2 * tc2) + (score3 + tc3))/(tc1 + tc2 + tc3);
                Console.WriteLine($"diem trung binh la: {was:F2}");
                if (was >= 8.5 && was < 10)
                {
                    Console.WriteLine("Diem A");
                    Console.WriteLine("Thang 4: 4.0");
                    Console.WriteLine("xep loai: xuat sac/ gioi");
                }
                else if (7 <= was && was <= 8.4)
                {
                    Console.WriteLine("Diem B");
                    Console.WriteLine("Thang 4: 3.0");
                    Console.WriteLine("xep loai: kha");
                }
                else if (5.5 <= was && was <= 6.9)
                {
                    Console.WriteLine("Diem C");
                    Console.WriteLine("Thang 4: 2.0");
                    Console.WriteLine("xep loai: trung binh");
                }
                else if (was >= 4 && was <= 5.4)
                {
                    Console.WriteLine("Diem D");
                    Console.WriteLine("Thang 4: 1.0");
                    Console.WriteLine("xep loai: yeu");
                }
                else if (was < 4)
                {
                    Console.WriteLine("Diem F");
                    Console.WriteLine("Thang 4: 0");
                    Console.WriteLine("xep loai: kem (truot)");
                }
                else
                {
                    Console.Write("Error");
                }
            }
            static void bai6()
            {
                //                Tình huống thực tế: Bộ phận Nhân sự(HR) cần một công cụ xử lý dữ liệu thô nhập vào từ biểu mẫu đăng
                //ký.Họ tên nhập vào thường bị lỗi thừa khoảng trắng, hoa thường lộn xộn.Cần chuẩn hóa tên và tạo tài
                //khoản công ty.
                //Kiến thức trọng tâm: Kiểu string, các phương thức Trim(), Split(), Substring(), ToLower(), ToUpper(),
                //string.Join().
                //Yêu cầu bài toán: 
                //• Nhập vào một chuỗi họ tên thô từ bàn phím(Ví dụ: "   ngUYỄN   vĂn   aN   "). 
                //• Loại bỏ khoảng trắng thừa ở đầu, cuối và giữa các từ(chỉ giữ lại 1 khoảng trắng giữa các từ).
                //• Chuyển đổi chuỗi thành dạng Viết Hoa Chữ Cái Đầu Mỗi Từ(Title Case): "Nguyễn Văn An".
                //• Tách thành Họ, Tên Đệm và Tên chính.
                //• Tạo Username không dấu theo quy tắc: ten.hovatenm. (Ví dụ: an.nguyenvan).
                //• Tạo Email công ty: username + "@company.edu.vn".
                Console.Write("Nhap ten cua ban: ");
                string ten0 = Console.ReadLine();
                string ten1 = ten0.Trim();
                string ten2 = ten1.ToLower();
                string[] danhsach = ten2.Split(' ');
                for (int i = 0; i < danhsach.Length; i++)
                {
                    string tuhientai = danhsach[i];
                    if (tuhientai.Length > 0)
                    {
                        string chudau = tuhientai.Substring(0, 1).ToUpper();
                        string conlai = tuhientai.Substring(1);
                        danhsach[i] = chudau + conlai;

                    }

                }
                string chuanhoa = string.Join(" ", danhsach);
                string ho = danhsach[0];
                string ten = danhsach[danhsach.Length - 1];

                // --- CÁCH LẤY TÊN ĐỆM CHUẨN ---

                // Tính số lượng từ đệm ở giữa
                int soTuDem = danhsach.Length - 2;

                // Tạo mảng mới để chứa các từ đệm
                string[] mangTenDem = new string[soTuDem];

                // Dùng for nhặt các từ ở giữa (từ index 1 đến trước chữ cuối cùng)
                for (int i = 0; i < soTuDem; i++)
                {
                    mangTenDem[i] = danhsach[i + 1];
                }
                // Cuối cùng, dùng string.Join để dán các từ đệm lại
                string tendem = string.Join(" ", mangTenDem);
                Console.WriteLine($"Ten chuan  hoa:{chuanhoa}");
                Console.WriteLine($"ho: {ho} | ten dem: {tendem} | ten: {ten}");
                Console.WriteLine($"username: {ten.ToString().ToLower()}.{ho.ToString().ToLower()}{tendem.ToString().ToLower()}");
                Console.WriteLine($"Email: {ten.ToString().ToLower()}.{ho.ToString().ToLower()}{tendem.ToString().ToLower()}@company.edu.vn");


            }
            static void bai7()
            {
                //                Bài 7: Lập Kế Hoạch Chi Phí Nhiên Liệu & Chia Sẻ Chuyến Đi(Car - pooling)
                //Tình huống thực tế: Một nhóm bạn lên kế hoạch đi phượt bằng xe ô tô cá nhân. Họ cần một máy tính bỏ
                //túi để ước tính tổng lượng nhiên liệu tiêu thụ, tổng chi phí xăng dầu và chia đều cho từng thành viên.
                //Kiến thức trọng tâm: Kiểu double, decimal, int, Math.Ceiling, định dạng tiền tệ. 
                //Yêu cầu bài toán: 
                //• Nhập khoảng cách chuyến đi(km - kiểu double).
                //• Nhập mức tiêu thụ nhiên liệu trung bình của xe(lít/ 100km - kiểu double). 
                //• Nhập giá xăng hiện tại(VNĐ / lít - kiểu decimal).
                //• Nhập số lượng người tham gia chuyến đi(người -kiểu int). 
                //• Tính tổng số lít xăng cần dùng = (Quãng đường / 100) * Mức tiêu thụ. 
                //• Tính tổng chi phí tiền xăng = Tổng số lít xăng * Giá xăng.
                //• Tính số tiền mỗi người phải chi trả(làm tròn lên hàng nghìn VNĐ gần nhất bằng Math.Ceiling). 

                Console.Write("Khoang cach chuyen di (km): ");
                double s = double.Parse(Console.ReadLine());
                Console.Write("muc tieu thu nhien lieu (lit/100km): ");
                double h = double.Parse(Console.ReadLine());
                Console.Write("Gia xang hien tai (VND/lit): ");
                decimal t = decimal.Parse(Console.ReadLine());
                Console.Write("So luong nguoi tham gia: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tong so lit xang can dung: {(s/100)*h}");
                Console.WriteLine($"Tong tien xang: {(decimal)((s / 100) * h) * t}");
                Console.WriteLine($"Moi nguoi phai tra: {Math.Ceiling((((decimal)((s / 100) * h) * t)/n)/1000)*1000}");
            }
            static void bai8()
            {
                Console.WriteLine("Ma OTP cua ban la: 839201");
                DateTime thoigianguima = DateTime.Now;

                Console.Write("Nhap ma OTP cua ban: ");
                string chuoinhap = Console.ReadLine();
                bool chinhxac = int.TryParse(chuoinhap, out int otp);
                DateTime thoigiannhap = DateTime.Now;
                if (chinhxac == true && otp == 839201 && thoigiannhap <= thoigianguima.AddMinutes(5))
                {
                    Console.WriteLine("Trang thai da duoc xac thuc - Phe duyet thanh cong");
                    TimeSpan dt = thoigiannhap - thoigianguima;
                    Console.WriteLine($"thoi gian nhap cua ban la: {dt}");
                }
                else if (chinhxac == false && thoigiannhap <= thoigianguima.AddMinutes(5))
                {
                    Console.WriteLine("Xac thuc khong thanh cong - Dinh dang khong hop le");
                }
                else if (chinhxac == true && otp != 839201 && thoigiannhap <= thoigianguima.AddMinutes(5))
                {
                    Console.WriteLine("Xac thuc khong thanh cong - Ma sai");
                }
                else
                {
                    Console.WriteLine("Xac thuc khong thanh cong - Qua thoi gian xac thuc");
                }
               
            }
            bai8();
                  
             












            }
        }
}
