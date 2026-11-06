using System;
using System.Collections.Generic;

namespace ENTITIES.Models;

public partial class Categoria
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal PorcentajeDescuento { get; set; }

    public virtual ICollection<Aplicacion> Aplicacion { get; set; } = new List<Aplicacion>();
}
