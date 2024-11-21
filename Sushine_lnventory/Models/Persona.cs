using System;

namespace Sushine_lnventory.Models
{
    public class Persona
    {
        public char Cedula { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public char Celular { get; set; }
        public char Sexo { get; set; }

        public Persona( char cedula, string primer_nombre, string segundo_nombre, 
            string primer_apellido, string segundo_apellido, char celular, char sexo)
        {
            this.Cedula = cedula;
            this.Primer_Nombre = primer_nombre;
            this.Segundo_Apellido = segundo_nombre;
            this.Primer_Apellido = primer_apellido;
            this.Segundo_Apellido = segundo_apellido;
            this.Celular = celular;
            this.Sexo = sexo;
        }
    }
}
