using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Posmanagement
{
    class dbClass
    {
        public static string Getconnection()
        {
            string retValue = null;
            ConnectionStringSettings sett = ConfigurationManager.ConnectionStrings["Posmanagement.Properties.Settings.dbConnection"];

            if (sett != null)
                retValue = sett.ConnectionString;

            return retValue;
        }
    }
}
