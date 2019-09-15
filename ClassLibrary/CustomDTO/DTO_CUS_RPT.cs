namespace DTOModel
{
    using System;
    public partial class DTO_CUS_DOC_RPT_Folder
    {
        public Nullable<int> ID { get; set; }
        public int CountFile { get; set; }
        public int CountApproved { get; set; }
        public int CountDraf { get; set; }
        public int CountWaitApprove { get; set; }
    }

    public partial class DTO_CUS_DOC_RPT_FileExtention
    {
        public string Extension { get; set; }
        public int CountFile { get; set; }
        public int CountApproved { get; set; }
    }
}
