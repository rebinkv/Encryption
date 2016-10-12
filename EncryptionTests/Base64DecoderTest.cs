using Encryption;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResultDetails;

namespace EncryptionTests
{
    [TestClass]
    public class Base64DecoderTest
    {
        [TestMethod]
        public void Base64Decoder_ValidBase64StringGiven_ShouldReturnDecodedValue()
        {
            // Arrange
            Base64Decoder decoderObject = new Base64Decoder();
            Result resultObject = new Result();
            string encodedText = "VGhpcyBpcyBpbmRlZWQgdmVyeSBjb29sISBDb25ncmF0dWxhdGlvbnMhIQ==";

            // Act
            resultObject = decoderObject.Decode(encodedText);

            // Assert
            Assert.AreEqual("This is indeed very cool! Congratulations!!", resultObject.Data);
        }

        [TestMethod]
        public void Base64Decoder_NullOrEmptyStringGiven_ShouldReturnEmptyString()
        {
            // Arrange
            Base64Decoder decoderObject = new Base64Decoder();
            Result resultObject = new Result();
            string encodedText = "";

            // Act
            resultObject = decoderObject.Decode(encodedText);

            // Assert
            Assert.AreEqual("Enter the text to be decoded!", resultObject.Data);
        }

        [TestMethod]
        public void Base64Decoder_InvalidBase64StringGiven_ShouldReturnEmptyString()
        {
            // Arrange
            Base64Decoder decoderObject = new Base64Decoder();
            Result resultObject = new Result();
            string encodedText = "This is cool!";

            // Act
            resultObject = decoderObject.Decode(encodedText);

            // Assert
            Assert.AreEqual("The input is not a valid Base-64 string. Please enter a valid Base-64 string.", resultObject.Data);
        }
    }
}
