
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

    public static partial class BS_SYS_Config
    {
        public static DTO_SYS_Config get_SYS_Config_ThoiGianBaoCaoNSKH(AppEntities db)
        {
            string sKey = SYSConfigCode.ThoiGianBaoCaoNSKH.ToString();
            var obj = db.tbl_SYS_Config.FirstOrDefault(c => c.Code == sKey && !c.IsDeleted);
            if (obj == null)
            {
                return new DTO_SYS_Config
                {
                    ThoiGianBaoCaoNSKH = new DTO_SYS_Config_ThoiGianBaoCaoNSKH()
                };
            }
            else
            {
                DTO_SYS_Config res = new DTO_SYS_Config
                {
                    ID = obj.ID,
                    Code = obj.Code,
                    Name = obj.Name,
                    Remark = obj.Remark,
                    Sort = obj.Sort,
                    IsDisabled = obj.IsDisabled,
                    IsDeleted = obj.IsDeleted,
                    CreatedBy = obj.CreatedBy,
                    ModifiedBy = obj.ModifiedBy,
                    CreatedDate = obj.CreatedDate,
                    ModifiedDate = obj.ModifiedDate,
                    Value = obj.Value,
                    ThoiGianBaoCaoNSKH = new DTO_SYS_Config_ThoiGianBaoCaoNSKH()
                };

                if (!string.IsNullOrEmpty(res.Value))
                    res.ThoiGianBaoCaoNSKH = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_SYS_Config_ThoiGianBaoCaoNSKH>(res.Value);

                return res;
            }
        }

        public static DTO_SYS_Config post_SYS_Config_ThoiGianBaoCaoNSKH(AppEntities db, DTO_SYS_Config item, string Username)
        {
            string sKey = SYSConfigCode.ThoiGianBaoCaoNSKH.ToString();
            var dbitem = db.tbl_SYS_Config.FirstOrDefault(c => c.Code == sKey && !c.IsDeleted);
            if (dbitem == null)
            {
                dbitem = new tbl_SYS_Config();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;
                dbitem.Code = sKey;
                db.tbl_SYS_Config.Add(dbitem);
            }
            else
            {
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;
            }

            dbitem.Value = Newtonsoft.Json.JsonConvert.SerializeObject(item.ThoiGianBaoCaoNSKH);

            if (dbitem != null)
            {
                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "post_SYS_Config_ThoiGianBaoCaoNSKH", dbitem.ModifiedDate, Username);

                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_SYS_Config_ThoiGianBaoCaoNSKH", e);
                    item = null;
                }
            }
            return item;
        }

    }
}