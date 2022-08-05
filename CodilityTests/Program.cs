using CodilityTests.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var result= AlphaComp.Solution("WeTestCodErs");
            //var result = SumUpToZero.Solution(7);
            // var result = diverseString.Solution(6, 1, 1);

            //Console.WriteLine("[{0}]", String.Join(",", result.OrderBy(x=>x)));
            //Console.WriteLine($"Sum: {result.Sum()}");
            // Console.WriteLine(result);

            //var str = "WeTestCodErs";
            //var lower = new bool[26];
            //var upper = new bool[26];

            //foreach (var s in str)
            //{
            //    if (s >= 'a' && s <= 'z') lower[s - 'a'] = true;
            //    else upper[s - 'A'] = true;
            //}

            //for (int i = lower.Length - 1; i >= 0; i--)
            //{
            //    if (lower[i] && upper[i])
            //    {
            //        Console.WriteLine(((char)(i + 'A')).ToString());
            //        break;
            //    };
            //}

            //var A = new int[] { 1, 2, 3 };
            //int N = A.Count();
            //var set = new HashSet<int>();
            //foreach(int a in A)
            //{
            //    if (a > 0)
            //    {
            //        set.Add(a);
            //    }
            //}
            //for (int i = 1; i <= N + 1; i++)
            //{
            //    if (!set.Contains(i))
            //    {
            //        return i;
            //    }
            //}

            //var s = "1X7T4VrCs23k4vv08D6yQ3S19G4rVP188M9ahuxB6j1tMGZs1m10ey7eUj62WV2exLT4C83zl7Q80M";
            //int diff = 0;
            //var newS = "";
            //int k = 27;
            //for (int i = 0; i < s.Count(); i++)
            //{

       
            //   Solution s = new Solution();
            //var val=s.ContainsDuplicate(new int[] { 1, 2, 3, 2, 5 });

            //Console.WriteLine(val);

            var price = new List<int> { 5,10,3 };
            
            var min = price[0];
            for (int i = 0; i < price.Count(); i++)
            {
                for(int j=i+1; j<price.Count; j++)
                {
                    var diff= price[i]-price[j];
                    if(diff < min&&diff>0) min=diff;
                }

              
            }

            Console.WriteLine(Convert.ToInt32(min));
            //    char v = s[i];
            //    if (char.IsLetter(v))
            //    {
            //        char a = 'A';
            //        char z = 'Z';
            //        if (v >= 'a')
            //        {
            //            a = 'a';
            //            z = 'z';
            //        }


            //        diff = k - (z - v);
            //        if (diff >= 0) newS += (char)(a + (diff - 1)%26);
            //        else newS += (char)(v + k);
            //    }
            //    else newS += v;

            //}

            //Console.WriteLine(newS);


        }

        //Console.WriteLine('k');
    }




    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) return true;
            }

            return false;

        }
    }




}

