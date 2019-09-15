namespace DTOModel
{
    using System;
    public partial class DTO_CUS_HRM_STAFF_NhanSu
    {
        public string RoleName { get; set; }

        public bool IsCreatedAccount { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsHostAccount { get; set; }

    }
}