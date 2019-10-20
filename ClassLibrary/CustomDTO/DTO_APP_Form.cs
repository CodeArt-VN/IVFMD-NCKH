namespace DTOModel
{
    using System;
    using System.Collections.Generic;

    public partial class DTO_APP_Form
    {
        
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Sort { get; set; }
        public int Type { get; set; }
        public string Icon { get; set; }
        public string BadgeColor { get; set; }
        public bool IsHiddenMenu { get; set; }
    }

    public partial class DTO_APP_FormGroup
    {
        public int AppID { get; set; }
        public string AppName { get; set; }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<DTO_APP_Form> Forms { get; set; }
        public List<DTO_APP_Form> FormMenu { get; set; }
    }

    public partial class DTO_APP_UserInfo
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName { get; set; }
        public string Avatar { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public int StaffID { get; set; }
        public int PartnerID { get; set; }

        public DTO_AppRole Roles { get; set; }
        public List<DTO_APP_FormGroup> MenuItems { get; set; }
        public List<DTO_Partner> Partners { get; set; }
    }
    
    public partial class DTO_AppRole
    {
        public List<int> CUSRoles { get; set; }
        public List<string> SYSRoles { get; set; }
    }
    public partial class DTO_Partner
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string BannerURL { get; set; }
        public string LogoURL { get; set; }
        public string Remark { get; set; }
        public string TemplateHeader { get; set; }
        public string TemplateFooter { get; set; }
    }

    public partial class DTO_CUS_SYS_Form_Role_PermissionList_Full
    {
        public int RowType { get; set; } //0 App, 1 Group, 2 Form

        //Form properties
        public int AppID { get; set; }
        public int GroupID { get; set; }
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Sort { get; set; }
        public int Type { get; set; }
        public string Icon { get; set; }
        public string BadgeColor { get; set; }
        
        public List<DTO_CUS_SYS_PermissionList> PermissionList { get; set; }
        
    }

    

}
