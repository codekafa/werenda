using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class cultures : IEntity
    {

        public int id { get; set; }

        public string name { get; set; }

        public string code { get; set; }

        public bool is_active { get; set; }
    }
}
