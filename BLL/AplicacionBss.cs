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
    }
}
