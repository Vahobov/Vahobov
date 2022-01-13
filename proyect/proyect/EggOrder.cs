using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect
{
    internal class EggOrder
    {
        public int GetQuality()
        {
            Random Quality = new Random();
            
                return Quality.Next(100);
            
        }
        public void Crack()
        {
            
        }
        public void Discard()
        {

        }
    }
}
