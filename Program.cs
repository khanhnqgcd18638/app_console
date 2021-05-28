using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Command.START;
            List<int> nums = UI.Type_Value();
            DB db = new DB();
            db.Nums = nums;
            while (command != Command.END)
            {
                command =  UI.Type_Command();
                switch (command)
                {
                    case Command.CONTAIN:
                        int num = UI.Type_Num();
                        Console.WriteLine(db.Nums.Contains(num));
                        break;
                    case Command.PRINT_EVEN:
                        db.Print(command);
                        break;
                    case Command.PRINT_ODD:
                        db.Print(command);
                        break;
                    case Command.FILTER:
                        string op = UI.Type_Operator();
                        int n = UI.Type_Num();
                        db.FilterNums(op, n);
                        break;
                    case Command.END:
                        break;
                    default:
                        command = Command.START;
                        break;
                }
            }
        }
    }
}
