using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class products : IEntity
    {
        public int id { get; set; }

        public int? user_id { get; set; }

        public int no { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public int type { get; set; }

        public int? meter { get; set; }

        public int? room_type { get; set; }

        public int? floor_type { get; set; }

        public int? heating_type { get; set; }

        public int? bathroom_count { get; set; }

        public bool in_sites { get; set; }

        public int? country_id { get; set; }

        public int? city_id { get; set; }

        public int? district_id { get; set; }

        public decimal? langitude { get; set; }

        public decimal? longitude { get; set; }

        public string address_description { get; set; }

        public bool is_active { get; set; }

        public bool is_published { get; set; }
    }
}
