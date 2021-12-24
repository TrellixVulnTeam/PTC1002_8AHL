using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PTC1002.Dtos;
using PTC1002.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTC1002.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberGeneratorController : ControllerBase
    {
        private readonly INumberGeneratorRepository _numberGeneratorRepository;
        public NumberGeneratorController(INumberGeneratorRepository numberGeneratorRepository)
        {
            _numberGeneratorRepository = numberGeneratorRepository;
        }

        [HttpGet("GenerateRandomNumber/{fileSize}")]
        public ActionResult<RandomNumberDto> GenerateRandomNumber(string fileSize)
        {
          
               var proformaMst = _numberGeneratorRepository.GenerateRandomNumber( fileSize);
            
            return proformaMst;
        }
        [HttpGet("ViewRandomNumberReport")]
        public List<ReportRandomNumberDto> ViewRandomNumberReport()
        {

            var proformaMst =  _numberGeneratorRepository.ViewRandomNumberReport();

            return proformaMst;
        }

    }
}
