using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAcces;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            // using para el ciclo de vida de esta operación así no dejamos conexiones abiertas
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList();
            }
        }

        public void CreateCategory(CategoryEntity newCategory)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Add(newCategory);
                db.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity category)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Update(category);
                db.SaveChanges();
            }
        }
    }
}
