using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Task_17._10.Models
{
    internal class Colored
    {
        public static void Write(string text, Console color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }

        public static void WriteLine(string text, ConsoleColor color)
        {
            Write(text, color);
            Console.WriteLine() ;
        }

        
    }
}
