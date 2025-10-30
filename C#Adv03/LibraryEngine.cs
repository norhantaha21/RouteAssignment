using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Adv03
{

    public delegate TResult fPtr<T, TResult>(T item);

    internal class LibraryEngine
    {
        #region Question01
        public static void ProcessBooks<T, TResult>(List<T> items, fPtr<T, TResult> f)
        {
            foreach (var item in items)
            {
                Console.WriteLine(f(item));
            }
        }
        #endregion

        #region Question02
        public static void ProcessBooksBCL<T, TResult>(List<T> items, Func<T, TResult> f)
        {
            foreach (var item in items)
            {
                Console.WriteLine(f(item));
            }

        } 


        #endregion
    }
}
