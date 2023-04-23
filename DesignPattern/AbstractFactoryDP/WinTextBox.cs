using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDP
{
    public class WinTextBox : ITextBox
    {
        public void ShowTextBox()
        {
            Console.WriteLine("Show Window Text Box");
        }
    }
}
