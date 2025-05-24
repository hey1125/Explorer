using DataPersistestence;
using Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ProductManager
    {
        public void AddProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.name))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            }
            if (product.price <= 0)
            {
                throw new ArgumentException("El precio del producto debe ser mayor que cero.");
            }
            if (product.stock <= 0)
            {
                throw new ArgumentException("El stock del producto no puede ser negativo.");

            }
            var fm = new FileManager();
            fm.SaveProduct(product);
        }
        public List<Product> GetProducts()
        {
            var list = new List<Product>();
            return list;
        }
   
}
}

