using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Asal olup olmadığını kontrol etmek için sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            String s = sayi + " Sayısı Asal Sayı";
            if (sayi == 1) { Console.WriteLine("ASAL DEĞİL!"); goto bitir; }
            for (int a = 2; a <= sayi / 2; a++)
            {
                if (sayi % a == 0)
                {
                    s = sayi + " Sayısı Asal Sayı Değil!";
                    break;
                }
            }
            Console.WriteLine(s);
        bitir: Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);

        }
    }
}
