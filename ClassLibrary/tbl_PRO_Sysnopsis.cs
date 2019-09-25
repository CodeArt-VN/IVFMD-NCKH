//------------------------------------------------------------------------------
// 
//    www.codeart.vn
//    hungvq@live.com
//    (+84)908.061.119
// 
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    
    using System;
    using System.Collections.Generic;
    
    
    public partial class tbl_PRO_Sysnopsis
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string StudyTitle { get; set; }
        public string Investigators { get; set; }
        public string BackgroundAims { get; set; }
        public string Objectives { get; set; }
        public string StudyDesign { get; set; }
        public string StudyPopulation { get; set; }
        public string Endpoint { get; set; }
        public string PrimaryEndpoint { get; set; }
        public string SecondaryEndpoint { get; set; }
        public string MainEligibilityCriteria { get; set; }
        public string InclusionCriteria { get; set; }
        public string ExclusionCriteria { get; set; }
        public string DataAnalysis { get; set; }
        public string References { get; set; }
        public string HTML { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_Sysnopsis
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string StudyTitle { get; set; }
		public string Investigators { get; set; }
		public string BackgroundAims { get; set; }
		public string Objectives { get; set; }
		public string StudyDesign { get; set; }
		public string StudyPopulation { get; set; }
		public string Endpoint { get; set; }
		public string PrimaryEndpoint { get; set; }
		public string SecondaryEndpoint { get; set; }
		public string MainEligibilityCriteria { get; set; }
		public string InclusionCriteria { get; set; }
		public string ExclusionCriteria { get; set; }
		public string DataAnalysis { get; set; }
		public string References { get; set; }
		public string HTML { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
	}
}


