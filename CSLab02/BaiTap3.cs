using System;
using System.Collections.Generic;

namespace CSLab02
{
    struct MatHang
    {
        public int MaMH;
        public string TenMH;
        public int SoLuong;
        public float DonGia;

        // Hàm tạo[cite: 8]
        public MatHang(int maMH, string tenMH, int soLuong, float donGia)
        {
            MaMH = maMH;
            TenMH = tenMH;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        // Hàm tính thành tiền[cite: 8]
        public float ThanhTien()
        {
            return SoLuong * DonGia;
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ma: {MaMH} | Ten: {TenMH} | So luong: {SoLuong} | Don gia: {DonGia} | Thanh tien: {ThanhTien()}");
        }
    }

    class BaiTap3
    {
        // Hàm thêm mặt hàng vào danh sách[cite: 7, 8]
        static void ThemMatHang(List<MatHang> danhsach, MatHang m)
        {
            danhsach.Add(m);
        }

        // Hàm tìm một mặt hàng dựa vào mã mặt hàng, trả về bool[cite: 7, 8]
        static bool TimMatHang(List<MatHang> danhsach, int maMH)
        {
            foreach (var item in danhsach)
            {
                if (item.MaMH == maMH)
                    return true;
            }
            return false;
        }

        // Hàm xuất danh sách các mặt hàng[cite: 7, 8]
        static void XuatDanhSach(List<MatHang> danhsach)
        {
            Console.WriteLine("\n--- DANH SACH CAC MAT HANG ---");
            if (danhsach.Count == 0)
            {
                Console.WriteLine("Danh sach dang trong!");
                return;
            }
            foreach (var item in danhsach)
            {
                item.XuatThongTin();
            }
        }

        // Hàm xóa mặt hàng dựa vào mã mặt hàng[cite: 8]
        static void XoaMatHang(List<MatHang> danhsach, int maMH)
        {
            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].MaMH == maMH)
                {
                    danhsach.RemoveAt(i);
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            List<MatHang> ds = new List<MatHang>();
            string tiepTuc;

            // Nhập danh sách mặt hàng, hỏi người dùng có tiếp tục hay không[cite: 7, 9]
            do
            {
                Console.WriteLine("\n--- Nhập thông tin mặt hàng mới ---");
                Console.Write("Nhap ma mat hang (so nguyen): ");
                int ma = int.Parse(Console.ReadLine());

                Console.Write("Nhap ten mat hang: ");
                string ten = Console.ReadLine();

                Console.Write("Nhap so luong: ");
                int sl = int.Parse(Console.ReadLine());

                Console.Write("Nhap don gia: ");
                float dg = float.Parse(Console.ReadLine());

                MatHang mh = new MatHang(ma, ten, sl, dg);
                ThemMatHang(ds, mh);

                Console.Write("Ban co muon nhap tiep khong? (c/k): ");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.ToLower() == "c");

            // Xuất danh sách các mặt hàng[cite: 7, 9]
            XuatDanhSach(ds);

            // Nhập mã mặt hàng cần tìm để xóa[cite: 7, 9]
            Console.Write("\nNhap ma mat hang can tim de xoa: ");
            int maTim = int.Parse(Console.ReadLine());

            if (TimMatHang(ds, maTim))
            {
                Console.WriteLine($"-> Tim thay mat hang co ma {maTim}. Tien hanh xoa...");
                XoaMatHang(ds, maTim);

                // Xuất danh sách sau khi xóa[cite: 7, 9]
                XuatDanhSach(ds);
            }
            else
            {
                Console.WriteLine($"-> Khong tim thay mat hang co ma {maTim}.");
            }
        }
    }
}