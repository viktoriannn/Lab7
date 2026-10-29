using ClassLibrary1;
namespace TUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetCount_WithPositiveAndNegativeNumbers_CorrectCount()
        {
            //Arrange
            double[] massTest = new double[] { 5.0, -6.0, 84.45, -2.89, 7.74, -9.78 };
            int expected = 3;
            //Act
            CMassive massTesting = new CMassive(massTest);
            int actual = massTesting.GetCount();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithCorrectIndex_CorrectCount()
        {
            //Arrange
            double[] massTest = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
            int expected = 2;
            //Act
            CMassive massTesting = new CMassive(massTest);
            int actual = massTesting.GetCount(2);
            //Assert
            Assert.Equal(expected, actual);  
        }
        [Fact]
        public void GetCount_WithCorrectThreshold_CorrectCount()
        {
            //Arrange
            double[] massTest = new double[] { -10.0, -3.0, -1.0, 5.0 };
            int expected = 2;
            //Act
            CMassive massTesting = new CMassive(massTest);
            int actual = massTesting.GetCount(-5.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithEmptyArray_CorrectCount()
        {
            //Arrange
            double[] massTest = new double[] { };
            int expected = 0;
            //Act
            CMassive masstesting = new CMassive(massTest);
            int actual = masstesting.GetCount();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithOnlyPositiveNumbers_CorrectCount()
        {
            //Arrange
            double[] massTest = new double[] { 1.5, 2.3, 3.8, 4.96, 5.56, 10.964, 20.789, 30.00 };
            int expected = 0;
            //Act
            CMassive massTesting = new CMassive(massTest);
            int actual = massTesting.GetCount();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithOnlyNegativityNumbers_CorrectCount()
        {
            //Arrange
            double[] massTest = new double[] { -1.0, -2.0, -3.0, -4.0, -5.0, -10.0, -20.0 };
            int expected = 7;
            //Act
            CMassive massTesting = new CMassive(massTest);
            int actual = massTesting.GetCount();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithIndexAtBeginning_ReturnsCountNumbersMinusOne()
        {
            //Arrange
            double[] massTest = new double[] { 10.0, 20.0, 30.0, 40.0 };
            int expected = 3;
            //Act
            CMassive massTesting = new CMassive(massTest);
            int actual = massTesting.GetCount(0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetCount_WithIndexOutOfRange_ReturnsZero()
        {
            //Arrange
            double[] massTest = new double[] { 5.78, 10.7, 15.74 };
            int expected = 0;
            //Act
            CMassive massTesting = new CMassive(massTest);
            int actual = massTesting.GetCount(5);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
