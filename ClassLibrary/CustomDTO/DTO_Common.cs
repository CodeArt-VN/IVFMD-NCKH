namespace DTOModel
{
    using System;
    using System.Collections.Generic;

    public enum SYSVarType
    {
        PhanLoaiDeTai = 1,
        PhanLoaiDeTai_NghienCuu = -1,
        PhanLoaiDeTai_Khac = -2,

        TrangThai_HDDD = 2,
        TrangThai_HDDD_ChoGui = -6,
        TrangThai_HDDD_ChoDuyet = -7,
        TrangThai_HDDD_DaDuyet = -8,

        TrangThai_HDKH = 3,
        TrangThai_HDKH_ChoGui = -12,
        TrangThai_HDKH_ChoDuyet = -13,
        TrangThai_HDKH_DaDuyet = -14,

        TrangThai_HRCO = 4,
        TrangThai_HRCO_ChoGui = -18,
        TrangThai_HRCO_ChoDuyet = -19,
        TrangThai_HRCO_DaDuyet = -20,

        TrangThai_NghiemThu = 5,
        TrangThai_NghiemThu_ChoGui = -24,
        TrangThai_NghiemThu_ChoDuyet = -25,
        TrangThai_NghiemThu_DaDuyet = -26,

        TrangThai_HNHT = 6,
        TrangThai_HNHT_ChoGui = -31,
        TrangThai_HNHT_ChoDuyet = -32,
        TrangThai_HNHT_DaDuyet = -33,

        HinhThucXetDuyet = 7,
        HinhThucXetDuyet_RutGon = -37,
        HinhThucXetDuyet_DayDu = -38,

        TinhTrangNghienCuu = 8,
        TinhTrangNghienCuu_DangNhanMau = -41,
        TinhTrangNghienCuu_PhanTichSoLieu = -42,
        TinhTrangNghienCuu_VietBaiDangBao = -43,
        TinhTrangNghienCuu_GuiBaiTapChi = -44,
        TinhTrangNghienCuu_NghiemThu = -45,

        HinhThucDangKy = 9,
        HinhThucDangKy_Oral = -49,
        HinhThucDangKy_Poster = -50,
    }

    public enum SYSConfigCode
    {
        ThoiGianBaoCaoNSKH,
        ThoiGianBaoCaoTDNC,
        Template,
    }
}