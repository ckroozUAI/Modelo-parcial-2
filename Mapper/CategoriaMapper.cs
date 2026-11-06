using ENTITIES.Models;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class CategoriaMapper
    {
        public static CategoriaEntity toEntity(Categoria categoriaDB)
        {
            var entity = new CategoriaEntity();
            
            entity.Id = categoriaDB.Id;
            entity.Descripcion = categoriaDB.Descripcion;
            entity.PorcentajeDescuento = categoriaDB.PorcentajeDescuento; 

            return entity;
        }
    }
}
