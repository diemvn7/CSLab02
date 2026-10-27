using System;

namespace CSLab02
{
    // Lớp ngoại lệ tự định nghĩa khi giá trị dưới dấu căn < 0[cite: 6]
    class NotNegativeException : Exception
    {
        public NotNegativeException() : base("Gia tri duoi dau can < 0") { }
    }

    class BaiTap1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap vao gia tri x: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Nhap vao gia tri y: ");
                double y = double.Parse(Console.ReadLine());

                double mauSo = 2 * x - y;
                if (mauSo == 0)
                {
                    throw new DivideByZeroException("Mau so (2x - y) bang 0.");
                }

                double bieuThuc = (3 * x + 2 * y) / mauSo;
                if (bieuThuc < 0)
                {
                    throw new NotNegativeException();
                }

                double H = Math.Sqrt(bieuThuc);
                Console.WriteLine($"Ket qua H = {H}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi: Sai format du lieu nhap vao!"); // Bắt lỗi sai format[cite: 6]
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Loi chia cho 0: {ex.Message}"); // Bắt lỗi chia cho 0[cite: 6]
            }
            catch (NotNegativeException ex)
            {
                Console.WriteLine($"Loi: {ex.Message}"); // Bắt ngoại lệ tự định nghĩa[cite: 6]
            }
        }
    }
}