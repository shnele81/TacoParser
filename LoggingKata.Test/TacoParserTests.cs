using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("31.570771,-84.10353, Taco Bell Albany...", -84.10353)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", -86.97191)]
        [InlineData("34.679723,-84.487535,Taco Bell East Ellija...", -84.487535)]
        [InlineData("34.677279,-86.749702,Taco Bell Madison...", -86.749702)]
        [InlineData("34.019885,-84.528291,Taco Bell Marietta...", -84.528291)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("33.594359,-86.122022,Taco Bell Lincoln...", 33.594359)]
        [InlineData("33.849014,-87.279978,Taco Bell Jasper...", 33.849014)]
        [InlineData("30.533164,-87.262229,Taco Bell Pensacola...", 30.533164)]
        [InlineData("34.8709,-85.519289,Taco Bell Trenton...", 34.8709)]
        [InlineData("34.2223,-84.503673,Taco Bell Canton...", 34.2223)]

        public void ShouldParseLatitude(string line, double expected)
        {
            var tacoParser = new TacoParser();
            var actual = tacoParser.Parse(line);
            Assert.Equal(expected, actual.Location.Latitude);
        }


    }
}
