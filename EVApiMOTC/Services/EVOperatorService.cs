using EVApiMOTC.Models;
using EVApiMOTC.Repositories;

namespace EVApiMOTC.Services
{
    /// <summary>
    /// Service class for retrieving the latest operator data.
    /// </summary>
    public class EVOperatorService
    {
        private readonly EVOperatorRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EVOperatorService"/> class.
        /// </summary>
        /// <param name="repository">The repository used to fetch operator data.</param>
        public EVOperatorService(EVOperatorRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Gets the latest operator data.
        /// </summary>
        /// <returns>The latest operator data.</returns>
        public EV_OperatorData GetLatestOperatorData()
        {
            return _repository.FetchLatestOperatorData();
        }
    }
}
