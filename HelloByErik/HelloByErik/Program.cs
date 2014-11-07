using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloByErik
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
            Console.WriteLine(CreateMessageGoodBye());
            
            Console.WriteLine(CreateMessage());
            Console.WriteLine(CreateMessageGoodBye());
        }

        public static string CreateMessage()
        {
            return "Hello World";
        }

        public static string CreateMessageGoodBye()
        {
            return "Goodbye World";
        }
    }
}
