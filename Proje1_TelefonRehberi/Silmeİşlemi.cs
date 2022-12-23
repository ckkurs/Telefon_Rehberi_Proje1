using System;
using System.Linq;

namespace Proje1_TelefonRehberi
{
    class Silmeİşlemi:KayıtlıNumaralar
    {
         public void Silme()
        {
            Silmeİşlemi sils =new Silmeİşlemi();
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input = Console.ReadLine();

            foreach (var item in telefonRehberim.ToList())
            {
                if(input == item.Isim || input == item.Soyisim)
                {
                    Console.WriteLine(item.Isim + " " + item.Soyisim + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
                    string input1 = Console.ReadLine();
                    if( input1 == "y")
                    {
                        telefonRehberim.Remove(item);
                    }
                    else
                    {
                        Console.WriteLine("Çıkış yapılıyor.");
                        break;
                    }
                    break;
                }                
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                    Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                    Console.WriteLine("* Yeniden denemek için (2)");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                    if(input2 == 1)
                    {
                        Console.WriteLine("İşlem sonlandırıldı.");
                        break;
                    }
                    else
                    {
                        sils.Silme();
                    }
                break;
                }
            }            
        }
    }
}