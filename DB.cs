using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_app
{
    class DB
    {
        public List<int> Nums { get; set; }
        public List<int> Even { get; set; }
        public List<int> Odd { get; set; }
        public List<int> Filter { get; set; }
        public DB()
        {
            Nums = new List<int>();
            Even = new List<int>();
            Odd = new List<int>();
            Filter = new List<int>();
        }
        public void Print(string command)
        {
            foreach (var num in Nums)
            {
                if (num % 2 == 0) Even.Add(num);
                else Odd.Add(num);
            }
            if (command == Command.PRINT_EVEN)
            {
                Even.ForEach((num) => { Console.WriteLine(String.Join(" ", Even)); });
            }
            else
            {
                Odd.ForEach((num) => { Console.WriteLine(String.Join(" ", Odd)); });
            }
        }
        public void FilterNums(string op, int number)
        {
            if (op.Contains("<")) Filter = Nums.Where((num) => num < number).ToList();
            if (op.Contains("<=")) Filter = Nums.Where((num) => num < number && num == number).ToList();
            if (op.Contains("==")) Filter = Nums.Where((num) => num == number).ToList();
            if (op.Contains(">")) Filter = Nums.Where((num) => num > number).ToList();
            if (op.Contains(">=")) Filter = Nums.Where((num) => num > number && num == number).ToList();
            Console.WriteLine(String.Join(" ", Filter));
        }
    }
}
