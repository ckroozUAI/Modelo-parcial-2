using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using ENTITIES.Models;

namespace Mapper
{
    public class AplicacionMapper
    {
        public static AplicacionEntity toEntity(Aplicacion actividadDB)
        {
            var entity = new AplicacionEntity();

            entity.Id = actividadDB.Id;
            entity.Titulo = actividadDB.Titulo;
            entity.Desarrolladora=actividadDB.Desarrolladora;
            entity.Descripcion=actividadDB.Descripcion;
            entity.Precio=actividadDB.Precio;
            entity.IdCategoria=actividadDB.IdCategoria;

            return entity;
        }

        public static Aplicacion toModel(AplicacionEntity entity)
        {
            var model = new Aplicacion();

            model.Id = entity.Id;
            model.Titulo = entity.Titulo;
            model.Desarrolladora = entity.Desarrolladora;
            model.Descripcion = entity.Descripcion;
            model.Precio = entity.Precio;
            model.IdCategoria = entity.IdCategoria;

            return model;
        }
    }
}
