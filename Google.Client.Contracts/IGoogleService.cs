using Google.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Client.Contracts
{
   public interface IGoogleService
    {
        Task<IEnumerable<VW_Individual>> GetAllIndividualVW(GoogleSearch filter);
        Task<Individual> GetIndividualByGuid(Guid individualGuid);
        Task<Individual> Save(Individual student);
        Task<IEnumerable<Countrie>> GetAllCountries();
        Task<IEnumerable<Education>> GetAllEducations();

    }
}
