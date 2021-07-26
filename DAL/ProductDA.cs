using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Entities;

namespace DAL {
    public class ProductDA {

        private const string FileName = "products.xml";

        public List<Product> GetAll() {
            if (File.Exists(FileName)) {

                var serializer = new XmlSerializer(typeof(List<Product>));
                using (var stream = File.OpenRead(FileName)) {
                    return (List<Product>)serializer.Deserialize(stream);
                }

            } else {
                return new List<Product>();
            }
        }

        public void Create(Product product) {
            var existingValues = GetAll();
            existingValues.Add(product);

            var serializer = new XmlSerializer(typeof(List<Product>));
            using (var stream = File.OpenWrite(FileName)) {
                serializer.Serialize(stream, existingValues);
            }
        }


    }
}
