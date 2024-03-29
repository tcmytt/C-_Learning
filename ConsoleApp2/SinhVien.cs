using System;

public class SinhVien
{
    // Khai báo thuộc tính
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public string QueQuan { get; set; }
    public int Khoa { get; set; }

    // Khai báo phương thức
    public SinhVien(string MaSV,string HoTen,string QueQuan,int Khoa){
        this.MaSV=MaSV;
        this.HoTen=HoTen;
        this.QueQuan=QueQuan;
        this.Khoa=Khoa;
    }
    public void HienThi()
    {
        Console.WriteLine("Ma sinh vien: {0}", MaSV);
        Console.WriteLine("Ho ten: {0}", HoTen);
        Console.WriteLine("Que quan: {0}", QueQuan);
        Console.WriteLine("Khoa: {0}", Khoa);
    }

    public void TrangThai()
    {
        // Xác định trạng thái dựa vào mã sinh viên
        if (Khoa >= 11)
        {
            Console.WriteLine("Sinh vien dang hoc");
        }
        else
        {
            Console.WriteLine("Sinh vien da tot nghiep");
        }
    }
}

public class SinhVienIT:SinhVien{
    public string ChuyenNganh ;
    public SinhVienIT(string ChuyenNganh, string MaSV,string HoTen,string QueQuan,int Khoa) : base( MaSV, HoTen, QueQuan, Khoa){
        this.ChuyenNganh= ChuyenNganh;
    }
    public void HienThi()
    {
        base.HienThi();
        Console.WriteLine("Chuyen Nganh: {0}", ChuyenNganh);
    }
    
    public void TrangThai(){
        base.TrangThai();
    }
}

public class Program{
    static void Main(){
        // SinhVien A = new SinhVien("001","Nguyen Van A","Quang Ninh", 10);
        // SinhVien B = new SinhVien("002","Nguyen Van B","Ha Noi", 9);
        // SinhVien C = new SinhVien("003","Nguyen Van C","Nam Dinh", 12);

        // A.HienThi();
        // A.TrangThai();
        
        // B.HienThi();
        // B.TrangThai();

        // C.HienThi();
        // C.TrangThai();

        
        Console.WriteLine("Nhap khoa:");
        int khoa=int.Parse(Console.ReadLine());
        SinhVienIT D = new SinhVienIT("CNTT","004","Nguyen Van D","Nam Dinh", khoa);
        D.HienThi();
        D.TrangThai();
    }
}