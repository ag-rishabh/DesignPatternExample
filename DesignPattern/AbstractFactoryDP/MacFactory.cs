using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDP
{
    public class MacFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
