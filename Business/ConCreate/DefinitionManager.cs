using Business.Abstract;
using DataAccess.Abstract;
using Entities.ConCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.ConCreate
{
    public class DefinitionManager : IDefinitionService
    {
        ICityDal _cityDal;
        ICountryDal _countryDal;
        public DefinitionManager(ICityDal cityDal, ICountryDal countryDal)
        {
            _cityDal = cityDal;
            _countryDal = countryDal;
        }
        public List<cities> GetCities(int country_id)
        {
            return _cityDal.GetList(x => x.country_id == country_id);
        }

        public List<countries> GetCountries()
        {
            return _countryDal.GetList();
        }
    }
}
