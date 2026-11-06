using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class CategoriaEntity
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = null!;

        public decimal PorcentajeDescuento { get; set; }

        public virtual ICollection<Aplicacion> Aplicacion { get; set; } = new List<Aplicacion>();
    }
}
