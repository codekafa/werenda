using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class countries : IEntity
    {
        public int id { get; set; }
        public string logopath { get; set; }
        public string name { get; set; }
    }
}
