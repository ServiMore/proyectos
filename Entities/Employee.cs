using System.Collections.Generic;

namespace Entities {
    public class Employee {

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Salario { get; set; }
        public Employee Jefe { get; set; }

        public override string ToString()
        {
            return Nombre;

        }

    }
}

