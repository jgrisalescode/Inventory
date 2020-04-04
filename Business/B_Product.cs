using System;
using System.Collections.Generic;
using System.Text;
using DataAcces;
using System.Linq;
using Entities;

namespace Business
{
    public class B_Product
    {
        public List<ProductEntity> ProductsList()
        {
            using (var db = new InventoryContext())
            {
                return db.Products.ToList();
            }
        }

        public void CreateProduct(ProductEntity newProduct)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Add(newProduct);
                db.SaveChanges();
            }
        }

        public void UpdateProduct(ProductEntity product)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Update(product);
                db.SaveChanges();
            }
        }
    }
}
