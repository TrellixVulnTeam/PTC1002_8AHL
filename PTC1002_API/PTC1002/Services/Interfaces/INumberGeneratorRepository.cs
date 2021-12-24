using PTC1002.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTC1002.Services.Interfaces
{
    public interface INumberGeneratorRepository
    {
        RandomNumberDto GenerateRandomNumber(string fileSize);
        List<ReportRandomNumberDto> ViewRandomNumberReport();
        
    }
}
