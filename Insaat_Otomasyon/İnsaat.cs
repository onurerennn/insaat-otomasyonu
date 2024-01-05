using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insaat_Otomasyon
{
    class İnsaat
    {
        

       
        private double fiyat;
        public double Fiyat { get => fiyat; set => fiyat = value; }


        private  double toplam;
        public double Toplam { get => toplam; set => toplam = value; }



        public İnsaat()
        {


        }

      
       
        public double fiyat_hesapla(double ucret)
        {
            fiyat += ucret;
            return fiyat;

        }
        public double fiyat_ver()
        {

            return fiyat;
        }
    }
}
