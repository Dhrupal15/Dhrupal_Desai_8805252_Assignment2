using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhrupal_Desai_8805252_Assignment2
{
    public class Rectangle
    {
        private int length { get; set; }
        private int width { get; set; }

        // Default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // Non-default constructor
        public Rectangle(int x, int y)
        {
            length = x;
            width = y;
        }

        // Get Length method
        public int GetLength()
        {
            return length;
        }

        // Set Length method
        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }

        // Get Width method
        public int GetWidth()
        {
            return width;
        }

        // Set Width method
        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        // Get Perimeter method
        public int GetPerimeter()
        {
            int perimeter = 2 * (length + width);
            return perimeter;
        }

        // Get Area method
        public int GetArea()
        {
            int area = length * width;
            return area;
        }
    }
}
