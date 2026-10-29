using ClassLibrary1;
namespace TUnitTest
{
    public class UnitTest2
    {
        [Fact]
        public void CreateArray_WithValidSize_CreateArray()
        {
            //Arrange
            int size = 5;
            //Act
            CMassive massTesting = new CMassive(size);
            //Assert
            Assert.Equal(size, massTesting.getLengthMass);
        }
        [Fact]
        public void GetCount_WithCorrectIndex_ReturnCorrectCount()
        {
            //Arrange
            double[] testData = { 10.0, 20.0, 30.0, 40.0, 50.0 };
            int expected = 2;
            //Act
            CMassive massTesting = new CMassive(testData);
            int actual = massTesting.GetCount(2);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithIndexOutOfRange_ReturnZero()
        {
            //Arrange
            double[] testData = { 5.78, 10.7, 15.74 };
            int expected = 0;
            //Act
            CMassive massTesting = new CMassive(testData);
            int actual = massTesting.GetCount(10);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithIndex0_ReturnAllElements()
        {
            //Arrange
            double[] testData = { 10.0, 20.0, 30.0, 40.0 };
            int expected = 3;
            //Act
            CMassive massTesting = new CMassive(testData);
            int actual = massTesting.GetCount(0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithNegativeNumbersGreaterThanThreshold_ReturnCorrectCount()
        {
            //Arrange
            double[] testData = { -1.75, -2.74, -3.0, -10.12 };
            int expected = 3;
            double threshold = -5.0;
            //Act
            CMassive massTesting = new CMassive(testData);
            int actual = massTesting.GetCount(threshold);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithPositiveThreshold_ReturnZero()
        {
            //Arrange
            double[] testData = { -1.0, -2.22, -3.12 };
            double threshold = 5.0;
            int expected = 0;
            //Act
            CMassive massTesting = new CMassive(testData);
            int actual = massTesting.GetCount(threshold);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithoutNegativeNumbers_ReturnZero()
        {
            //Arrange
            double[] testData = { 1.74, 2.12, 3.47, 4.65 };
            double threshold = -10.0;
            int expected = 0;
            //Act
            CMassive massTesting = new CMassive(testData);
            int actual = massTesting.GetCount(threshold);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetResult_WithMixedNumbers_ReturnNegativeCount()
        {
            //Arrange
            double[] testData = { -1.0, -2.22, 3.12, 1.0, -2.22 };
            int expected = 3;
            //Act
            CMassive massTesting = new CMassive(testData);
            int actual = massTesting.GetCount();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetResult_OnlyPositiveNumbers_ReturnZero()
        {
            //Arrange
            double[] testData = { 5.78, 10.7, 15.74 };
            int expected = 0;
            //Act
            CMassive massTesting = new CMassive(testData);
            int actual = massTesting.GetCount();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetResult_OnlyNegativeNumbers_ReturnsAllElements()
        {
            //Arrange
            double[] testData = { -10.0, -20.0, -30.0, -40.0 };
            int expected = 4;
            //Act
            CMassive massTesting = new CMassive(testData);
            int actual = massTesting.GetCount();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}