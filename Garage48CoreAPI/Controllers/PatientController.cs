using System;
using System.Threading.Tasks;
using Garage48CoreAPI.Models;
using Garage48CoreAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Garage48CoreAPI.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientInformationRepository _informationRepository;
        private readonly IPersonalDatumRepository _datumRepository;
        
        public PatientController(
            IPatientInformationRepository informationRepository,
            IPersonalDatumRepository datumRepository)
        {
            _datumRepository = datumRepository;
            _informationRepository = informationRepository;
        }
        
        [HttpGet]
        [Route("/api/patient/{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var model = await _informationRepository.GetAsync(id);
            return new JsonResult(model);
        }
        
        [HttpGet]
        [Route("/api/person/{id}")]
        public async Task<IActionResult> GetDataById(int id)
        {
            var model = await _datumRepository.GetAsync(id);
            return new JsonResult(model);
        }
    }
}