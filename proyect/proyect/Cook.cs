using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect
{
    internal class Cook
    {
       ChickenOrder chikenorder=new ChickenOrder();
        EggOrder EggOrder=new EggOrder();   
       public static int chiken = 0;
        public static int egg = 0;
        public static Dictionary<string, Order> orders;
        public static List<string> ordersList = new List<string>();
        public static List<string> puhList = new List<string>();
        public void Submit()
        {
            
            foreach (KeyValuePair<string, Order> order in orders)
            {
                chiken+=((Order)order.Value).g;
                egg += ((Order)order.Value).t;
               }
          
        }

        public void PripareFoot()
        {
            int miq = 0;
            ++miq;
            foreach (KeyValuePair<string, Order> order in orders)
            {
                puhList.Add(order.Key.ToString() + " is server " + ((Order)order.Value).g + " cheken, " + ((Order)order.Value).t + "egg, " + ((Order)order.Value).menu);
            }
            for (int i = 0; i < chiken; i++)
            {
                chikenorder.CutUp();
            }
             for(int i = 0; i < egg; i++)
            {
                EggOrder.Crack();
                EggOrder.Discard();
            }
            puhList.Add("Please enjoy your food!  stul nomir"+miq);
        }
    }
}
