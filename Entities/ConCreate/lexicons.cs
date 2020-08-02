using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public  class lexicons : IEntity
    {

        public int id { get; set; }


        public int culture_id { get; set; }

        public string key { get; set; }

        public string value { get; set; }

    }
}
