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
        [Required(ErrorMessage ="El campo nombre no puede estar vacio!...")]
        public string Nombre { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 9999999999999, ErrorMessage ="Debe ingresar un monto valido")]
        public float Capital { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 999999, ErrorMessage = "Debe ingresar un monto valido")]
        public int Semanas { get; set; }
        public float TotalAPagar { get; set; }
        [Required]
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
