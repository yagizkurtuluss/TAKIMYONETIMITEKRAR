using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAKIMYONETIMITEKRAR
{
    internal abstract class ModelBaseOyuncular
    {
        public string AdSoyad { get; set; }
        public string Mevki { get; set; }
        public int FormaNo { get; set; }
        public int Yas { get; set; }
        public int Maas { get; set; }
        public DateTime SozlesmeBıtıs { get; set; }
    }
}
