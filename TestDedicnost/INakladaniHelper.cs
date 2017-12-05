using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDedicnost
{
    interface INakladaniHelper
    {
        void nalozit(Object objekt);
        void vylozit(Object objekt);
        //int getSpaceLeft(int totalSpace, int usedSpace);
    }
}
