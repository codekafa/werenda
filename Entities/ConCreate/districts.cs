using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class districts : IEntity
    {
        public int id { get; set; }

        public int city_id { get; set; }

        public string name { get; set; }
    }
}
