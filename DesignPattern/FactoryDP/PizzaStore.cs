using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDP
{
    public class PizzaStore
    {
        public Pizza orderPiza(PizzaType pizzaType)
        {
            Pizza pizza = CreatePiza(pizzaType);

            //only because order is same for all pizza
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        private Pizza CreatePiza(PizzaType pizzaType)
        {
            if (pizzaType == PizzaType.Pepperoni)
            {
                return new PepperoniStylePizza();
            }
            else if (pizzaType == PizzaType.Cheese)
            {
                return new CheeseStylePizza();
            }
            return null;
        }
    }
}
