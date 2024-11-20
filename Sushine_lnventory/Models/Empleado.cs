using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushine_lnventory.Models
{
    public class Empleado : Persona
    {
        
        public int Id { get; set; }
        public int EstadoEmpleado { get; set; }
        public DateTime FechaCont { get; set; }
        public Puesto Puesto { get; set; } // Composición

        public Empleado(char cedula, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, char celular, char sexo,
        int id, int estadoEmpleado, DateTime fechacont) :
            base(cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, celular, sexo)
        {
           this.Id = id;
           this.EstadoEmpleado = estadoEmpleado;
           this.FechaCont = fechacont;
        }


    }
}
