using Entities.ConCreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {

        List<products> GetProducts();

        List<products> GetProductByUserId(int user_id);

        List<product_photos> GetPhotosByPId(int product_id);

        List<product_facilities> GetFacilitiesByPId(int product_id);

    }
}
