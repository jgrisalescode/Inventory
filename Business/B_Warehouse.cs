using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAcces;
using System.Linq;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WarehouseEntity> WarehousesList()
        {
            using (var db = new InventoryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public static void CreateWarehouse(WarehouseEntity newWarehouse)
        {
            using (var db = new InventoryContext())
            {
                db.Warehouses.Add(newWarehouse);
                db.SaveChanges();
            }
        }

        public static WarehouseEntity GetWarehouseById(string id)
        {
            using (var db = new InventoryContext())
            {
                return db.Warehouses.ToList().LastOrDefault(w => w.WarehouseId == id);
            }
        }

        public static void UpdateWarehouse(WarehouseEntity warehouse)
        {
            using (var db = new InventoryContext())
            {
                db.Update(warehouse);
                db.SaveChanges();
            }
        }
    }
}
