using System;
using System.Collections.Generic;

namespace ENTITIES.Models;

public partial class Aplicacion
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Desarrolladora { get; set; }

    public decimal Precio { get; set; }

    public int IdCategoria { get; set; }

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
}
