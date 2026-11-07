using DAL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AplicacionBss
    {
        private AplicacionDao dao = new AplicacionDao();

        public List<AplicacionEntity> getAll()
        {
            try
            {
                return this.dao.getAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void save(List<AplicacionEntity> listado)
        {
            try
            {
                /* Reglas de negocio:
                 •	El precio no puede ser menor que cero
                 •	El titulo debe tener al menos 5 caracteres
                 •	La descripción debe tener al menos 15 caracteres
                 •	Toda aplicación debe tener una categoría asignada
                 •	Validar previo a la carga si la categoría de la aplicación existe en la base de datos
                */
                foreach (var item in listado)
                {
                    if (item.Precio == null || item.Precio.ToString().Length == 0 || item.Precio < 0) throw new Exception("El precio debe ser mayor o igual a cero.");
                    if (item.Titulo == null || item.Titulo.ToString().Length >= 5) throw new Exception("El titulo debe tener al menos 5 caracteres.");
                    if (item.Descripcion == null || item.Descripcion.ToString().Length >= 15) throw new Exception("La descripcion debe tener al menos 15 caracteres.");
                    if(item.IdCategoriaNavigation==null) throw new Exception("Debe tener categoria.");


                }

            }
            catch (Exception ex)
            {
                throw ex;   

            }
    }
}
