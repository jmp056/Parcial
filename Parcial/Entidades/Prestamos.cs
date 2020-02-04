using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestfloamoId { get; set; }
        public string Nombre { get; set; }
        public float Capital { get; set; }
        public int Semanas { get; set; }
        public float TotalAPagar { get; set; }
        public DateTime FechaPrestamo { get; set; }

        public Prestamos()
        {
            PrestfloamoId = 0;
            Nombre = string.Empty;
            Capital = 0;
            Semanas = 0;
            TotalAPagar = 0;
            FechaPrestamo = DateTime.Now;
        }
    }
}
