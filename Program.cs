using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice21June3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("landscape");
            }
            else if (height > width)
            {
                Console.WriteLine("portrait");
            }
        }
    }
}