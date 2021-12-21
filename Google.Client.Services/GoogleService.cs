using Google.Client.Contracts;
using Google.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Client.Services
{
    public class GoogleService : IGoogleService
    {


        private readonly IHttpService _httpService;

        public GoogleService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<Countrie>> GetAllCountries()
        {
            return await _httpService.GetEntities<Countrie>("api/Google/GetCountrie");
        }

        public async Task<IEnumerable<Education>> GetAllEducations()
        {
            return await _httpService.GetEntities<Education>("api/Google/GetEducation");
        }

        public async Task<IEnumerable<VW_Individual>> GetAllIndividualVW(GoogleSearch filter)
        {
            return await _httpService.GetFilteredEntities<VW_Individual>("api/Google/GetFilteredIndividuals", filter);
        }

        public async Task<Individual> GetIndividualByGuid(Guid individualGuid)
        {
            return await _httpService.Get<Individual>("api/pocs/GetIndividualByGuid/" + individualGuid);
        }

        public async Task<Individual> Save(Individual student)
        {
            return await _httpService.Post<Individual>("api/pocs/SaveIndividuals", student);
        }
    }
}
