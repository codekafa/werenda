using Business.Abstract;
using DataAccess.Abstract;
using Entities.ConCreate;
using Models.UIModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.ConCreate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        IProductPhotoDal _productPhotoDal;
        IProductFacilitiesDal _productFacDal;
        public ProductManager(IProductDal productDal,
        IProductPhotoDal productPhotoDal,
        IProductFacilitiesDal productFacDal)
        {
            _productDal = productDal;
            _productPhotoDal = productPhotoDal;
            _productFacDal = productFacDal;
        }
        public List<product_facilities> GetFacilitiesByPId(int product_id)
        {
            List<product_facilities> list = _productFacDal.GetList(x => x.product_id == product_id).ToList();
            return list;
        }

        public List<product_photos> GetPhotosByPId(int product_id)
        {
            List<product_photos> list = _productPhotoDal.GetList(x => x.product_id == product_id).ToList();
            return list;
        }

        public List<products> GetProductByUserId(int user_id)
        {
            List<products> list = _productDal.GetList(x => x.user_id == user_id).ToList();
            return list;
        }

        public List<products> GetProducts()
        {
            List<products> list = _productDal.GetList().ToList();
            return list;
        }

        public void UpdateProduct(products product)
        {
            _productDal.Update(product);
        }

        //public products AddProduct(AddNewProductModel addProductModel)
        //{

        //   var addedProduct =  _productDal.Add(addProductModel.Product);



        //}

    }
}
