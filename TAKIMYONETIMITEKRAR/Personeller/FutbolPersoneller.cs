using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAKIMYONETIMITEKRAR
{
    internal class FutbolPersoneller : ModelBasePersonel, IP
    {
        void IP.Ekle()
        {
            Console.WriteLine(AdSoyad + " İsimli personel eklendi");
        }

        void IP.Getir()
        {
            Console.WriteLine(AdSoyad + " İsimli personel getirildi.");
        }

        void IP.Güncelle()
        {
            Console.WriteLine(AdSoyad + " İsimli personel güncellendi");
        }

        void IP.MaasOde()
        {
            Console.WriteLine(AdSoyad + " İsimli personelin " + Maas + " TL olan maaşı ödendi");
        }

        void IP.Sil()
        {
            Console.WriteLine(AdSoyad + " İsimli personel kayıtları silindi");
        }
    }
}
