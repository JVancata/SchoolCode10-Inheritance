using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDedicnost
{
    class Autobus : Vozidlo, IVehicleMoveHelper, IOpravneniHelper, INakladaniHelper
    {
        List<Object> cestujici = new List<object>();

        public Autobus(string model, string vyrobce, string potrebneOpravneni, int spaceTotal, int spaceUsed, double spotreba)
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

        public int zbytekMist()
        {
            return this.SpaceTotal - this.SpaceUsed;
        }

        public void nalozit(object objekt)
        {
            cestujici.Add(objekt);
            this.SpaceUsed++;
        }

        public void vylozit(object objekt)
        {
            
        }
       
    }
}
