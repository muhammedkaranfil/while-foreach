// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while 
            // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.

          //  Console.WriteLine("lütfen bir sayi giriniz");
           // int sayi = int.Parse(Console.ReadLine());
          //  int sayac = 1;
          //  int toplam = 0;
          //  while(sayac <= sayi)
          //  {
          //      toplam+= sayac;
          //      sayac ++;
         //   } 
           // Console.WriteLine(toplam/sayi);
            // 'a' dan 'z' ye kadar tüm harfleri console a yazdırın
            char character = 'a';
            while (character <'z')
            {
                Console.Write(character);
                character ++;
                
                Console.Write("*****Foreach*****");
                string[] arabalar = {"BMV","FORD","Toyota","Nissan"};
                
                foreach(var araba in arabalar)
                {
                 Console.WriteLine(araba);
                }
            }
        }
    }
}

