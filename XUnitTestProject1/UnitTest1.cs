using StringHelper.Lib;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var A = "A";
            Assert.Equal("B", A.Increase(1));

            var B = "B";
            Assert.Equal("C", B.Increase(1));

            var Z = "Z";
            Assert.Equal("AA", Z.Increase());

            var AY = "AY";
            Assert.Equal("AZ", AY.Increase());

            var AZ = "AZ";
            Assert.Equal("BA", AZ.Increase());

            var ZZ = "ZZ";
            Assert.Equal("AAA", ZZ.Increase());

            var ZAA = "ZAA";
            Assert.Equal("ZAB", ZAA.Increase());

            var ZAZ = "ZAZ";
            Assert.Equal("ZBA", ZAZ.Increase());

            var ZZZ = "ZZZ";
            Assert.Equal("AAAA", ZZZ.Increase());

        }
    }
}
