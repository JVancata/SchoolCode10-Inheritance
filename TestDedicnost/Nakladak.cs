using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDedicnost
{
    class Nakladak : Vozidlo, IVehicleMoveHelper, IOpravneniHelper, INakladaniHelper
    {
        private List<Object> naklad = new List<object>();

        public Nakladak(string model, string vyrobce, string potrebneOpravneni, int spaceTotal, int spaceUsed, double spotreba)
            : base(model, vyrobce, potrebneOpravneni, spaceTotal, spaceUsed, spotreba)
        {
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
            this.naklad.Add(objekt);
            this.SpaceUsed++;
        }

        public void vylozit(object objekt)
        {
            this.naklad.Remove(objekt);
            this.SpaceUsed--;
        }
    }
}
