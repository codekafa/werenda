using Business.Abstract;
using DataAccess.Abstract;
using Entities.ConCreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ConCreate
{
    public class ProductPhotoManager : IProductPhotoService
    {
        IProductPhotoDal _productPhotoDal;
        public ProductPhotoManager(IProductPhotoDal productPhotoDal)
        {
            _productPhotoDal = productPhotoDal;
        }
        public product_photos AddFile(product_photos photo)
        {
            return photo;
        }

        public product_photos GetPhotoById(int p_id)
        {
            throw new NotImplementedException();
        }

        public List<product_photos> GetPhotosByPId(int p_id)
        {
            throw new NotImplementedException();
        }

        public void RemovePhoto(int p_id)
        {
            throw new NotImplementedException();
        }
    }
}
