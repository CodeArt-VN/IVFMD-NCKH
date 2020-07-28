namespace DTOModel
{
    using System;
    using System.Collections.Generic;

    public partial class DTO_SYS_Config_ThoiGianBaoCaoNSKH
    {
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }

    public partial class DTO_SYS_Config_ThoiGianBaoCaoTDNC
    {
        public int GiaiDoan1_NgayBatDau { get; set; }
        public int GiaiDoan1_NgayKetThuc{ get; set; }
        public int GiaiDoan2_NgayBatDau { get; set; }
        public int GiaiDoan2_NgayKetThuc { get; set; }
    }

    public partial class DTO_SYS_Config_Template
    {
        public string MauTrinhBayPPT { get; set; }
        public string MauBaoCaoTongHop { get; set; }
        public string MauThuyetMinhDeTai { get; set; }
    }
}