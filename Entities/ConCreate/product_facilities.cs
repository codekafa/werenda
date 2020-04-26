using Core.Entities;

namespace Entities.ConCreate
{
    public class product_facilities : IEntity
    {
        public int id { get; set; }

        public int product_id { get; set; }

        public int facility_id { get; set; }
    }
}
