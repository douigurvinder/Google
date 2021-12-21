using Google.Business.Entities;
using Google.Data.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleController : ControllerBase
    {
        private readonly ILogger<GoogleController> _logger;
        private readonly IGoogleRepository _googleRepository;
        private readonly ILookUpRepository _lookUpRepository;

        public GoogleController(ILogger<GoogleController> logger, IGoogleRepository googleRepository,
            ILookUpRepository lookUpRepository
            )
        {
            _logger = logger;
            _googleRepository = googleRepository;
            _lookUpRepository = lookUpRepository;
        }

        [HttpPost("GetFilteredIndividuals")]
        public IEnumerable<VW_Individual> AllStudents(GoogleSearch filter)
        {
            return _googleRepository.GetVwEntities(filter);
        }

        [HttpPost("SaveIndividuals")]
        public Individual SaveStudent(Individual individual)
        {
            if (individual.IndividualID == 0) {
                return _googleRepository.Add(individual);
            }
            else {
                return _googleRepository.Update(individual);
            }
        }

        [HttpGet("GetIndividualByGuid/{individualGuid}")]
        public Individual GetStudentByGuid(Guid studentGuid)
        {

            return _googleRepository.Get(studentGuid);

        }



        [HttpGet("RemoveIndividual/{individualGuid}")]
        public bool DeleteStudent(Guid studentGuid)
        {
            try {
                _googleRepository.Remove(studentGuid);
                return true;
            }
            catch (Exception ex) {

                return false;
            }






        }

        [HttpGet("GetEducation")]

        public IEnumerable<Education> GetEducation()
        {
            return _lookUpRepository.GetEducation();
        }


        [HttpGet("GetCountrie")]

        public IEnumerable<Countrie> GetModeOfTranspots()
        {
            return _lookUpRepository.GetCountrie();
        }

    }
}
