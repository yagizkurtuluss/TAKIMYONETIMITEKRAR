using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAKIMYONETIMITEKRAR
{
    internal class BasketbolOyuncular :ModelBaseOyuncular,IP,IO
    {
        public int Boy { get; set; }

        public void Ekle()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncu eklendi");
        }

        public void Getir()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncu getirildi");
        }

        public void Güncelle()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncunun forma numarası " + FormaNo + " olarak güncellendi");
            Console.WriteLine(AdSoyad + " İsimli oyuncu güncellendi");
        }

        public void MaasOde()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncunun maaşı ödendi");
        }

        public void Sil()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncunun bilgileri silindi");
        }

        void IO.Prim()
        {
            Console.WriteLine(AdSoyad + " İsimli oyuncunun primi yatırıldı.");
        }
    }
}
