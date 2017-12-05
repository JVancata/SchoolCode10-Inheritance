using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDedicnost
{
    class OsobniAuto : Vozidlo, IVehicleMoveHelper, IOpravneniHelper
    {
        //private string barva;

        public OsobniAuto(string model, string vyrobce, string potrebneOpravneni, int spaceTotal, int spaceUsed, double spotreba)
            : base(model, vyrobce, potrebneOpravneni, spaceTotal, spaceUsed, spotreba)
        {
            //this.barva = barva;
        }

        public bool maOpravneni(string granted)            
        {
            return this.PotrebneOpravneni.ToLower() == granted.ToLower() ? true : false;
        }

        public void move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
