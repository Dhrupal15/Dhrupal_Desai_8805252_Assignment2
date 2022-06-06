using System;

namespace Dhrupal_Desai_8805252_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = 0;
                int length;
                int width;
                Console.WriteLine("Please enter the length of the rectangle: ");

                while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                {
                    Console.WriteLine("Please Enter a valid integer value and greater than 0!");
                }

                Console.WriteLine("Please enter the width of the rectangle: ");
                while ((!int.TryParse(Console.ReadLine(), out width)) || width <= 0)
                {
                    Console.WriteLine("Please Enter a valid integer value and greater than 0!");
                }

                do
                {
                    input = ShowMenu();
                    Rectangle rectangle = new Rectangle();

                    rectangle.SetLength(length);
                    rectangle.GetWidth();
                    rectangle.SetWidth(width);
                    if (input == 1)
                    {
                        Console.Write("The length of rectangle is: ");
                        Console.WriteLine(rectangle.GetLength());
                    }
                    else if (input == 2)
                    {
                        Console.Write("Please enter the length of the rectangle: ");
                        while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                        {
                            Console.WriteLine("Please Enter a valid integer value and greater than 0!");
                        }
                    }
                    else if (input == 3)
                    {
                        Console.Write("The width of rectangle is: ");
                        Console.WriteLine(rectangle.GetWidth());
                    }
                    else if (input == 4)
                    {
                        Console.Write("Please enter the width of the rectangle: ");
                        while ((!int.TryParse(Console.ReadLine(), out width)) || width <= 0)
                        {
                            Console.WriteLine("Please Enter a valid integer value and greater than 0!");
                        }
                    }
                    else if (input == 5)
                    {
                        Console.Write("The perimeter of rectangle is: ");
                        Console.WriteLine(rectangle.GetPerimeter());
                    }
                    else if (input == 6)
                    {
                        Console.Write("The area of rectangle is: ");
                        Console.WriteLine(rectangle.GetArea());
                    }
                    else if (input == 7)
                    {
                        Environment.Exit(0);
                    }
                }
                while (input < 7);
                Console.WriteLine("Enter valid option");
                ShowMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static int ShowMenu()
        {
            Console.Write("\n\n");
            Console.Write("---------------------------Menu-------------------------\n");
            Console.Write("1. Get Rectangle Length\n");
            Console.Write("2. Change Rectangle Length\n");
            Console.Write("3. Get Rectangle Width\n");
            Console.Write("4. Change Rectangle Width\n");
            Console.Write("5. Get Rectangle Perimeter\n");
            Console.Write("6. Get Rectangle Area\n");
            Console.Write("7. Exit\n");
            return int.Parse(Console.ReadLine());
        }
    }
}
