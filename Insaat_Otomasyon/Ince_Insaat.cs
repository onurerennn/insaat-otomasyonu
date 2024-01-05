using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insaat_Otomasyon
{
    class Ince_Insaat:İnsaat
    {
        public String  bilgi_yazdir(String a, int x, String b, int y, String c, int z)
        {

            String metin = a+" = "+x+"\n"+ b+" = " + y + "\n"+ c+" = " + z + "\n";
            return metin;
            
        }
    }
}
