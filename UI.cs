using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_app
{
    class UI
    {
        public static List<int> Type_Value()
        {
            Console.WriteLine("Please input list of numbers:");
            return Console.ReadLine().Split().Select(int.Parse).ToList();
        }
        public static string Type_Command()
        {
            Console.WriteLine("Please input command :");
            return Console.ReadLine();
        }
        public static int Type_Num()
        {
            Console.WriteLine("Please input number:");
            return int.Parse(Console.ReadLine());
        }
        public static string Type_Operator()
        {
            Console.WriteLine("Please input operator :");
            return Console.ReadLine();
        }
    }
}
