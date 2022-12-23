using System;
using System.Collections.Generic;

namespace Proje1_TelefonRehberi
{
    public class KayıtlıNumaralar
    {
        public List<Rehber> _telefonRehberim;

        public KayıtlıNumaralar()
        {
            _telefonRehberim = new List<Rehber>()
            {
                new Rehber {Isim = "Ali",   Soyisim = "Ak1",     Numara = "01234567891"},
                new Rehber {Isim = "Mehmet",    Soyisim = "Ak2", Numara = "01234567892"},
                new Rehber {Isim = "Can",    Soyisim = "Ak3",   Numara = "01234567893"},
                new Rehber {Isim = "Sever",  Soyisim = "Ak4",    Numara = "01234567894"},
                new Rehber {Isim = "Sercan ",  Soyisim = "Ak5", Numara = "01234567895"},
            };
        }

        public  List<Rehber> telefonRehberim
        {
            get { return _telefonRehberim; }
        }

        public  void RehberYazdır()
        {
            foreach (var item in telefonRehberim)
            {
                Console.WriteLine(item.Isim + " " + item.Soyisim + " " + item.Numara);
            }
        }


    }
}