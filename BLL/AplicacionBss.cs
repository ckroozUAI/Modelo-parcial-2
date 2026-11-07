using DAL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class AplicacionBss
    {
        private AplicacionDao dao = new AplicacionDao();
        private CategoriaDao categoriaDao = new CategoriaDao();

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
                using (var scope = new TransactionScope())
                {
                    foreach (var item in listado)
                    {

                    
                        if (item.Precio.ToString().Length == 0 || item.Precio < 0) throw new Exception("El precio debe ser mayor o igual a cero.");
                        if (item.Titulo == null || item.Titulo.ToString().Length <= 5) throw new Exception("El titulo debe tener al menos 5 caracteres.");
                        if (item.Descripcion == null || item.Descripcion.ToString().Length <= 15) throw new Exception("La descripcion debe tener al menos 15 caracteres.");
                        if (item.IdCategoria == null) throw new Exception("Debe tener una categoria seleccionada.");
                        if (categoriaDao.getById(item.IdCategoria) == null) throw new Exception("No existe el Id de categoria seleccionada .");

                        this.dao.save(item);
                    }  
                    scope.Complete();

                }
            }
            catch (Exception ex)
            {
                throw ex;   

            }
        }

        public AplicacionEntity getById(int id)
        {
            try
            {
                return this.dao.getById(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void update(AplicacionEntity item)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                   


                    if (item.Precio.ToString().Length == 0 || item.Precio < 0) throw new Exception("El precio debe ser mayor o igual a cero.");
                    if (item.Titulo == null || item.Titulo.ToString().Length <= 5) throw new Exception("El titulo debe tener al menos 5 caracteres.");
                    if (item.Descripcion == null || item.Descripcion.ToString().Length <= 15) throw new Exception("La descripcion debe tener al menos 15 caracteres.");
                    if (item.IdCategoria == null) throw new Exception("Debe tener una categoria seleccionada.");

                    var entidad = this.dao.getById(item.Id);

                    if(entidad==null) throw new Exception("No existen aplicaciones con el id indicado.");

                    entidad.Descripcion = item.Descripcion;
                    entidad.Desarrolladora = item.Desarrolladora;
                    entidad.Titulo = item.Titulo;
                    entidad.Precio = item.Precio;

                    this.dao.update(entidad);
                   
                    scope.Complete();

                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void delete(int id)
        {
            try
            {
                if (this.dao.getById(id) != null)
                {
                    this.dao.delete(id);
                }
                else
                {
                    throw new Exception("No existen aplicaciones con ese ID.");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
