﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ConCreate
{
    public class rooms : IEntity
    {
        public int id { get; set; }

        public string room_count { get; set; }
    }
}
