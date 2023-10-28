using System;

namespace Cau_Truc_Lenh_Co_Ban
{
    class Program
    {
        static void Main(string[] args)
        {
            byte BienByte = 10;
            short BienShort = 10;
            int BienInt = 10;
            long BienLong = 10;

            // Kiểu số thực
            float BienFloat = 10.9f; // Giá trị của biến kiểu float phải có hậu tố f hoặc F. 
            double BienDouble = 10.9; // Giá trị của biến kiểu double không cần hậu tố.
            decimal BienDecimal = 10.9m; // Giá trị của biến kiểu decimal phải có hậu tố m.

            // Kiểu ký tự và kiểu chuỗi
            char BienChar = 'K'; // Giá trị của biến kiểu ký tự nằm trong cặp dấu '' (nháy đơn).
            string BienString = "Kteam"; // Giá trị của biến kiểu chuỗi nằm trong cặp dấu "" (nháy kép).


            Console.WriteLine("         K team"); // In chữ "K team" sau đó xuống dòng.
            Console.Write(" Moi ban nhap ten cua minh: "); // In không xuống dòng.
            Console.WriteLine("Ten cua ban la: " + Console.ReadLine()); // Quy tắc chung trong thực hiện lệnh là lệnh bên trong thực hiện trước rồi đến lệnh bên ngoài chứa nó. Do đó chạy đến đây chương trình sẽ thực hiện lệnh Console.ReadLine() sau đó thực hiện cộng chuỗi và cuối cùng in chuỗi ra màn hình.
            Console.Write(" Moi ban nhap ngay sinh: ");
            Console.WriteLine(" Ngay sinh cua ban la: " + Console.ReadLine()); // Tương tự như trên
            Console.Write(" Moi ban nhap que quan: ");
            Console.WriteLine(" Que quan: " + Console.ReadLine()); // Tương tự như trên.

            Console.ReadKey();
        }
        }
    }

