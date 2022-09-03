using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public static class Test5
    {

        [Theory]
        [InlineData(new int[]{20,50,-5,10,-2,0})]
        public static void Test5_equals_sorted_descending(int[] values)
        {
            Assert.Equal(new int[]{50,20,10,0,-2,-5}, test5.solution(values));
        }
    }
}