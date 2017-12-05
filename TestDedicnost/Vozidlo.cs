using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDedicnost
{
    class Vozidlo
    {
        private string model;
        private string vyrobce;
        private string potrebneOpravneni;
        private int spaceTotal;
        private int spaceUsed;
        private double spotreba; //na 100km
        private int x;
        private int y;

        public Vozidlo(string model, string vyrobce, string potrebneOpravneni, int spaceTotal, int spaceUsed, double spotreba, int x = 0, int y = 0)
        {
            this.model = model;
            this.vyrobce = vyrobce;
            this.potrebneOpravneni = potrebneOpravneni;
            this.spaceTotal = spaceTotal;
            this.spaceUsed = spaceUsed;
            this.spotreba = spotreba;//
            this.x = x;
            this.y = y;
        }

        public string Model { get { return this.model; } set { this.model = value; } }
        public string Vyrobce { get { return this.vyrobce; } set { this.vyrobce = value; } }
        public string PotrebneOpravneni { get { return this.potrebneOpravneni; } set { this.potrebneOpravneni = value; } }
        public int SpaceTotal { get { return this.spaceTotal; } set { this.spaceTotal = value; } }
        public int SpaceUsed { get { return this.spaceUsed; } set { this.spaceUsed = value; } }
        public double Spotreba { get { return this.spotreba; } set { this.spotreba = value; } }
        public int X { get { return this.x; } set { this.x = value; } }
        public int Y { get { return this.y; } set { this.y = value; } }

    }
}
