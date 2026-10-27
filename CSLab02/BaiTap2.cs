using System;
using System.Collections.Generic;

namespace CSLab02
{
    class BaiTap2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu n (n > 0): ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("n phai lon hon 0!");
                return;
            }

            List<int> ml = new List<int>();
            Random rnd = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < n; i++)
            {
                ml.Add(rnd.Next(100)); 
            }

            Console.WriteLine("\nDanh sach ngau nhien ban dau:");
            foreach (int item in ml)
            {
                Console.Write(item + " ");
            }

            ml.Sort();

            Console.WriteLine("\n\nDanh sach sau khi sap xep tang dan:");
            foreach (int item in ml)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}