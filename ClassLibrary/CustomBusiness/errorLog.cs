using log4net;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class errorLog
    {
        private static ILog log = log4net.LogManager.GetLogger("API Logs");

        public static void logMessage(string FunctionName, DbEntityValidationException e)
        {
            log.Error(FunctionName, e);
            foreach (var eve in e.EntityValidationErrors)
            {
                
                log.Error(string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", eve.Entry.Entity.GetType().Name, eve.Entry.State));
                foreach (var ve in eve.ValidationErrors)
                {
                    log.Debug(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                }
                
            }
        }
        
    }
}
