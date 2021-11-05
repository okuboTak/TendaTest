using System;
using System.Linq;

namespace Tenda_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数として「n,m」のように入力
            var numbers = Console.ReadLine();

            // 整数をnとmに分割する
            var numberList = numbers.Split(",").Select(x => int.Parse(x)).ToList();
            var n = numberList[0];
            var m = numberList[1];

            // 入力時点でn=0ならば、mを出力し、終了する
            if(n == 0)
            {
                Console.WriteLine(m);
                Environment.Exit(0);
                
            }
            // n=0になるまで、実行し、n=0となったらmを出力する
            while (true)
            {
                var oldn = n;
                n = m % oldn;
                m = oldn;
                if (n== 0)
                {
                    Console.WriteLine(m);
                    break;
                }

            }
        }
    }
}