namespace BaseBusiness
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using DTOModel;
    using ClassLibrary;
	using System.Data.Entity.Validation;

    public static partial class BS_PRO_Sysnopsis 
    {
		public static IQueryable<DTO_PRO_Sysnopsis> toDTO(IQueryable<tbl_PRO_Sysnopsis> query)
        {
			return query
			.Select(s => new DTO_PRO_Sysnopsis(){							
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
			});
                              
        }

		public static DTO_PRO_Sysnopsis toDTO(tbl_PRO_Sysnopsis dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_Sysnopsis()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					StudyTitle = dbResult.StudyTitle,							
					Investigators = dbResult.Investigators,							
					BackgroundAims = dbResult.BackgroundAims,							
					Objectives = dbResult.Objectives,							
					StudyDesign = dbResult.StudyDesign,							
					StudyPopulation = dbResult.StudyPopulation,							
					Endpoint = dbResult.Endpoint,							
					PrimaryEndpoint = dbResult.PrimaryEndpoint,							
					SecondaryEndpoint = dbResult.SecondaryEndpoint,							
					MainEligibilityCriteria = dbResult.MainEligibilityCriteria,							
					InclusionCriteria = dbResult.InclusionCriteria,							
					ExclusionCriteria = dbResult.ExclusionCriteria,							
					DataAnalysis = dbResult.DataAnalysis,							
					References = dbResult.References,							
					HTML = dbResult.HTML,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_Sysnopsis> get_PRO_Sysnopsis(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_Sysnopsis.Where(d => d.IsDeleted == false );

			//Query keyword



			//Query ID (int)
			if (QueryStrings.Any(d => d.Key == "ID"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "ID").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.ID));
            }

			//Query IDDeTai (int)
			if (QueryStrings.Any(d => d.Key == "IDDeTai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDeTai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDeTai));
            }

			//Query StudyTitle (string)
			if (QueryStrings.Any(d => d.Key == "StudyTitle") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "StudyTitle").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "StudyTitle").Value;
                query = query.Where(d=>d.StudyTitle == keyword);
            }

			//Query Investigators (string)
			if (QueryStrings.Any(d => d.Key == "Investigators") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Investigators").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Investigators").Value;
                query = query.Where(d=>d.Investigators == keyword);
            }

			//Query BackgroundAims (string)
			if (QueryStrings.Any(d => d.Key == "BackgroundAims") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "BackgroundAims").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "BackgroundAims").Value;
                query = query.Where(d=>d.BackgroundAims == keyword);
            }

			//Query Objectives (string)
			if (QueryStrings.Any(d => d.Key == "Objectives") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Objectives").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Objectives").Value;
                query = query.Where(d=>d.Objectives == keyword);
            }

			//Query StudyDesign (string)
			if (QueryStrings.Any(d => d.Key == "StudyDesign") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "StudyDesign").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "StudyDesign").Value;
                query = query.Where(d=>d.StudyDesign == keyword);
            }

			//Query StudyPopulation (string)
			if (QueryStrings.Any(d => d.Key == "StudyPopulation") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "StudyPopulation").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "StudyPopulation").Value;
                query = query.Where(d=>d.StudyPopulation == keyword);
            }

			//Query Endpoint (string)
			if (QueryStrings.Any(d => d.Key == "Endpoint") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "Endpoint").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "Endpoint").Value;
                query = query.Where(d=>d.Endpoint == keyword);
            }

			//Query PrimaryEndpoint (string)
			if (QueryStrings.Any(d => d.Key == "PrimaryEndpoint") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PrimaryEndpoint").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PrimaryEndpoint").Value;
                query = query.Where(d=>d.PrimaryEndpoint == keyword);
            }

			//Query SecondaryEndpoint (string)
			if (QueryStrings.Any(d => d.Key == "SecondaryEndpoint") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "SecondaryEndpoint").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "SecondaryEndpoint").Value;
                query = query.Where(d=>d.SecondaryEndpoint == keyword);
            }

			//Query MainEligibilityCriteria (string)
			if (QueryStrings.Any(d => d.Key == "MainEligibilityCriteria") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MainEligibilityCriteria").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MainEligibilityCriteria").Value;
                query = query.Where(d=>d.MainEligibilityCriteria == keyword);
            }

			//Query InclusionCriteria (string)
			if (QueryStrings.Any(d => d.Key == "InclusionCriteria") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "InclusionCriteria").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "InclusionCriteria").Value;
                query = query.Where(d=>d.InclusionCriteria == keyword);
            }

			//Query ExclusionCriteria (string)
			if (QueryStrings.Any(d => d.Key == "ExclusionCriteria") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ExclusionCriteria").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ExclusionCriteria").Value;
                query = query.Where(d=>d.ExclusionCriteria == keyword);
            }

			//Query DataAnalysis (string)
			if (QueryStrings.Any(d => d.Key == "DataAnalysis") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DataAnalysis").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DataAnalysis").Value;
                query = query.Where(d=>d.DataAnalysis == keyword);
            }

			//Query References (string)
			if (QueryStrings.Any(d => d.Key == "References") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "References").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "References").Value;
                query = query.Where(d=>d.References == keyword);
            }

			//Query HTML (string)
			if (QueryStrings.Any(d => d.Key == "HTML") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value;
                query = query.Where(d=>d.HTML == keyword);
            }

			//Query IsDisabled (bool)
			if (QueryStrings.Any(d => d.Key == "IsDisabled"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDisabled").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDisabled);
            }

			//Query IsDeleted (bool)
			if (QueryStrings.Any(d => d.Key == "IsDeleted"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDeleted").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDeleted);
            }

			//Query CreatedDate (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

			//Query CreatedBy (string)
			if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d=>d.CreatedBy == keyword);
            }

			//Query ModifiedDate (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

			//Query ModifiedBy (string)
			if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d=>d.ModifiedBy == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PRO_Sysnopsis get_PRO_Sysnopsis(AppEntities db, int PartnerID, int id)
        {
            var dbResult = db.tbl_PRO_Sysnopsis.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_Sysnopsis(AppEntities db, int PartnerID, int ID, DTO_PRO_Sysnopsis item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_Sysnopsis.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.StudyTitle = item.StudyTitle;							
				dbitem.Investigators = item.Investigators;							
				dbitem.BackgroundAims = item.BackgroundAims;							
				dbitem.Objectives = item.Objectives;							
				dbitem.StudyDesign = item.StudyDesign;							
				dbitem.StudyPopulation = item.StudyPopulation;							
				dbitem.Endpoint = item.Endpoint;							
				dbitem.PrimaryEndpoint = item.PrimaryEndpoint;							
				dbitem.SecondaryEndpoint = item.SecondaryEndpoint;							
				dbitem.MainEligibilityCriteria = item.MainEligibilityCriteria;							
				dbitem.InclusionCriteria = item.InclusionCriteria;							
				dbitem.ExclusionCriteria = item.ExclusionCriteria;							
				dbitem.DataAnalysis = item.DataAnalysis;							
				dbitem.References = item.References;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_Sysnopsis", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_Sysnopsis",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_Sysnopsis post_PRO_Sysnopsis(AppEntities db, int PartnerID, DTO_PRO_Sysnopsis item, string Username)
        {
            tbl_PRO_Sysnopsis dbitem = new tbl_PRO_Sysnopsis();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.StudyTitle = item.StudyTitle;							
				dbitem.Investigators = item.Investigators;							
				dbitem.BackgroundAims = item.BackgroundAims;							
				dbitem.Objectives = item.Objectives;							
				dbitem.StudyDesign = item.StudyDesign;							
				dbitem.StudyPopulation = item.StudyPopulation;							
				dbitem.Endpoint = item.Endpoint;							
				dbitem.PrimaryEndpoint = item.PrimaryEndpoint;							
				dbitem.SecondaryEndpoint = item.SecondaryEndpoint;							
				dbitem.MainEligibilityCriteria = item.MainEligibilityCriteria;							
				dbitem.InclusionCriteria = item.InclusionCriteria;							
				dbitem.ExclusionCriteria = item.ExclusionCriteria;							
				dbitem.DataAnalysis = item.DataAnalysis;							
				dbitem.References = item.References;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_Sysnopsis.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_Sysnopsis", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_Sysnopsis",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_Sysnopsis(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_Sysnopsis.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_Sysnopsis", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_Sysnopsis",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_Sysnopsis_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_Sysnopsis.Any(e => e.ID == id);
		}
		
    }

}






