using System;
using Entities;
using System.Collections.Generic;
using DAL;

namespace BLL {
    public class ProductBL {

        private ProductDA da = new ProductDA();

        public List<Product> GetAll() {
            return da.GetAll();
        }

        public void Create(Product Product) {
            if (Product.Precio <= 0) {
                throw new Exception("El Precio no puede ser negativo.");
            }
            if (string.IsNullOrWhiteSpace(Product.Codigo)) {
                throw new Exception("El codigo no puede estar vacio.");
            }

            da.Create(Product);
        }

    }
}
