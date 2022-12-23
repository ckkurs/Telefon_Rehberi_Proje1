using System;
using System.Collections.Generic;

namespace Proje1_TelefonRehberi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int secim=int.Parse(Console.ReadLine());

            if(secim==1)
            {
                Kaydetmeİşlemi kaydets = new Kaydetmeİşlemi();
                kaydets.Kaydet();
            }
            else if(secim==2)
            {
                Silmeİşlemi sils=new Silmeİşlemi();
                sils.Silme();
            }
            else if(secim==3)
            {
                Güncelle guncsd = new Güncelle();
                guncsd.Güncelleme();
            }
            else if(secim==4)
            {
                Listelemeİşlemi listeles=new Listelemeİşlemi();
                listeles.Listeleme();
            }
            else if(secim==5)
            {
                Aramaİşlemi rehberaramas=new Aramaİşlemi();
                rehberaramas.Arama();
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız tuşladınız");
            }

        }
    }
}
