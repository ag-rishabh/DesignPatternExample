using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDP
{
    public class PepperoniStylePizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Baking Pepperoni Style Pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Box Pepperoni Style Pizza...");
        }

        public void Cut()
        {
            Console.WriteLine("Cut Pepperoni Style Pizza...");
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare Pepperoni Style Pizza...");
        }
    }
}
