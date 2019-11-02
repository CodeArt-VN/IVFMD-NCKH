using ClassLibrary;
using DTOModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public static partial class BS_PRO_Sysnopsis
    {
        public static DTO_PRO_Sysnopsis get_PRO_SysnopsisByDeTai(AppEntities db, int deTaiId)
        {
            var query = db.tbl_PRO_Sysnopsis.Where(d => d.IDDeTai == deTaiId && d.IsDeleted == false).Select(s => new DTO_PRO_Sysnopsis
            {
                ID = s.ID,
                IDDeTai = s.IDDeTai,
                StudyTitle = s.StudyTitle,
                Investigators = s.Investigators,
                BackgroundAims = s.BackgroundAims,
                Objectives = s.Objectives,
                StudyDesign = s.StudyDesign,
                StudyPopulation = s.StudyPopulation,
                Endpoint = s.Endpoint,
                PrimaryEndpoint = s.PrimaryEndpoint,
                SecondaryEndpoint = s.SecondaryEndpoint,
                MainEligibilityCriteria = s.MainEligibilityCriteria,
                InclusionCriteria = s.InclusionCriteria,
                ExclusionCriteria = s.ExclusionCriteria,
                DataAnalysis = s.DataAnalysis,
                References = s.References,
                HTML = s.HTML,
                IsDisabled = s.IsDisabled,
                IsDeleted = s.IsDeleted,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy,
                ModifiedDate = s.ModifiedDate,
                ModifiedBy = s.ModifiedBy,
            }).FirstOrDefault();

            return query;
        }
    }
}
