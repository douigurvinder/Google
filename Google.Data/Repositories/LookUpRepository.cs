using Google.Business.Entities;
using Google.Data.Contracts;
using Google.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Data.Repositories
{
    public class LookUpRepository : ILookUpRepository
    {

        GoogleDbContext ctx;
        public LookUpRepository()
        {
            ctx = new GoogleDbContext();
        }


        public IEnumerable<Countrie> GetCountrie()
        {
            return (from e in ctx.CountrieSet
                    select e);
        }



        public IEnumerable<Education> GetEducation()
        {
            return (from e in ctx.EducationSet
                    select e);
        }


    }
}
