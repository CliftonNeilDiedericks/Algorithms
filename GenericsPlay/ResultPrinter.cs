using System;

namespace GenericsPlay
{
    public class ResultPrinter
    {
        public void Print<T,U>(Result<T,U> result)
        {
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);
            Console.WriteLine(result.Data2);


        
        }
    }
}
