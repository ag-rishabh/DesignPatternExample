using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeDP
{
    public class TemporyEmployee : Employee
    {
        public int FixedAmount { get; set; }

        public override Employee GetClone()
        {
            return (TemporyEmployee)this.MemberwiseClone();
        }
    }
}
