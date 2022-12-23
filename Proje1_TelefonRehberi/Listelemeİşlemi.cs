using System;

namespace Proje1_TelefonRehberi
{
    public class Listelemeİşlemi:KayıtlıNumaralar
    {
         public void Listeleme()
        {
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("***********************************");
                
                foreach (var item in telefonRehberim)
                {
                    Console.WriteLine("İsim            : " + item.Isim);
                    Console.WriteLine("Soyisim         : " + item.Soyisim);
                    Console.WriteLine("Telefon Numarası: " + item.Numara);
                    Console.WriteLine("-");
                }
        }
    }
}
