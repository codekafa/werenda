using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class cities : IEntity
    {
        public int id { get; set; }
        public int country_id { get; set; }
        public string name { get; set; }
    }
}
