using Google.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Data.Mapper
{
   public class VW_IndividualConfiguration : IEntityTypeConfiguration<VW_Individual>
    {
        public void Configure(EntityTypeBuilder<VW_Individual> builder)
        {
            builder.ToView("VW_Individual");
            builder.HasKey(t => t.EducationID);
        }
    }
}
