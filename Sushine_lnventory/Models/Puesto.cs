using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushine_lnventory.Models
{
    public class Puesto
    {
        public int Id { get; set; }
        public string Nombre_Pt { get; set; }
        public string Descripcion_Pt { get; set; }

        public Puesto()
        {
        }

        public Puesto(int id, string nombre_Pt, string descripcion_Pt)
        {
            Id = id;
            Nombre_Pt = nombre_Pt;
            Descripcion_Pt = descripcion_Pt;
        }

    }
}
