using System;

namespace FibonaciSayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=1;
            int toplam=0;   
            Console.Write("Adım sayısı giriniz => ");
            int adim_sayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write(a + " " + b + " ");
            for (int i=2;i<adim_sayisi;i++)
            {
                toplam=a+b;
                Console.Write(toplam + " ");
                a=b;
                b=toplam;
            }
            Console.ReadLine();
        }
    }
}
