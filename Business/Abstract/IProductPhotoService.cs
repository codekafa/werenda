using Entities.ConCreate;
using Models.File;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductPhotoService 
    {

        product_photos AddFile(product_photos photo);

        List<product_photos> GetPhotosByPId(int p_id);

        product_photos GetPhotoById(int p_id);

        void RemovePhoto(int p_id);
    }
}
