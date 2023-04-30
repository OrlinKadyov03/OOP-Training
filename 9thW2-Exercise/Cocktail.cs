using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thW2_Exercise
{
    public class Cocktail
    {
        public int MlWhiskey { get; set; }
        public int MlWhiskeyCola { get; set; }
        public int MlWhiskeyColaIce { get; set; }

        public Cocktail(int whiskey)
        {
            this.MlWhiskey = whiskey;
        }
        public Cocktail(int whiskey,int mlWhiskeyCola)
        {
            this.MlWhiskey = whiskey;
            this.MlWhiskeyCola = mlWhiskeyCola;
        }
        public Cocktail(int mlWhiskey, int mlWhiskeyCola, int mlWhiskeyColaIce)
        {
           this. MlWhiskey = mlWhiskey;
           this. MlWhiskeyCola = mlWhiskeyCola;
           this. MlWhiskeyColaIce = mlWhiskeyColaIce;    
        }
    }
}
