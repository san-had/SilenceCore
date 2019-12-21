using NUnit.Framework;

namespace Mp3Cutter.Tests.Unit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetFrameProSec_WithGeneralInput_ReturnGeneralOutput()
        {
            // Arrange
            var mp3Cutter = new Mp3Cutter.Service.Mp3Cutter();

            int totalFrameCount = 24;
            int totalTimeLength = 12;

            double expectedResult = 2.0;

            // Act
            double actualResult = mp3Cutter.GetFrameProSec(totalFrameCount, totalTimeLength);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}