namespace TestProject3_Cake_1
{
    public class CakeTests
    {
        [Fact]
        public void BakedTheCakeGoodTempAndTimeTest()
        {
            // Arrange
            TimeSpan time = new TimeSpan(0, 45, 0);
            double temp = 175.2;
            Cake testCake = new Cake("strawberryJam", "cream", time, temp);


            // Act
            bool cakeNotDone = testCake.BakeAndDone;
            bool result = testCake.BakeTheCake(temp,time);
            // Assert
            Assert.False(cakeNotDone);
            Assert.True(result);
            Assert.True(testCake.BakeAndDone);
        }
        [Fact]
        public void BurnTheCakeTest()
        {
            // Arrange
            TimeSpan time = new TimeSpan(0, 45, 0);
            double temp = 175.2;
            Cake testCake = new Cake("AppleJam", "cream", time, temp);

            //Act
            bool cakeNotDone = testCake.BurnAndDone;
            Exception result = Assert.Throws<Exception>(())=>testCake(temp * 3),(time * 3)));

            //Assert
            Assert.False(cakeNotDone);
            Assert.Contains("burn", result.Message);
            Assert.False(testCake.BurnAndDone);
        }
        [Theory]

        public void BakeTheCakeBadTempTimetest(double tempOffset, double timeoffset)
        {
            // Arrange
            TimeSpan time = new TimeSpan(0, 45, 0);
            Double temp = 175.2;
            CakeTests = new CakeTests("AppleJam", "cream", time, temp);
            // Act
            bool cakeNotDone = TestCake.BakeAndDone;
            bool result = TestProject3_Cake_1.(temp * tempoffset, time * timeoffset);

            // Assert

            Assert.False(cakeNotDone);
            Assert.False(false);
            Assert.False(TestProject3_Cake_1.BakedAndDone);
        }
    }
}