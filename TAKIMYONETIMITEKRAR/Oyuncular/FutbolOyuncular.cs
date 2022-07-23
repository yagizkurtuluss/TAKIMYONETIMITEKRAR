using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAKIMYONETIMITEKRAR
{
    internal class FutbolOyuncular : ModelBaseOyuncular, IO, IP
    {
        void IP.Ekle()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncu eklendi");
        }

        void IP.Getir()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncu getirildi");
        }

        void IP.Güncelle()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncu güncellendi");
        }

        void IP.MaasOde()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncunun maaşı ödendi");
        }

        void IO.Prim()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncunun bilgileri silindi");
        }

        void IP.Sil()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncunun primi yatırıldı.");
        }
    }
}
