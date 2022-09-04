using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public class Test7
    {
        public Tuple<char?, int> MostRepeated(string phrase)
        {
            return test7.solution(phrase);
        }

        [Theory]
        [InlineData("aabceee")]
        public void Test7_equals_e(string phrase)
        {
            Assert.Equal(new Tuple<char?, int>('e', 3), MostRepeated(phrase));
        }
    }
}