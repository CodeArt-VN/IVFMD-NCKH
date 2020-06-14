
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

        public static DTO_SYS_Config get_SYS_Config_ThoiGianBaoCaoTDNC(AppEntities db)
        {
            string sKey = SYSConfigCode.ThoiGianBaoCaoTDNC.ToString();
            var obj = db.tbl_SYS_Config.FirstOrDefault(c => c.Code == sKey && !c.IsDeleted);
            if (obj == null)
            {
                return new DTO_SYS_Config
                {
                    ThoiGianBaoCaoTDNC = new DTO_SYS_Config_ThoiGianBaoCaoTDNC()
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
                    ThoiGianBaoCaoTDNC = new DTO_SYS_Config_ThoiGianBaoCaoTDNC()
                };

                if (!string.IsNullOrEmpty(res.Value))
                    res.ThoiGianBaoCaoTDNC = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_SYS_Config_ThoiGianBaoCaoTDNC>(res.Value);

                return res;
            }
        }

        public static DTO_SYS_Config post_SYS_Config_ThoiGianBaoCaoTDNC(AppEntities db, DTO_SYS_Config item, string Username)
        {
            string sKey = SYSConfigCode.ThoiGianBaoCaoTDNC.ToString();
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

            dbitem.Value = Newtonsoft.Json.JsonConvert.SerializeObject(item.ThoiGianBaoCaoTDNC);

            if (dbitem != null)
            {
                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "post_SYS_Config_ThoiGianBaoCaoTDNC", dbitem.ModifiedDate, Username);

                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_SYS_Config_ThoiGianBaoCaoTDNC", e);
                    item = null;
                }
            }
            return item;
        }

        public static DTO_SYS_Config get_SYS_Config_Template(AppEntities db)
        {
            string sKey = SYSConfigCode.Template.ToString();
            var obj = db.tbl_SYS_Config.FirstOrDefault(c => c.Code == sKey && !c.IsDeleted);
            if (obj == null)
            {
                return new DTO_SYS_Config
                {
                    Template = new DTO_SYS_Config_Template()
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
                    Template = new DTO_SYS_Config_Template()
                };

                if (!string.IsNullOrEmpty(res.Value))
                    res.Template = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_SYS_Config_Template>(res.Value);

                return res;
            }
        }

        public static DTO_SYS_Config post_SYS_Config_Template(AppEntities db, DTO_SYS_Config item, string Username)
        {
            string sKey = SYSConfigCode.Template.ToString();
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

            dbitem.Value = Newtonsoft.Json.JsonConvert.SerializeObject(item.Template);

            if (dbitem != null)
            {
                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "post_SYS_Config_Template", dbitem.ModifiedDate, Username);

                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_SYS_Config_Template", e);
                    item = null;
                }
            }
            return item;
        }

        public static DTO_SYS_Config get_SYS_ConfigEmail_Template(AppEntities db, string keyCode)
        {
            var obj = db.tbl_SYS_Config.FirstOrDefault(c => c.Code == keyCode && !c.IsDeleted);
            if (obj == null)
            {
                return new DTO_SYS_Config
                {
                    Email = new DTO_SYS_ConfigEmail(),
                    Code = keyCode,
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
                    Email = new DTO_SYS_ConfigEmail()
                };

                if (!string.IsNullOrEmpty(res.Value))
                {
                    res.Email = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO_SYS_ConfigEmail>(res.Value);
                    res.Body = res.Email.Body;
                    res.Subject = res.Email.Subject;
                    res.EmailList = res.Email.EmailList;
                }

                return res;
            }
        }

        public static DTO_SYS_Config post_SYS_ConfigEmail_Template(AppEntities db, DTO_SYS_Config item, string Username)
        {
            var dbitem = db.tbl_SYS_Config.FirstOrDefault(c => c.Code == item.Code && !c.IsDeleted);
            if (dbitem == null)
            {
                dbitem = new tbl_SYS_Config();
                dbitem.CreatedBy = Username;
                dbitem.CreatedDate = DateTime.Now;
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;
                dbitem.Code = item.Code;
                db.tbl_SYS_Config.Add(dbitem);
            }
            else
            {
                dbitem.ModifiedBy = Username;
                dbitem.ModifiedDate = DateTime.Now;
            }

            item.Email.Subject = item.Subject;
            item.Email.Body = item.Body;
            item.Email.EmailList = item.EmailList;

            dbitem.Value = Newtonsoft.Json.JsonConvert.SerializeObject(item.Email);

            if (dbitem != null)
            {
                try
                {
                    db.SaveChanges();

                    BS_CUS_Version.update_CUS_Version(db, null, "post_SYS_ConfigEmail_Template", dbitem.ModifiedDate, Username);

                    item.ID = dbitem.ID;

                    item.CreatedBy = dbitem.CreatedBy;
                    item.CreatedDate = dbitem.CreatedDate;

                    item.ModifiedBy = dbitem.ModifiedBy;
                    item.ModifiedDate = dbitem.ModifiedDate;

                }
                catch (DbEntityValidationException e)
                {
                    errorLog.logMessage("post_SYS_ConfigEmail_Template", e);
                    item = null;
                }
            }
            return item;
        }
    }
}