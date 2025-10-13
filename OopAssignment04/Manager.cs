using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    #region Question4
    internal class Manager : Employee
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager is managing");
        }
    } 
    #endregion
}
