using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq02
{
    internal class EqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x == null || y == null) return false;
            
            string nx = new string(x.Trim().ToLowerInvariant().Replace(" " , "").OrderBy(c => c).ToArray());
            string ny = new string(y.Trim().ToLowerInvariant().Replace(" ", "").OrderBy(c => c).ToArray());
            return nx == ny;
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            if (obj == null) return 0;
            string n = new string (obj.Trim().ToLowerInvariant().Replace(" ", "").OrderBy(c => c).ToArray());
            return n.GetHashCode();
        }
    }
}
