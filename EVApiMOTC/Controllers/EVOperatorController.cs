using EVApiMOTC.Services;
using EVApiMOTC.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace EVApiMOTC.Controllers
{
    /// <summary>
    /// Controller for retrieving EV operator data.
    /// </summary>
    [ApiController]
    [Route("/Parking/EV/EVOperator/City/")]
    public class EVOperatorController : ControllerBase
    {
        private readonly EVOperatorService _operatorService;
        private readonly ILogger<EVOperatorController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EVOperatorController"/> class.
        /// </summary>
        /// <param name="operatorService">The EV operator service.</param>
        /// <param name="logger">The logger.</param>
        public EVOperatorController(EVOperatorService operatorService, ILogger<EVOperatorController> logger)
        {
            _operatorService = operatorService;
            _logger = logger;
        }

        /// <summary>
        /// Gets EV operator data in XML format.
        /// </summary>
        /// <returns>An XML response containing EV operator data or an error response.</returns>
        [HttpGet]
        public ContentResult GetEVOperatorByCity()
        {
            _logger.LogInformation("Getting EV operator data");
            try
            {
                var latestOperatorData = _operatorService.GetLatestOperatorData();
                if (latestOperatorData == null)
                {
                    return XmlUtility.CreateErrorResponse("No data found", 204);
                }

                var xmlContent = XmlUtility.GenerateXmlContent(latestOperatorData);
                return XmlUtility.CreateXmlResponse(xmlContent, 200);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception occurred while getting EV operator data");
                return XmlUtility.CreateErrorResponse("Internal Server Error", 500);
            }
        }

    }
}
