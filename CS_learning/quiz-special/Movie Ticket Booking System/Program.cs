using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_special
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // สร้างระบบจองตั๋วหนังที่รับข้อมูลจากผู้ใช้และคำนวณราคาตั๋วตามประเภทและจำนวนที่นั่ง
            Console.WriteLine("=== Movie Ticket Booking System ===");
                        
            Console.Write("Name of ticket holder: ");
            string name = Console.ReadLine();// รับข้อมูลจากผู้ใช้ ชื่อผู้จอง
                        
            Console.Write("Movie name: ");
            string movie = Console.ReadLine();// รับข้อมูลจากผู้ใช้ ชื่อหนัง
                        
            Console.Write("Ticket type (1=General, 2=Student): ");
            int ticketType = int.Parse(Console.ReadLine());// รับข้อมูลจากผู้ใช้ ประเภทตั๋ว
                        
            Console.Write("Number of seats: ");
            int seats = int.Parse(Console.ReadLine());// รับข้อมูลจากผู้ใช้ จำนวนที่นั่ง
                        
            Console.Write("Want some popcorn? (y/n): ");
            string popcornInput = Console.ReadLine();// รับข้อมูลจากผู้ใช้ ต้องการป๊อปคอร์นหรือไม่

            
            decimal ticketPrice = ticketType == 2 ? 120m : 200m;// คำนวณราคาตั๋ว
            var ticketTypeName = ticketType == 2 ? "General" : "Student";// แสดงชื่อประเภทตั๋ว
            decimal ticketTotal = ticketPrice * seats; // คำนวณราคารวมของตั๋ว
            decimal popcornTotal = popcornInput == "y" ? 60m * seats : 0m;// คำนวณราคารวมของป๊อปคอร์น
            decimal grandTotal = ticketTotal + popcornTotal;// คำนวณราคารวมทั้งหมด

            // แสดงใบจอง
            Console.WriteLine("\n===================================");
            Console.WriteLine("-- Movie ticket reservation form --");
            Console.WriteLine("===================================");

            Console.WriteLine($"Ticket holder: {name}");// แสดงข้อมูลผู้จอง
            Console.WriteLine($"Movie: {movie}");// แสดงข้อมูลหนัง
            Console.WriteLine($"Type: {ticketTypeName}");// แสดงข้อมูลประเภทตั๋ว
            Console.WriteLine($"Quantity: {seats} seat");// แสดงข้อมูลจำนวนที่นั่ง
            Console.WriteLine($"Ticket price: {ticketTotal:F2} bath");// แสดงข้อมูลราคาตั๋ว
            Console.WriteLine($"Popcorn: {popcornTotal:F2} bath");// แสดงข้อมูลราคาป๊อปคอร์น

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Total: {grandTotal:F2} bath");// แสดงข้อมูลราคารวม
            Console.WriteLine("===================================");


        }
    }
}

