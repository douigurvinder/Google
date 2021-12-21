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
    public class GoogleRepository : GoogleBaseDbContext<Individual, VW_Individual>, IGoogleRepository
    {
        protected override Individual AddEntity(GoogleDbContext entityContext, Individual entity)
        {
            return entityContext.IndividualSet.Add(entity).Entity;

        }

        protected override IEnumerable<Individual> GetEntities(GoogleDbContext entityContext)
        {
            return (from e in entityContext.IndividualSet
                    select e);
        }

        protected override Individual GetEntity(GoogleDbContext entityContext, int id)
        {
            return (from e in entityContext.IndividualSet
                    where e.IndividualID == id
                    select e).SingleOrDefault();
        }

        protected override Individual GetEntity(GoogleDbContext entityContext, Guid guid)
        {
            return (from e in entityContext.IndividualSet
                    where e.IndividualGuid == guid
                    select e).FirstOrDefault();
        }

        protected override IEnumerable<VW_Individual> GetViewEntities(GoogleDbContext entityContext, GoogleSearch filter)
        {
            if (!string.IsNullOrEmpty(filter.Name)) {
                return (from e in entityContext.VW_IndividualSet
                        where e.Name.ToLower() == filter.Name.ToLower()
                        select e);
            }

            return (from e in entityContext.VW_IndividualSet
                    select e);
        }

        protected override VW_Individual GetViewEntity(GoogleDbContext entityContext, GoogleSearch filter)
        {
            throw new NotImplementedException();
        }

        protected override VW_Individual GetViewEntity(GoogleDbContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override VW_Individual GetViewEntity(GoogleDbContext entityContext, Guid guid)
        {
            throw new NotImplementedException();
        }

        protected override Individual UpdateEntity(GoogleDbContext entityContext, Individual entity)
        {
            return (from e in entityContext.IndividualSet
                    where e.IndividualID == entity.IndividualID
                    select e).FirstOrDefault();
        }
    }
}
