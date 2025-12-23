using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user input
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();
            // แปลง string เป็น int
            int a = int.Parse(inputA);
            int b = int.Parse(inputB);
            // เรียกใช้ฟังก์ชัน
            print_plus_Result(a,b); 
            print_minus_Result(a,b);
            print_multiply_Result(a,b);
            print_divide_Result(a,b);
        }

        /// <summary>
        /// Function / Method
        /// void ชนิดข้อมูลที่ไม่มีการส่งค่ากลับ
        /// </summary

        static void print_plus_Result(int num1 , int num2)
        {
            int ans = num1 + num2;
            Console.WriteLine("Your result is: " + ans);
        }
        static void print_minus_Result(int num1, int num2)
        {
            int ans = num1 - num2;
            Console.WriteLine("Your result is: " + ans);
        }
        static void print_multiply_Result(int num1, int num2)
        {
            int ans = num1 * num2;
            Console.WriteLine("Your result is: " + ans);
        }
        static void print_divide_Result(int num1, int num2)
        {
            int ans = num1 / num2;
            Console.WriteLine("Your result is: " + ans);
        }
    }
}
///นางสาวจารุวรรณ เค้าเหลือง 683450184-0
