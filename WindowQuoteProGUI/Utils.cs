using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowQuoteProGUI
{
    public class Utils
    {
        public static IEnumerable<E> enumValues<E>() where E : struct
        {
            foreach (E e in Enum.GetValues(typeof(E)))
                yield return e;
        }
    }
}
