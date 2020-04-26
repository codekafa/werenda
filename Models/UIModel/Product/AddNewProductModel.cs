using Entities.ConCreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.UIModel.Product
{
    public class AddNewProductModel
    {

        public products Product { get; set; }

        public List<product_photos> Photos { get; set; }

        public List<product_facilities> Facs { get; set; }
    }
}
