using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    #region Question5
		
    internal class DerivedClass1 : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1 (override) ");
        }

    } 
          #endregion
}
