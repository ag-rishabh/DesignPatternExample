using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeDP
{
    public class PermanentEmployee : Employee
    {
        public int Salary { get; set; }

        public override Employee GetClone()
        {
            // MemberwiseClone Method Creates a shallow copy of the current object
           
            return (PermanentEmployee)this.MemberwiseClone();
        }
    }
}
