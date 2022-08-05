using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTests.Classes
{
    public class SumUpToZero
    {
        public static int[] Solution(int N)
        {
            if (N <= 0) return null;

            int[] result = new int[N];

            if (N == 1)
                return new int[] { 0 };

            if (N == 2)
                return new int[] { 1, -1 };

            int _n = N % 2;

            var y = 1;

            if (_n == 0)
            {
                for (int i = 0; i < N / 2; i++)
                {
                    result[i] = y;
                    result[i + (N / 2)] = -y;
                    y++;
                }
                return result;
            }

            for (int i = 1; i < (N / 2)+1; i++)
            {
                result[i] = y;
                result[i + (N / 2)] = -y;
                y++;
            }
            result[0] = 0;

            return result;
        }

    }
}
