using FluentAssertions;
using StringCalculator.Domain.Models;

namespace StringCalculator.UnitTests
{
    public class StringCalculatorUnitTest
    {
        [Fact]
        public void StringCalculator_EmptyString_ResultShouldBeZero()
        {
            var sut = new Domain.Models.StringCalculator();

            int result = sut.Add("");

            Assert.Equal(0, result);
        }

        [Fact]
        public void StringCalculator_Null_ResultShouldBeZero()
        {
            var sut = new Domain.Models.StringCalculator();

            int result = sut.Add(null);

            Assert.Equal(0, result);
        }

        [Fact]
        public void StringCalculator_ThreeNumbersSeparatedByCommas_ShouldThrowException()
        {
            var sut = new Domain.Models.StringCalculator();

            Action addDecimal = () => sut.Add("1,2,3");

            addDecimal.Should().Throw<ArgumentException>().WithMessage("*numbers*");
        }
        [Fact]
        public void StringCalculator_WhenConsecutiveCommas_ShouldThrowException()
        {
            var sut = new Domain.Models.StringCalculator();

            Action addDecimal = () => sut.Add("1,,3");

            addDecimal.Should().Throw<ArgumentException>().WithMessage("*numbers*");
        }

        [Fact]
        public void StringCalculator_WhenContainsNonNumbers_ShouldThrowException()
        {
            var sut = new Domain.Models.StringCalculator();

            Action addDecimal = () => sut.Add("1,a");

            addDecimal.Should().Throw<ArgumentException>().WithMessage("*numbers*");
        }
    }
}