using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class product_photos : IEntity
    {
        public int id { get; set; }

        public int product_id { get; set; }

        public string small_url { get; set; }

        public string medium_url { get; set; }

        public string large_url { get; set; }

        public bool is_main { get; set; }
    }
}
