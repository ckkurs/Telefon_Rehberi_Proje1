using System;
using System.Linq;

namespace Proje1_TelefonRehberi
{
    public class Güncelle : KayıtlıNumaralar
    {
        public void Güncelleme()
        {

            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input = Console.ReadLine();
            
            foreach (var item in telefonRehberim.ToList())
            {
                if (input == item.Isim || input == item.Soyisim)
                {
                    Console.WriteLine("Lütfen yeni numarayı giriniz:");
                    string input1 = Console.ReadLine();
                    item.Numara = input1;
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için (1)");
                    Console.WriteLine("* Yeniden denemek için (2)");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                    if(input2 == 1)
                    {
                        Console.WriteLine("İşlem sonlandırıldı.");
                        break;
                    }
                    else
                    {
                        Güncelle gunc =new Güncelle();
                        gunc.Güncelleme();
                    }
                break;
                }
            }
        }
    }

}