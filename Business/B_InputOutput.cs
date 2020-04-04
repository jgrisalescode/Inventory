using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities;
using DataAcces;

namespace Business
{
    public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputsList()
        {
            using (var db = new InventoryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity newInOut)
        {
            using (var db = new InventoryContext())
            {
                db.InOuts.Add(newInOut);
                db.SaveChanges();
            }
        }

        public void UpdateInputOutput(InputOutputEntity inOut)
        {
            using (var db = new InventoryContext())
            {
                db.InOuts.Update(inOut);
                db.SaveChanges();
            }
        }
    }
}
