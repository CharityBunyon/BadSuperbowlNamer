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
        [Fact]
        public void translating_3_results_in_III()
        {
            //Arrange
            var number = 3;
            var expectedResult = "III";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_12_results_in_XII()
        {
            //Arrange
            var number = 12;
            var expectedResult = "XII";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_14_results_in_XIV()
        {
            //Arrange
            var number = 14;
            var expectedResult = "XIV";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_29_results_in_XXIX()
        {
            //Arrange
            var number = 29;
            var expectedResult = "XXIX";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_44_results_in_XLIV()
        {
            //Arrange
            var number = 44;
            var expectedResult = "XLIV";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_45_results_in_XLV()
        {
            //Arrange
            var number = 45;
            var expectedResult = "XLV";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_68_results_in_LXVIII()
        {
            //Arrange
            var number = 68;
            var expectedResult = "LXVIII";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_83_results_in_LXXXIII()
        {
            //Arrange
            var number = 83;
            var expectedResult = "LXXXIII";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_97_results_in_XCVII()
        {
            //Arrange
            var number = 97;
            var expectedResult = "XCVII";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_99_results_in_XCIX()
        {
            //Arrange
            var number = 99;
            var expectedResult = "XCIX";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_500_results_in_D()
        {
            //Arrange
            var number = 500;
            var expectedResult = "D";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_501_results_in_DI()
        {
            //Arrange
            var number = 501;
            var expectedResult = "DI";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_649_results_in_DCXLIX()
        {
            //Arrange
            var number = 649;
            var expectedResult = "DCXLIX";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_798_results_in_DCCXCVIII()
        {
            //Arrange
            var number = 798;
            var expectedResult = "DCCXCVIII";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_891_results_in_DCCCXCI()
        {
            //Arrange
            var number = 891;
            var expectedResult = "DCCCXCI";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_1000_results_in_M()
        {
            //Arrange
            var number = 1000;
            var expectedResult = "M";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_1004_results_in_MIV()
        {
            //Arrange
            var number = 1004;
            var expectedResult = "MIV";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_1006_results_in_MVI()
        {
            //Arrange
            var number = 1006;
            var expectedResult = "MVI";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_1023_results_in_MXXIII()
        {
            //Arrange
            var number = 1023;
            var expectedResult = "MXXIII";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_2014_results_in_MMXIV()
        {
            //Arrange
            var number = 2014;
            var expectedResult = "MMXIV";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translating_3999_results_in_MMMCMXCIX()
        {
            //Arrange
            var number = 3999;
            var expectedResult = "MMMCMXCIX";
            var translator = new Translator();


            //Act
            var actualResult = translator.Translate(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
