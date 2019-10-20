using ClassLibrary;
using DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public static partial class BS_SYS_Var
    {
        public static IQueryable<DTO_SYS_Var> get_SYS_VarByType(AppEntities db, int typeOfVar)
        {
            var query = db.tbl_SYS_Var.AsQueryable();

            query = query.Where(d => d.TypeOfVar == typeOfVar);

            return toDTO(query);
        }
    }
}
