using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowQuoteProGUI
{
    public static class Utils
    {
        public static IEnumerable<E> enumValues<E>() where E : struct
        {
            foreach (E e in Enum.GetValues(typeof(E)))
                yield return e;
        }

        /// <summary>Returns index of the first item matching the predicate</summary>
		public static int findIndex<T>(this IEnumerable<T> seq, Func<T, bool> predicate)
        {
            int index = 0;
            foreach (var e in seq)
            {
                if (predicate(e))
                    return index;
                index++;
            }
            return -1;
        }
    }
}
