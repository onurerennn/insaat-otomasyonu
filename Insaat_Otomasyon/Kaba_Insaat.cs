using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insaat_Otomasyon
{
    class Kaba_Insaat:İnsaat
    {
        private String cesit;
        public String Cesit { get => cesit; set => cesit = value; }

        public Kaba_Insaat()
        {
            
        }
        public String cesit_yazdir(String a ,int x, String b, int y, String c, int z)
        {
            String cesitler = "kullanılan malzeme çeşitleri :\nduvar : " + a +" fiyatı =  "+x+"\nçatı : " + b + " fiyatı :  " + y + "\nbeton = " + c+" fiyatı =  " + z ;
            return cesitler;
            
        }
        
    }
}
