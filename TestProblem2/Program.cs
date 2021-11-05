using System;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var markList = new List<string>() { "ハート", "クローバー", "スペード", "ダイヤ" ,"ジョーカー"};

            // 出たマークと番号をCardクラスに格納する
            var card = new Card();
            card.mark = markList[random.Next(0, 4)];
            card.number = random.Next(1, 13);

            if (card.mark == "スペード" || card.mark == "クローバー")
            {
                Console.WriteLine("マーク:" + card.mark);
                Console.WriteLine("番号:" + card.number);
                Console.WriteLine("ポイント:" + card.number);
            }else if(card.mark =="ハート" || card.mark == "ダイヤ"){
                Console.WriteLine("マーク:" + card.mark);
                Console.WriteLine("番号:" + card.number);
                Console.WriteLine("ポイント:" + card.number * 2);
            }
            else
            {
                Console.WriteLine("マーク:" + card.mark);
                Console.WriteLine("ポイント:" + 50);
            }
        }
    }
}
