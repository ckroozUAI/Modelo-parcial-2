
using DAL.Models;
using ENTITIES;
using ENTITIES.Models;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AplicacionDao
    {
        public List<AplicacionEntity> getAll()
        {
            List<AplicacionEntity> listEntity = new List<AplicacionEntity>();
            try
            {
                using (var dbContext = new ModeloParcialContext())
                {
                    var lista = dbContext.Aplicacion.ToList();
                    if (lista.Count > 0)
                    {
                        foreach (var item in lista)
                        {
                            var e = AplicacionMapper.toEntity(item);
                            listEntity.Add(e);
                        }
                    }
                    return listEntity;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }

        public AplicacionEntity getById(int id)
        {
            AplicacionEntity entity = null;
            try
            {
                using (var dbContext = new ModeloParcialContext())
                {
                    var entidad = dbContext.Aplicacion.FirstOrDefaultAsync(e=>e.Id==id);
                    if (entidad.Result !=null)
                    {
                        entity = AplicacionMapper.toEntity(entidad.Result);      
                        
                    }
                    return entity;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }



        public void save(AplicacionEntity entity)
        {
            try
            {
                var model = AplicacionMapper.toModel(entity);
                using (var dbContext = new ModeloParcialContext())
                { 
                    dbContext.Aplicacion.Add(model);
                    dbContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void update(AplicacionEntity entity)
        {
            try
            {
                var model = AplicacionMapper.toModel(entity);
                using (var dbContext = new ModeloParcialContext())
                {
                    dbContext.Update(model);
                    dbContext.SaveChanges();
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
                using (var dbContext = new ModeloParcialContext())
                {
                    var e= dbContext.Aplicacion.FirstOrDefault(x => x.Id == id);
                    dbContext.Remove(e!);
                    dbContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

    }
}
