namespace DTOModel
{
    using System;
    using System.Collections.Generic;

    public partial class DTO_SYS_Config
    {
        public DTO_SYS_Config_ThoiGianBaoCaoNSKH ThoiGianBaoCaoNSKH { get; set; }
        public DTO_SYS_Config_ThoiGianBaoCaoTDNC ThoiGianBaoCaoTDNC { get; set; }
        public DTO_SYS_Config_Template Template { get; set; }
        public DTO_SYS_ConfigEmail Email { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string EmailList { get; set; }
    }

    public partial class DTO_SYS_ConfigEmail
    {
        public string Body { get; set; }
        public string Subject { get; set; }
        public string EmailList { get; set; }
    }

    public partial class DTO_Email
    {
        public string Destination { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
    }

    public partial class DTO_StatusResult
    {
        public List<DTO_Email> ListEmail { get; set; }
        public string Error { get; set; }
    }
}