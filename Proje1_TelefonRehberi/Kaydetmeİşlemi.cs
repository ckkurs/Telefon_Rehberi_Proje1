using System;

namespace Proje1_TelefonRehberi
{
    public class Kaydetmeİşlemi:KayıtlıNumaralar
    {
         public  void Kaydet()
        {
            Console.WriteLine("Lütfen isim giriniz            :");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz         :");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string no = Console.ReadLine();

            Rehber kişi = new Rehber();
            kişi.Isim = ad;
            kişi.Soyisim = soyad;
            kişi.Numara = no;
            
            KayıtlıNumaralar kay=new KayıtlıNumaralar();
            kay._telefonRehberim.Add(kişi);
        }
    }
}
