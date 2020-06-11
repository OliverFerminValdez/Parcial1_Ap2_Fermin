using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Fermin.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        [Required(ErrorMessage ="Es obligatorio introducir la descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Es obligatorio introducir la existencia")]
        public double Existencia { get; set; }
        [Required(ErrorMessage ="Es obligatorio Introducir el costo")]
        public double Costo { get; set; }
        public double ValorInventario { get; set; }

    }
}
