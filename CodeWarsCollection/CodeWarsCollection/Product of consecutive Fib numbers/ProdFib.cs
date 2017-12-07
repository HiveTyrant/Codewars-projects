using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCollection.Product_of_consecutive_Fib_numbers
{
    public class ProdFib
    {
        public static ulong[] productFib(ulong prod)
        {
            ulong n = 0;
            ulong m = 1;

            do
            {
                if (n * m >= prod) break;

                var temp = n + m;
                n = m;
                m = temp;
            } while (true);

            return new[] {n, m, (ulong)(n * m == prod ? 1 : 0)};
        }
    }
}
