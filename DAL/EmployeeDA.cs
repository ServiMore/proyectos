using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Entities;

namespace DAL {
    public class EmployeeDA {

        private const string FileName = "employees.xml";

        public List<Employee> GetAll() {
            if (File.Exists(FileName)) {

                var serializer = new XmlSerializer(typeof(List<Employee>));
                using (var stream = File.OpenRead(FileName)) {
                    return (List<Employee>)serializer.Deserialize(stream);
                }

            } else {
                return new List<Employee>();
            }
        }

        public Employee GetOne(string code) {
            return GetAll().Find(x => x.Codigo == code);
        }

        public List<Employee> GetChildren(Employee boss) { 
            return GetAll().FindAll(x => x.Jefe?.Codigo == boss.Codigo);
        }

        public void Create(Employee employee) {
            var existingValues = GetAll();
            existingValues.Add(employee);

            var serializer = new XmlSerializer(typeof(List<Employee>));
            using (var stream = File.OpenWrite(FileName)) {
                serializer.Serialize(stream, existingValues);
            }
        }

    }
}
