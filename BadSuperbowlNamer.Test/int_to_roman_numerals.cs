using System;
using Xunit;

namespace BadSuperbowlNamer.Test
{
    public class int_to_roman_numerals
    {
        [Fact]
        public void translating_1_results_in_I()
        {
            //Arrange
            var number = 1;
            var expectedResult = "I";
            var translator = new Translator();

            //Act
            var actuallyResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actuallyResult);
        }

        [Fact]
        public void translating_5_results_in_V()
        {
            //Arrange
            var number = 5;
            var expectedResult = "V";
            var translator = new Translator();

            //Act
            var actuallyResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actuallyResult);
        }

        [Fact]
        public void translating_9_results_in_IX()
        {
            //Arrange
            var number = 9;
            var expectedResult = "IX";
            var translator = new Translator();

            //Act
            var actuallyResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actuallyResult);
        }
    }
}
