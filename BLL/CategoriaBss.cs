using DAL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBss
    {
        private CategoriaDao dao= new CategoriaDao();

        public List<CategoriaEntity> getAll()
        {
            try
            {
                return this.dao.getAll();

            }catch (Exception ex) {
                throw ex;   
            }
        }

        public CategoriaEntity getById(int id)
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
    }
}
