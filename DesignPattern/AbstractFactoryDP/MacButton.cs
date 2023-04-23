using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDP
{
    public class MacButton : IButton
    {
        public void PressButton()
        {
            Console.WriteLine("Mac Button Pressed");
        }
    }
}
