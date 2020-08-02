using Core.DataAccess.EFCoreRepositoryBase;
using DataAccess.Abstract;
using DataAccess.ConCreate.EFCore.Contexts;
using Entities.ConCreate;

namespace DataAccess.ConCreate.EFCore
{
    public class EFPageDal : EFEntityRepositoryBase<pages, WerendaContext>, IPageDal
    {
    }
}
