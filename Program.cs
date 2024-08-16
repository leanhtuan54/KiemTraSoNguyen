using System;

namespace menu

{
    class Program
    {
        static void Main(string[] args)
        {
            /*while int luachon = Int32.Parse(Console.ReadLine());
            Console.WriteLine("--Menu--");
            Console.WriteLine("1. Cafe");
            Console.WriteLine("2. Tra sua");
            Console.WriteLine("3. Sinh to");
            Console.WriteLine("Ban chon mon nao ?");    

            while (luachon !=0)
            {
             Console.WriteLine("Chung toi se phuc vu");
             Console.WriteLine("Ban chon mon nao ?");
             luachon = Int32.Parse(Console.ReadLine())
            }
            Console.WriteLine("Xin chao, hen gap lai"); */

            int choice;

        while (true)  // Vòng lặp vô hạn cho đến khi người dùng chọn thoát (choice = 0)
        {
            // Hiển thị menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            // Sử dụng cấu trúc switch-case để xử lý các lựa chọn
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    break;
                case 2:
                    Console.WriteLine("Draw the square");
                    for (int i = 0; i < 6; i++) // In hình vuông 6x6
                    {
                        Console.WriteLine("* * * * * *");
                    }
                    break;
                case 3:
                    Console.WriteLine("Draw the rectangle");
                    for (int i = 0; i < 3; i++) // In hình chữ nhật 3x6
                    {
                        Console.WriteLine("* * * * * *");
                    }
                    break;
                case 0:
                    Console.WriteLine("Exiting the program...");
                    Environment.Exit(0); // Thoát chương trình
                    break;
                default:
                    Console.WriteLine("No choice! Please enter a valid option.");
                    break;
            }

            Console.WriteLine(); // Thêm dòng trống để dễ đọc hơn

        }
    }
}
}