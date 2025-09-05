using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Employee
    {
        private int id;
        private string name;
        private int yearofbirth;
        private double bacluong;
        private double luongcb;

        //Hàm khởi tạo không có tham số
        public Employee()
        {
            Id = 0;
            Name = " ";
            YearofBirth = 0;
            Bacluong = 0;
            Luongcb = 3000000;
        }

        //Các phương thức Properties để get/set giá trị cho các thuộc tính
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int YearofBirth
        {
            get { return yearofbirth; }
            set { yearofbirth = value; }
        }
        public double Bacluong
        {
            get { return bacluong; }
            set { bacluong = value; }
        }
        public double Luongcb
        {
            get { return luongcb; }
            set { luongcb = value; }
        }

        //Các phương thức nhập/xuất dữ liệu
        public void nhap()
        {
            Console.Write(" \t -Nhap ma so nhan vien:");
            Id = int.Parse(Console.ReadLine());

            Console.Write(" \t -Nhap ho ten:");
            Name = Console.ReadLine();
            
            Console.Write(" \t -Nhap nam sinh:");
            YearofBirth = int.Parse(Console.ReadLine());

            double temp;
            Console.Write(" \t -Nhap bac luong:");
            temp = double.Parse(Console.ReadLine());
            if (temp > 4 || temp < 1)
            {
                Console.WriteLine(" \t -Bac luong nv nam trong khoang 1 -> 4");
                Console.Write(" \t -Vui long nhap lai:");
                temp = double.Parse(Console.ReadLine());
            }
            Bacluong = temp;
        }
        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", Id, Name, YearofBirth, Luongcb);
        }

        public double SetSalaryLevel()
        {

        }
        GetIncome()
    }
}
