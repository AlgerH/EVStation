using EVApiMOTC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EVApiMOTC.Utilities
{
    /// <summary>
    /// Utility class for generating XML content from EV Operator data.
    /// </summary>
    public static class XmlUtility
    {
        private const string DefaultNamespace = "https://traffic.transportdata.tw/standard/EVStation/schema/";
        private const string XsiNamespace = "http://www.w3.org/2001/XMLSchema-instance";

        /// <summary>
        /// Generates XML content from EV Operator data.
        /// </summary>
        /// <param name="operatorData">The EV Operator data.</param>
        /// <returns>An XElement representing the XML content.</returns>
        public static XElement GenerateXmlContent(EV_OperatorData operatorData)
        {
            XNamespace defaultNs = DefaultNamespace;
            XNamespace xsiNs = XsiNamespace;

            var xmlContent = new XElement(defaultNs + "EVOperatorList",
                new XAttribute(XNamespace.Xmlns + "xsi", xsiNs),
                new XAttribute(xsiNs + "schemaLocation", "https://traffic.transportdata.tw/standard/EVStation/schema/"),
                new XElement(defaultNs + "UpdateTime", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss+08:00")),
                new XElement(defaultNs + "UpdateInterval", 86400),
                new XElement(defaultNs + "AuthorityCode", operatorData.AuthorityCode),
                new XElement(defaultNs + "Operators",
                    new XElement(defaultNs + "Operator",
                        new XElement(defaultNs + "OperatorID", operatorData.OperatorID),
                        new XElement(defaultNs + "OperatorName",
                            new XElement(defaultNs + "Zh_tw", operatorData.OperatorName_Zh_tw),
                            new XElement(defaultNs + "En", operatorData.OperatorName_En)),
                        new XElement(defaultNs + "Telephone", operatorData.Telephone),
                        new XElement(defaultNs + "Address", operatorData.Address),
                        new XElement(defaultNs + "WebURL", operatorData.WebURL),
                        new XElement(defaultNs + "LogoURL", operatorData.LogoURL),
                        new XElement(defaultNs + "TsAndCsURL", operatorData.TsAndCsURL),
                        new XElement(defaultNs + "BAN", operatorData.BAN))));

            return xmlContent;
        }

        /// <summary>
        /// Creates an XML response with the specified content and status code.
        /// </summary>
        /// <param name="xmlContent">The XML content to include in the response.</param>
        /// <param name="statusCode">The HTTP status code of the response.</param>
        /// <returns>An XML response with the specified content and status code.</returns>
        public static ContentResult CreateXmlResponse(XElement xmlContent, int statusCode)
        {
            return new ContentResult
            {
                ContentType = "application/xml",
                Content = xmlContent.ToString(),
                StatusCode = statusCode
            };
        }

        /// <summary>
        /// Creates an error XML response with the specified error message and status code.
        /// </summary>
        /// <param name="errorMessage">The error message to include in the response.</param>
        /// <param name="statusCode">The HTTP status code of the error response.</param>
        /// <returns>An error XML response with the specified error message and status code.</returns>
        public static ContentResult CreateErrorResponse(string errorMessage, int statusCode)
        {
            return new ContentResult
            {
                ContentType = "application/xml",
                Content = $"<Error>{errorMessage}</Error>",
                StatusCode = statusCode
            };
        }
    }
}
