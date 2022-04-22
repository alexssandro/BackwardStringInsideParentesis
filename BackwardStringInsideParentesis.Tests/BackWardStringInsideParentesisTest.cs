using FluentAssertions;
using Xunit;

namespace BackwardStringInsideParentesis.Tests
{
    public class BackWardStringInsideParentesisTest
    {
        [Theory]
        [InlineData("abcdef", "abcdef")]
        [InlineData("ab(cd)ef", "ab(dc)ef")]
        [InlineData("ab(cd)ef(gh)ij", "ab(dc)ef(hg)ij")]
        [InlineData("(abcd)", "(dcba)")]
        public void GivenAnInputWithNoParentesis_ShouldNotBackWardsAnything(string input, string expectedOutPut)
        {
            string output = StringTreating.BackWardsString(input);
            output.Should().Be(expectedOutPut);
        }
    }
}