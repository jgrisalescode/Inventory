using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAcces;
using System.Linq;

namespace Business
{
    public class B_Storage
    {
        public List<StorageEntity> StoragesList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void CreateStorage(StorageEntity newStorage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Add(newStorage);
                db.SaveChanges();
            }
        }

        public void UpdateStorage(StorageEntity storage)
        {
            using (var db = new InventoryContext())
            {
                db.Update(storage);
                db.SaveChanges();
            }
        }
    }
}
