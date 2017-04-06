using System;
using System.Collections.Generic;
using System.Linq;

namespace StringHelper.Lib
{
    public static class StringHelper
    {
        public static string Increase(this string s, int addValue = 1)
        {
            if (String.IsNullOrEmpty(s)) {
                return "A";
            }
            /*
             A+1 = B
             65+1 = 66
             AA+1 = AB
             65 65 +1 = 65 66
             AZ+1 = BA
             65 90 + 1 = 66 65
             AAA+1 = AAB
             AAZ+ 1 = ABA
             ZZZ+1 = AAAA
             */
            var rvs = String.Join("", s.Reverse());
            var arry = s.Reverse().ToArray();
            var index = 0;
            while (arry[index] + addValue > 'Z') {
                var old = arry[index];
                arry[index] = (char)((old + addValue) % 90 + 64);
                index++;
                addValue = (old + addValue) / 90;
                if (index > arry.Length - 1) {
                    arry = arry.Append((char)64).ToArray();
                    break;
                }
            }
            arry[index] = (char)(arry[index] + addValue);
            var rst = string.Join("", arry.Reverse());
            return rst;
            //return String.Join("", result);
        }
        private static (bool carry, char) AddNum(char c, int number)
        {
            if (c + number > 90) {
                return (true, (char)((c + number) % 90));
            } else {
                return (false, (char)(c + number));
            }
        }
    }
}
