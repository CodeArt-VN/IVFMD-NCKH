﻿namespace DTOModel
{
    using System;
    using System.Collections.Generic;

    public partial class DTO_CUS_HRM_STAFF_NhanSu_HOSREM
    {
        public List<string> ListDonViCongTac { get; set; }
        public List<string> ListHoatDongKhac { get; set; }
        public List<string> ListKinhNghiemLamViec { get; set; }
        public List<string> ListBaiDangTapChi { get; set; }
        public List<string> ListQuaTrinhDaoTao { get; set; }
        public string HTMLPrint { get; set; }
    }
}