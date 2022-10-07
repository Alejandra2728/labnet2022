using Lab.MVC.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MVC.Logic
{
    public class ProductsLogic: BaseLogic,IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Add(Products newProduct) 
        { 
            context.Products.Add(newProduct);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productoEliminar= context.Products.Find(id);
            context.Products.Remove(productoEliminar);
            context.SaveChanges();
        }

        public async Task<Products> Update(Products products, int id)
        {
            var productUpdate = await context.Products.FirstOrDefaultAsync(x=>x.ProductID==id);
            if (productUpdate == null)
            {
                return null;
            }
            productUpdate.ProductID = id;
            productUpdate.ProductName = products.ProductName;
            productUpdate.QuantityPerUnit= products.QuantityPerUnit;
            productUpdate.Discontinued = true;

            context.Entry(productUpdate).State= EntityState.Modified;
            await context.SaveChangesAsync();
            return productUpdate;
          
        }
    }

    
}
