using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyGeneration.dOOdads;

namespace HRModuleEntity
{
    public  class ConnectionConfig : SqlClientEntity
    {
        public void BaseEntityClass()
        {
            string password = System.Web.Configuration.WebConfigurationManager.AppSettings["pass"].ToString();

            this.ConnectionString = System.Web.Configuration.WebConfigurationManager.AppSettings["connectionString"].ToString() + password;
        }
    }
}