using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class facilities : IEntity
    {

        public int id { get; set; }

        public string facilitiy_name { get; set; }
    }
}
