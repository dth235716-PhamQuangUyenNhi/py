using Bai6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    public static void Main()
    {
        int n;
        Console.Write(" Nhap so luong nhan vien: ");
        n = int.Parse(Console.ReadLine());
        Employee[] mnv = new Employee[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" Nhap thong tin nhan vien thu: " + (i + 1).ToString());
            mnv[i] = new Employee();
            mnv[i].nhap();
        }
        Console.WriteLine(" Danh sach nhan vien: ");
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", "Ma so", "Ho Ten", "Nam sinh", "Luong Co Ban", "Thu nhap");
        for (int i = 0; i < n; i++)
        {
            mnv[i].xuat();
        }
        Console.ReadLine();
    }
}
