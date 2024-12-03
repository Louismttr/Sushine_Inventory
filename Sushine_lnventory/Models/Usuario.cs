using System;

namespace Sushine_lnventory.Models
{
    public class Usuario
    {
        public int IdUsuario { get; }
        public string NameUser { get; }
        public string CorreoElectronico { get; set; }
        public string Pass { get; set; }
        public string RolUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Empleado codempleado = null;//Metodos de propiedad a parte, referenciado en el ...


        ///Revisar.... VALIDACIONES
        public void setcodeEmpleado(Empleado codempleado)
        {
           this.codempleado = codempleado;
        }
    }
}
