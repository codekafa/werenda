using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class user_credits : IEntity
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public string credit_no { get; set; }

        public string sec_no { get; set; }

        public string exp_date { get; set; }

        public string full_name { get; set; }
        public bool is_mastercart { get; set; }

        public bool is_visa { get; set; }
        public bool is_primary { get; set; }
    }
}
