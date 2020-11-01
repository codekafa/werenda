using Entities.ConCreate;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDefinitionService
    {
        List<countries> GetCountries();
        List<cities> GetCities(int country_id);

    }
}
