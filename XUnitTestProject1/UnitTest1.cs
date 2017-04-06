
using StringIncrease.Lib;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Increase_Test()
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
        [Fact]
        public void Increase2_Test()
        {
            var A001 = "A001";
            Assert.Equal("A002", A001.Increase2());

            var A009 = "A009";
            Assert.Equal("A010", A009.Increase2());

            var BA109 = "BA109";
            Assert.Equal("BA110", BA109.Increase2());
        }
    }
}
