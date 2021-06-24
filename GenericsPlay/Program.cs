using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Result<int,string> { Success = true, Data = 5 ,Data2 = "John"};
            var result2 = new Result<string,string> { Success = false, Data = "Jane" ,Data2 = "Doe"};

            var helper = new ResultPrinter();
            helper.Print(result);
            helper.Print(result2);

            Console.ReadKey();
        }
    }
}
