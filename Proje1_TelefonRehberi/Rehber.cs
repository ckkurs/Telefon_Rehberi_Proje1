using System;

namespace Proje1_TelefonRehberi
{
    public class Rehber
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Numara { get; set; }

        public Rehber(string isim,string soyisim,string numara)
        {
            Isim=isim;
            Soyisim=soyisim;
            Numara=numara;
        }

        public Rehber() {}
    }
}