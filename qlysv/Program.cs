using System;

class Program
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Nhap so luong sinh vien n = ");
            n = int.Parse(Console.ReadLine());
        }
        while (n <= 0);

        string[] hoTen = new string[n];
        double[] diem = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhap sinh vien thu " + (i + 1));

            Console.Write("Ho va ten: ");
            hoTen[i] = Console.ReadLine();

            Console.Write("Diem: ");
            diem[i] = double.Parse(Console.ReadLine());
        }

        double tongDiem = 0;

        for (int i = 0; i < n; i++)
        {
            tongDiem += diem[i];
        }

        double diemTrungBinh = tongDiem / n;

        double max = diem[0];

        for (int i = 1; i < n; i++)
        {
            if (diem[i] > max)
            {
                max = diem[i];
            }
        }
        int soLuongDat = 0;

        for (int i = 0; i < n; i++)
        {
            if (diem[i] >= 5.0)
            {
                soLuongDat++;
            }
        }

        Console.WriteLine("\n===== DANH SACH SINH VIEN =====");
        Console.WriteLine("{0,-5} {1,-30} {2,10}", "STT", "Ho va ten", "Diem");
        Console.WriteLine(new string('-', 47));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                "{0,-5} {1,-30} {2,10:F2}",
                i + 1,
                hoTen[i],
                diem[i]
            );
        }

        Console.WriteLine("\nTHONG KE");
        Console.WriteLine("Diem trung binh cua lop: {0:F2}", diemTrungBinh);
        Console.WriteLine("Diem cao nhat: {0:F2}", max);
        Console.WriteLine("So sinh vien dat (>= 5): " + soLuongDat);
    }
}