using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDP
{
    public class GUIAbstractFactory
    {
        public static IFactory CreateFactory(string osType) 
        {
            if(osType == "Win")
            {
                return new WindowFactory();
            } 
            else if (osType == "Mac")
            {
                return new MacFactory();
            }

            return null;
        }
    }
}
