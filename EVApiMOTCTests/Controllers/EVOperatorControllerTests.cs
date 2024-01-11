using EVApiMOTC.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;

namespace EVApiMOTC.Tests
{
    [TestClass]
    public class XmlUtilityTests
    {

        [TestMethod]
        public void CreateXmlResponse_ValidXmlContentAndStatusCode_ReturnsContentResult()
        {
            // Arrange
            var xmlContent = new XElement("Test");
            var statusCode = 200;

            // Act
            var result = XmlUtility.CreateXmlResponse(xmlContent, statusCode);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("application/xml", result.ContentType);
            Assert.AreEqual(xmlContent.ToString(), result.Content);
            Assert.AreEqual(statusCode, result.StatusCode);
        }

        [TestMethod]
        public void CreateErrorResponse_ValidErrorMessageAndStatusCode_ReturnsErrorContentResult()
        {
            // Arrange
            var errorMessage = "Test error message";
            var statusCode = 500;

            // Act
            var result = XmlUtility.CreateErrorResponse(errorMessage, statusCode);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("application/xml", result.ContentType);
            Assert.AreEqual($"<Error>{errorMessage}</Error>", result.Content);
            Assert.AreEqual(statusCode, result.StatusCode);
        }
    }
}
