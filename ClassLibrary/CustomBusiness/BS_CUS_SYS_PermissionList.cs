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

    public static partial class BS_CUS_SYS_PermissionList
    {
        public static List<DTO_CUS_SYS_Form_Role_PermissionList_Full> get_CUS_SYS_PermissionList(AppEntities db, int PartnerID, Dictionary<string, string> QueryStrings, bool Custom)
        {
            int idRole = 0;

            var query = db.tbl_CUS_SYS_PermissionList.Where(d => d.IDPartner == PartnerID);
            if (QueryStrings.Any(d => d.Key == "IDRole"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDRole").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count == 1)
                {
                    idRole = IDs[0];
                    query = query.Where(d => IDs.Contains(d.IDRole));
                }
            }

            if (idRole == 0)
            {
                return null;
            }

            List<DTO_CUS_SYS_PermissionList> permissionValueList = toDTO(query).ToList();

            //var today = DateTime.Today;

            //var partnerProducList = db.tbl_PROD_SanPham
            //    .Where(d => d.tbl_PAR_ThongTinSanPham.Any(c => c.IDPartner == PartnerID && c.IsDeleted == false && (c.NgayHetHan.HasValue == false || (c.NgayHetHan.HasValue && c.NgayHetHan >= today))))
            //    .Select(s => s.ID).ToList();

            var allFormOfPartner = db.tbl_SYS_Form
                //.Where(d => d.IsDeleted==false && d.tbl_SYS_FormGroup.tbl_SYS_Apps.tbl_PROD_SanPham_ChiTiet.Any(c => partnerProducList.Contains(c.IDSanPham)))
                .Where(d=>d.Type ==1 && d.IsDeleted ==false)
                .Select(s =>new {

                    AppID = s.tbl_SYS_FormGroup.IDApp,
                    AppName = s.tbl_SYS_FormGroup.tbl_SYS_Apps.Name,
                    AppCode =s.tbl_SYS_FormGroup.tbl_SYS_Apps.Code,
                    AppSort = s.tbl_SYS_FormGroup.tbl_SYS_Apps.Sort,

                    FormGroupID = s.IDFormGroup,
                    FormGroupName = s.tbl_SYS_FormGroup.Name,
                    FormGroupCode = s.tbl_SYS_FormGroup.Code,
                    FormGroupSort = s.tbl_SYS_FormGroup.Sort,

                    s.ID,
                    s.Code,
                    s.Name,
                    s.Icon,
                    s.BadgeColor,
                    s.Sort,
                    s.Remark,
                    s.Type

                }).OrderBy(o=>o.AppSort).ThenBy(o=>o.FormGroupSort).ThenBy(o=>o.Sort).ToList();

            List<DTO_CUS_SYS_Form_Role_PermissionList_Full> result = new List<DTO_CUS_SYS_Form_Role_PermissionList_Full>();

            foreach (var app in allFormOfPartner.Select(s=>new { s.AppID, s.AppCode, s.AppName }).Distinct())
            {
                DTO_CUS_SYS_Form_Role_PermissionList_Full appitem = new DTO_CUS_SYS_Form_Role_PermissionList_Full()
                {
                    RowType = 0, AppID = app.AppID, Code = app.AppCode, Name = app.AppName, Icon = "",
                    PermissionList = new List<DTO_CUS_SYS_PermissionList>()
                };
                appitem.PermissionList.Add(new DTO_CUS_SYS_PermissionList());
                result.Add(appitem);
                foreach (var group in allFormOfPartner.Where(d=>d.AppID == app.AppID).Select(s => new { s.FormGroupID, s.FormGroupCode, s.FormGroupName }).Distinct())
                {
                    DTO_CUS_SYS_Form_Role_PermissionList_Full groupitem = new DTO_CUS_SYS_Form_Role_PermissionList_Full()
                    {
                        RowType = 1, AppID = app.AppID, GroupID = group.FormGroupID, Code = group.FormGroupCode, Name = group.FormGroupName,
                        PermissionList = new List<DTO_CUS_SYS_PermissionList>()
                    };
                    groupitem.PermissionList.Add(new DTO_CUS_SYS_PermissionList());
                    result.Add(groupitem);
                    foreach (var form in allFormOfPartner.Where(d=>d.AppID == app.AppID && d.FormGroupID == group.FormGroupID))
                    {
                        var permis = permissionValueList.Where(d => d.IDForm == form.ID).ToList();
                        if (permis.Count == 0)
                        {
                            permis.Add(new DTO_CUS_SYS_PermissionList() { ID = 0, IDForm = form.ID, IDRole = idRole });
                        }

                        DTO_CUS_SYS_Form_Role_PermissionList_Full item = new DTO_CUS_SYS_Form_Role_PermissionList_Full()
                        {
                            RowType = 2, AppID = form.AppID, GroupID = form.FormGroupID, ID = form.ID, Code = form.Code, Name = form.Name, Remark = form.Remark, Icon = form.Icon, BadgeColor = form.BadgeColor, Type = form.Type,
                            PermissionList = permis
                        };
                        result.Add(item);
                    }
                }
            }
            
            return result;
        }

    }
}
