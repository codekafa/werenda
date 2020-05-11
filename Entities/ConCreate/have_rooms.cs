using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class have_rooms : IEntity
    {

        public int id { get; set; }

        public string home_room_count { get; set; }
    }
}
