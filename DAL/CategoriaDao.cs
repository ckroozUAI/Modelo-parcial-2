using DAL.Models;
using ENTITIES;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaDao
    {
        public List<CategoriaEntity> getAll()
        {
            List<CategoriaEntity> listEntity = new List<CategoriaEntity>();
            try
            {
                using (var dbContext = new ModeloParcialContext())
                {
                    var lista = dbContext.Categoria.ToList();
                    if (lista.Count > 0)
                    {
                        foreach (var item in lista)
                        {
                            var e = CategoriaMapper.toEntity(item);
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

        public CategoriaEntity getById(int id)
        {
            CategoriaEntity entity=null;
            try
            {
                using (var dbContext = new ModeloParcialContext())
                {
                    var entidad = dbContext.Categoria.FirstOrDefaultAsync(e => e.Id == id);
                    if (entidad.Result != null)
                    {
                        entity = CategoriaMapper.toEntity(entidad.Result);

                    }
                    return entity;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
