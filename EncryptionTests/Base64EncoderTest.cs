using Encryption;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResultDetails;

namespace EncryptionTests
{
    [TestClass]
    public class Base64EncoderTest
    {
        [TestMethod]
        public void Base64Encoder_PlainTextGiven_ShouldReturnEncodedValue()
        {
            // Arrange
            Base64Encoder encoderObject = new Base64Encoder();
            Result resultObject = new Result();
            string plainText = "Twinkle twinkle little star...";

            // Act
            resultObject = encoderObject.Encode(plainText);

            // Assert
            Assert.AreEqual("VHdpbmtsZSB0d2lua2xlIGxpdHRsZSBzdGFyLi4u", resultObject.Data);
        }

        [TestMethod]
        public void Base64Decoder_NullOrEmptyStringGiven_ShouldReturnEmptyString()
        {
            // Arrange
            Base64Encoder encoderObject = new Base64Encoder();
            Result resultObject = new Result();
            string plainText = "";

            // Act
            resultObject = encoderObject.Encode(plainText);

            // Assert
            Assert.AreEqual("Enter the text to be encoded!", resultObject.Data);
        }
    }
}