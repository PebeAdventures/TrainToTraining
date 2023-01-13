using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTasks
{
    public static class MethodExtensions
    {

        public static bool ItHasMoreThen5Letters(this string i)
        {
            if (i.Length > 5)
            {
                return true;
            }
            else { return false; }


        }

        public static bool GreaterThenZero(this long i) { return i > 0; }
        public static bool UpperThen50(this long i) { return i < 50; }
        public static bool GreaterThenScopeStart(this long i, long startValue)
        {
            return i < startValue;
        }
    }
}
