using System;

namespace Dhrupal_Desai_8805252_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Defining the varialbes
                int input = 0;
                int length;
                int width;

                // Asking for the input of length
                Console.WriteLine("Please enter the length of the rectangle: ");

                // Error checking the length for integer and greater than zero
                while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                {
                    Console.WriteLine("Please Enter a valid integer value and greater than 0!");
                }

                // Asking for the input of width
                Console.Write("Please enter the width of the rectangle: ");

                // Error checking the width for integer and greater than zero
                while ((!int.TryParse(Console.ReadLine(), out width)) || width <= 0)
                {
                    Console.Write("Please Enter a valid integer value and greater than 0!");
                }

                do
                {
                    // Displaying the menu items untils user wishes to exit
                    input = ShowMenu();

                    // Initializing the rectangle class
                    Rectangle rectangle = new Rectangle();
                    rectangle.SetLength(length);
                    rectangle.GetWidth();
                    rectangle.SetWidth(width);

                    // Displaying the length
                    if (input == 1)
                    {
                        Console.Write("The length of rectangle is: ");
                        Console.WriteLine(rectangle.GetLength());
                    }

                    // Changing the length
                    else if (input == 2)
                    {
                        Console.Write("Please enter the length of the rectangle: ");

                        // Error checking the length for integer and greater than zero
                        while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                        {
                            Console.WriteLine("Please Enter a valid integer value and greater than 0!");
                        }
                    }

                    // Displaying the width
                    else if (input == 3)
                    {
                        Console.Write("The width of rectangle is: ");
                        Console.WriteLine(rectangle.GetWidth());
                    }
                    else if (input == 4)
                    {
                        Console.Write("Please enter the width of the rectangle: ");

                        // Error checking the width for integer and greater than zero
                        while ((!int.TryParse(Console.ReadLine(), out width)) || width <= 0)
                        {
                            Console.WriteLine("Please Enter a valid integer value and greater than 0!");
                        }
                    }

                    // Displaying the perimeter
                    else if (input == 5)
                    {
                        Console.Write("The perimeter of rectangle is: ");
                        Console.WriteLine(rectangle.GetPerimeter());
                    }

                    // Displaying the Area
                    else if (input == 6)
                    {
                        Console.Write("The area of rectangle is: ");
                        Console.WriteLine(rectangle.GetArea());
                    }

                    // Exit
                    else if (input == 7)
                    {
                        Environment.Exit(0);
                    }
                }
                while (input < 7);
                Console.WriteLine("Enter valid option");
                ShowMenu();
            }

            //Error handling
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
