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

    public static partial class BS_SYS_Form
    {
        public static List<DTO_APP_FormGroup> get_SYS_Form(AppEntities db, int PartnerID, DTO_AppRole roles)
        {
            var query = db.tbl_SYS_Form.Where(d => d.IsDeleted == false);
            if (roles.SYSRoles.Contains("GUEST"))
            {
                query = query.Where(d => d.Type == 0);
            }
            else
            {
                query = query.Where(d => d.Type == 1);
            }

            //
            //if (!roles.SYSRoles.Contains("HOST") && !roles.SYSRoles.Contains("GUEST"))
            //{
            //    query = query.Where(d => d.tbl_CUS_SYS_PermissionList.Any(c => roles.CUSRoles.Contains(c.IDRole) && c.Visible == true));
            //}
            query = query.Where(d => d.tbl_CUS_SYS_PermissionList.Any(c => roles.CUSRoles.Contains(c.IDRole) && c.Visible == true));
            if (query.Count() == 0)
                query = db.tbl_SYS_Form.Where(d => d.IsDeleted == false && d.ID == 17);

            var tempData = query.Select(s => new
            {
                s.ID,
                s.Code,
                s.Name,
                s.Remark,
                s.Sort,
                s.Type,
                s.Icon,
                s.BadgeColor,
                

                AppID = s.tbl_SYS_FormGroup.IDApp,
                AppName = s.tbl_SYS_FormGroup.tbl_SYS_Apps.Name,
                AppSort = s.tbl_SYS_FormGroup.tbl_SYS_Apps.Sort,

                GroupID = s.IDFormGroup,
                GroupCode = s.tbl_SYS_FormGroup.Code,
                GroupName = s.tbl_SYS_FormGroup.Name,
                GroupSort = s.tbl_SYS_FormGroup.Sort,

            }).OrderBy(o=>o.AppSort).ThenBy(o=>o.GroupSort).ThenBy(o=>o.Sort).ToList();

            var groups = tempData.Select(s =>new  {
                AppID = s.AppID,
                AppName = s.AppName,
                ID = s.GroupID,
                Code = s.GroupCode,
                Name = s.GroupName

            }).Distinct().ToList();

            List<DTO_APP_FormGroup> result = new List<DTO_APP_FormGroup>();

            foreach (var g in groups)
            {
                DTO_APP_FormGroup group = new DTO_APP_FormGroup()
                {
                    AppID = g.AppID,
                    AppName = g.AppName,
                    ID = g.ID,
                    Code = g.Code,
                    Name = g.Name

                };
                group.Forms = tempData.Where(d => d.GroupID == g.ID).Select(s => new DTO_APP_Form()
                {
                    ID = s.ID,
                    Code = s.Code,
                    Name = s.Name,
                    Sort = s.Sort,
                    Icon = s.Icon,
                    BadgeColor = s.BadgeColor,
                    Remark = s.Remark,
                    Type = s.Type
                }).ToList();

                result.Add(group);

                
            }

            return result;
        }

    }
}
