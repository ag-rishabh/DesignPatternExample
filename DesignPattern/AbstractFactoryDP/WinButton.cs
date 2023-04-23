using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDP
{
    public class WinButton : IButton
    {
        public void PressButton()
        {
            Console.WriteLine("Window Button Pressed");
        }
    }
}
