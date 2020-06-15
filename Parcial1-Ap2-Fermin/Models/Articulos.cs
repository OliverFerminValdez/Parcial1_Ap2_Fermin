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
        [Range(minimum:1, maximum:100000000,ErrorMessage ="El rango es de 1 a 100000000")]
        public double Existencia { get; set; }
        [Range(minimum: 1, maximum: 100000000, ErrorMessage = "El rango es de 1 a 100000000")]
        public double Costo { get; set; }
        public double ValorInventario { get; set; }

    }
}
