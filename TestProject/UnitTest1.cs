using System.Numerics;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GenerateRandomNumber_ReturnsNonZero()
        {
            // Arrange
            BigInteger p = 997;
            BigInteger q = 991;
            BigInteger x = 123;
            BBS bbs = new BBS();
            bbs.setAll(p, q, x);

            // Act
            BigInteger result = bbs.GenerateRandomNumber(256);

            // Assert
            Assert.AreNotEqual(BigInteger.Zero, result);
        }

        [Test]
        public void GenerateRandomNumber_ReturnsBigIntegerWithCorrectBitLength()
        {
            // Arrange
            BigInteger p = 997;
            BigInteger q = 991;
            BigInteger x = 123;
            BBS bbs = new BBS();
            bbs.setAll(p, q, x);
            int numBits = 256;

            // Act
            BigInteger result = bbs.GenerateRandomNumber(numBits);

            // Assert
            Assert.AreEqual(numBits, result.ToByteArray().Length * 8); // ѕровер€ем, что длина в битах равна запрошенной
        }
    }
}