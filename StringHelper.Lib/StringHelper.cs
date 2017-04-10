using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringIncrease.Lib
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

        public static string Increase2(this string s, int addValue = 1)
        {
            if (string.IsNullOrEmpty(s)) {
                throw new Exception("不能为空");
            }
            /*
             A001 +1 = A002
             A009 + 1 = A010;
             */
            var reg = Regex.Match(s, "(^[A-Za-z]+)(\\d+$)");
            if (!reg.Success) {
                throw new Exception("格式不匹配");
            }
            var str = reg.Groups[1].Value;//group 0 是本身.
            var newNum = Convert.ToInt32(reg.Groups[2].Value)+addValue;
            return str + newNum.ToString("000");
        }
    }
}
