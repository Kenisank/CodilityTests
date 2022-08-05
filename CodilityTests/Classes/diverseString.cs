using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTests.Classes
{
    public class diverseString
    {
        public static string Solution(int A, int B, int C)
        {
            var result = "";
            while (A + B + C > 0)

            {
                if (A > 0)
                {
                    if (result.Length > 1)  if (result.Substring(result.Length - 1, 1) == "a") break; 
                    if (A > 2)
                    {
                        result += "aa";
                        A -= 2;
                    }
                    else
                    {
                        result += "a";
                        A -= 1;
                    }
                }

                if (B > 0)
                {
                    if (result.Length > 1) if (result.Substring(result.Length - 1, 1) == "b") break;
                    
                    if (B > 2)
                    {
                        result += "bb";
                        B -= 2;
                    }
                    else
                    {
                        result += "b";
                        B -= 1;
                    }
                }

                if (C > 0 )
                {

                    if (result.Length > 1) if (result.LastOrDefault() == 'c') break; 
                   
                    if (C > 2)
                    {
                        result += "cc";
                        C -= 2;
                    }
                    else
                    {
                        result += "c";
                        C -= 1;
                    }
                }
            }
            return result;
        }
    }
}
