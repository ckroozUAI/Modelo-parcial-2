using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConeccionString
    {
        public static string getConectionString()
        {
            return ConfigurationManager.ConnectionStrings["coneccion"].ConnectionString;
        }
    }
}
