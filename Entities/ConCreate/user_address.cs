using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class user_address : IEntity
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

        public int? city_id { get; set; }

        public int district_id { get; set; }

        public string zip_code { get; set; }

        public int address_type { get; set; }
    }
}
