using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTests.Classes
{
    public class AlphaComp
    {
        public static string Solution(string S)
        {
            var count = S.Count();
            var passed = "";
            var result = "";

            for (int i = 0; i < count; i++)
            {
                var ___s = S[i].ToString();
                if (passed.Contains(___s)) continue;


                if (___s == ___s.ToLower())
                {
                    if (S.Contains(___s.ToUpper()))
                    {
                        var __u = ___s.ToUpper();
                        result += __u;
                        passed += __u;
                    }
                }
                else
                {
                    if (S.Contains(___s.ToLower()))
                    {
                        var __u = ___s.ToLower();
                        result += ___s;
                        passed += __u;
                    }
                }
                passed += ___s;
            }
            return result.Length > 0 ? result.OrderByDescending(x => x).ToList()[0].ToString() : "NO";
        }
    }
}
