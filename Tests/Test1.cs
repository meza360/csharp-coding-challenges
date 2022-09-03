using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public class Test1
    {
        [Theory]
        [InlineData("abc", "abcabc")]
        [InlineData("abc", "abccba")]
        [InlineData("abcc", "abccdjfhccba")]
        [InlineData("abcc", "abcccba")]
        public void Test1_qty_2(string val1, string val2)
        {
            Assert.Equal(2, test1.solution(val1, val2));
        }

        [Theory]
        [InlineData("abc", "abccbc")]
        [InlineData("abc", "abccb")]
        [InlineData("abcc", "abcdjfhccba")]
        [InlineData("abcc", "abccbba")]
        public void Test1_qty_1(string val1, string val2)
        {
            Assert.Equal(1, test1.solution(val1, val2));
        }

        [Theory]
        [InlineData("abc", "acb")]
        [InlineData("abc", "cab")]
        [InlineData("abcc", "abcdcba")]
        [InlineData("abcc", "abbcbba")]
        public void Test1_qty_0(string val1, string val2)
        {
            Assert.Equal(0, test1.solution(val1, val2));
        }
    }
}