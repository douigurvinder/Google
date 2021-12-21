using Core.Common.Data;
using Google.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Data.Helpers
{
   public abstract class GoogleBaseDbContext<T, VW> : CoreRepository<T, VW, GoogleSearch, GoogleDbContext>
       where T : class, new()
       where VW : class, new()
    {
    }
}
