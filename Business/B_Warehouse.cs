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
        public List<WarehouseEntity> WarehousesList()
        {
            using (var db = new InventoryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateWarehouse(WarehouseEntity newWarehouse)
        {
            using (var db = new InventoryContext())
            {
                db.Warehouses.Add(newWarehouse);
                db.SaveChanges();
            }
        }

        public void UpdateWarehouse(WarehouseEntity warehouse)
        {
            using (var db = new InventoryContext())
            {
                db.Update(warehouse);
                db.SaveChanges();
            }
        }
    }
}
