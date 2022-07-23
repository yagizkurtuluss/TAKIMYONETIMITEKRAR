using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAKIMYONETIMITEKRAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IP sql; ;
            IO sqll;
            BasketbolOyuncular BO= new BasketbolOyuncular();
            BO.AdSoyad = "Yağız Yenikurtuluş";
            sql = BO;
            sql.Ekle();
            BO.FormaNo = 15;
           
            sql.MaasOde();
            sqll = BO;
            sqll.Prim();

            sql.Güncelle();

            FutbolOyuncular FO = new FutbolOyuncular();
            FO.AdSoyad = "Yağız Yenikurtuluş";
            sql = FO;
            sql.Ekle();

            FutbolPersoneller FP = new FutbolPersoneller();
            FP.AdSoyad = "Yağız Yenikurtuluş";
            FP.Maas = 50000;
            sql= FP;
            sql.MaasOde();
            sqll.Prim();
            


            


            Console.Read();
        }
    }
}
