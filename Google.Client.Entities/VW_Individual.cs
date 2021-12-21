using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Client.Entities
{
   public class VW_Individual
    {

        public int IndividualID { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int? EducationID { get; set; }

        public string EducationText { get; set; }

        public int? CountryID { get; set; }

        public string CountryText { get; set; }

        public string WorkExperience { get; set; }

        public Guid? IndividualGuid { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
