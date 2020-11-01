using Business.Abstract;
using Entities.ConCreate;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using WebApi.Controllers.Werenda;

namespace WebApi.Controllers
{
    [ApiController]
    public class DefinitionController : BaseController
    {
        IDefinitionService _defService;
        public DefinitionController(IDefinitionService defService)
        {
            _defService = defService;
        }
        [Route("api/definition/countries")]
        public List<countries> GetCountries()
        {
            return _defService.GetCountries();
        }


        [Route("api/definition/cities/{country_id}")]
        public List<cities> GetCities(int country_id)
        {
            return _defService.GetCities(country_id);
        }

    }
}
