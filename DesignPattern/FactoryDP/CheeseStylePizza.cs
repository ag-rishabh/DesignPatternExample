using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDP
{
    public class CheeseStylePizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Baking Chesse Style Pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Box Chesse Style Pizza...");
        }

        public void Cut()
        {
            Console.WriteLine("Cut Chesse Style Pizza...");
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare Chesse Style Pizza...");
        }
    }
}
