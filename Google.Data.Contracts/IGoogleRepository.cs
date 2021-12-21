using Core.Common.Contracts;
using Google.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Data.Contracts
{
   public interface IGoogleRepository : ICoreRepository<Individual, VW_Individual, GoogleSearch>
    {

    }
}
