using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeUygulama5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saat = 8;
            int dakika = 30;
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine(" ");
            Console.Write("Lütfen 100 ile 500 arasında bir değer giriniz : ");
            string kullaniciDeger=Console.ReadLine();   
            int kullaniciDegerInt=Convert.ToInt32(kullaniciDeger);
            int bolum = kullaniciDegerInt / 60;
            saat = saat + bolum;
            int bolum2 = kullaniciDegerInt % 60;
            dakika = dakika + bolum2;

            if (dakika>60)
            {
                bolum =dakika / 60;
                saat = saat + bolum;             
                dakika = dakika - (60*bolum);
            }

            if (100<=kullaniciDegerInt && kullaniciDegerInt<=500)
            {      
                    Console.WriteLine("Sınavın başlangıç saati 8:30'dur {0} dakika sonra saat {1}:{2} olacaktır.", kullaniciDegerInt,saat,dakika );
                    Console.ReadLine();        
            }

            else
            {
                Console.WriteLine("Lütfen belirtilen koşullara uygun giriş yapınız!");
                Console.ReadLine(); 
            }
            Console.ReadLine();
        }
    }
}
