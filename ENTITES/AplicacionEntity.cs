using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class AplicacionEntity
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = null!;

        public string? Descripcion { get; set; }

        public string? Desarrolladora { get; set; }

        public decimal Precio { get; set; }


        public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
    }
}
