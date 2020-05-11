﻿using Core.DataAccess.EFCoreRepositoryBase;
using DataAccess.Abstract;
using DataAccess.ConCreate.EFCore.Contexts;
using Entities.ConCreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.ConCreate.EFCore
{
    public class EFHaveRoomDal : EFEntityRepositoryBase<have_rooms, WerendaContext>, IHaveRoomDal
    {
    }
}
