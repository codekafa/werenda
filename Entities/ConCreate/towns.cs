using Core.Entities;

namespace Entities.ConCreate
{
    public class towns : IEntity
    {
        public int id { get; set; }

        public int city_id { get; set; }

        public int district_id { get; set; }

        public string town { get; set; }

        public string name { get; set; }
    }
}
