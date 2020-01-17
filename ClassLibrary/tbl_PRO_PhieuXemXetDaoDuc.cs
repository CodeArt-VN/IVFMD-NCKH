//------------------------------------------------------------------------------
// 
//    www.codeart.vn
//    hungvq@live.com
//    (+84)908.061.119
// 
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    
    using System;
    using System.Collections.Generic;
    
    
    public partial class tbl_PRO_PhieuXemXetDaoDuc
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string MaSo { get; set; }
        public bool NghienCuuDuocTaiTro { get; set; }
        public bool XinPhepTapThe { get; set; }
        public bool KhongThuocNghienCuuNao { get; set; }
        public bool NghienCuuHocVienSauDaiHoc { get; set; }
        public bool DonXinTaiCapPhep { get; set; }
        public bool NghienCuuCuaSinhVienDaiHoc { get; set; }
        public bool SoGiayPhepCu { get; set; }
        public string TenNCSYH { get; set; }
        public string JSON_CacNCV { get; set; }
        public string DonViChuTri { get; set; }
        public string NguoiGiaoDich_HoTen { get; set; }
        public string NguoiGiaoDich_DiaChiGiaoDich { get; set; }
        public string NguoiGiaoDich_DienThoaiCQ { get; set; }
        public string NguoiGiaoDich_DienThoaiFx { get; set; }
        public string NguoiGiaoDich_DienThoaiNR { get; set; }
        public string NguoiGiaoDich_DienThoaiDD { get; set; }
        public string NguoiGiaoDich_Email { get; set; }
        public string JSON_CacCoQuan { get; set; }
        public bool QuyChe_TreEm { get; set; }
        public bool QuyChe_NguoiQuanHeLeThuoc { get; set; }
        public bool QuyChe_PhongXa { get; set; }
        public bool QuyChe_PhacDoDieuTri { get; set; }
        public bool QuyChe_GienNguoi { get; set; }
        public bool QuyChe_NguoiTonThuongThanKinh { get; set; }
        public bool QuyChe_CacTapTheNhomNguoi { get; set; }
        public bool QuyChe_NghienCuuDichTeHoc { get; set; }
        public bool QuyChe_NguoiCanChamSocYTe { get; set; }
        public bool QuyChe_NguoiDanToc { get; set; }
        public bool QuyChe_ThuNghiemLamSang { get; set; }
        public bool QuyChe_SuDungMauMoNguoi { get; set; }
        public string ThongTinNguonTaiTro { get; set; }
        public string ThongTinNCYSHSinhVien { get; set; }
        public string QuyTrinh_MoTaDuAn { get; set; }
        public string QuyTrinh_QuyTrinhThucHien { get; set; }
        public string QuyTrinh_MucDich { get; set; }
        public string QuyTrinh_VanDeLienQuan { get; set; }
        public string QuyTrinh_DiaDiemNghienCuu { get; set; }
        public string QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia { get; set; }
        public bool NguyCoTiemTang_NhomNghienCuu { get; set; }
        public bool NguyCoTiemTang_NguoiThamGia { get; set; }
        public bool NguyCoTiemTang_CongDongCuaTruong { get; set; }
        public bool NguyCoTiemTang_CongDongLonHon { get; set; }
        public string NguyCoTiemTang_SoSanhRuiRo { get; set; }
        public string NguyCoTiemTang_QuyTrinhGiamRuiRo { get; set; }
        public string NguyCoTiemTang_CachXuLyRuiRo { get; set; }
        public string LoiIchTiemTang_NhungLoiIch { get; set; }
        public string LoiIchTiemTang_AiDuocLoi { get; set; }
        public string LoiIchTiemTang_DongGopKhoaHoc { get; set; }
        public string LoiIchTiemTang_SoSanh { get; set; }
        public string HTML { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_PhieuXemXetDaoDuc
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string MaSo { get; set; }
		public bool NghienCuuDuocTaiTro { get; set; }
		public bool XinPhepTapThe { get; set; }
		public bool KhongThuocNghienCuuNao { get; set; }
		public bool NghienCuuHocVienSauDaiHoc { get; set; }
		public bool DonXinTaiCapPhep { get; set; }
		public bool NghienCuuCuaSinhVienDaiHoc { get; set; }
		public bool SoGiayPhepCu { get; set; }
		public string TenNCSYH { get; set; }
		public string JSON_CacNCV { get; set; }
		public string DonViChuTri { get; set; }

		public string NguoiGiaoDich_HoTen { get; set; }
		public string NguoiGiaoDich_DiaChiGiaoDich { get; set; }
		public string NguoiGiaoDich_DienThoaiCQ { get; set; }
		public string NguoiGiaoDich_DienThoaiFx { get; set; }
		public string NguoiGiaoDich_DienThoaiNR { get; set; }
		public string NguoiGiaoDich_DienThoaiDD { get; set; }
		public string NguoiGiaoDich_Email { get; set; }
		
		public string JSON_CacCoQuan { get; set; }

		public bool QuyChe_TreEm { get; set; }
		public bool QuyChe_NguoiQuanHeLeThuoc { get; set; }
		public bool QuyChe_PhongXa { get; set; }
		public bool QuyChe_PhacDoDieuTri { get; set; }
		public bool QuyChe_GienNguoi { get; set; }
		public bool QuyChe_NguoiTonThuongThanKinh { get; set; }
		public bool QuyChe_CacTapTheNhomNguoi { get; set; }
		public bool QuyChe_NghienCuuDichTeHoc { get; set; }
		public bool QuyChe_NguoiCanChamSocYTe { get; set; }
		public bool QuyChe_NguoiDanToc { get; set; }
		public bool QuyChe_ThuNghiemLamSang { get; set; }
		public bool QuyChe_SuDungMauMoNguoi { get; set; }
		public bool QuyChe_CoTroGiupKiThuat { get; set; }

		public string ThongTinNguonTaiTro { get; set; }
		public string ThongTinNCYSHSinhVien { get; set; }
		public string QuyTrinh_MoTaDuAn { get; set; }
		public string QuyTrinh_QuyTrinhThucHien { get; set; }
		public string QuyTrinh_MucDich { get; set; }
		public string QuyTrinh_VanDeLienQuan { get; set; }
		public string QuyTrinh_DiaDiemNghienCuu { get; set; }
		public string QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia { get; set; }
		
		public bool NguyCoTiemTang_NhomNghienCuu { get; set; }
		public bool NguyCoTiemTang_NguoiThamGia { get; set; }
		public bool NguyCoTiemTang_CongDongCuaTruong { get; set; }
		public bool NguyCoTiemTang_CongDongLonHon { get; set; }

		public string NguyCoTiemTang_SoSanhRuiRo { get; set; }
		public string NguyCoTiemTang_QuyTrinhGiamRuiRo { get; set; }
		public string NguyCoTiemTang_CachXuLyRuiRo { get; set; }
		public string NguyCoTiemTang_SucKhoeVaTinhAnToan { get; set; }
		public string NguyCoTiemTang_CacVanDeAnToanSinhHoc { get; set; }
		public string NguyCoTiemTang_ThaoTacGen { get; set; }


		public string LoiIchTiemTang_NhungLoiIch { get; set; }
		public string LoiIchTiemTang_AiDuocLoi { get; set; }
		public string LoiIchTiemTang_DongGopKhoaHoc { get; set; }
		public string LoiIchTiemTang_SoSanh { get; set; }

		public string HTML { get; set; }
		public bool IsDisabled { get; set; }
		public bool IsDeleted { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
	}
}


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

    public static partial class BS_PRO_PhieuXemXetDaoDuc 
    {
		public static IQueryable<DTO_PRO_PhieuXemXetDaoDuc> toDTO(IQueryable<tbl_PRO_PhieuXemXetDaoDuc> query)
        {
			return query
			.Select(s => new DTO_PRO_PhieuXemXetDaoDuc(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				MaSo = s.MaSo,							
				NghienCuuDuocTaiTro = s.NghienCuuDuocTaiTro,							
				XinPhepTapThe = s.XinPhepTapThe,							
				KhongThuocNghienCuuNao = s.KhongThuocNghienCuuNao,							
				NghienCuuHocVienSauDaiHoc = s.NghienCuuHocVienSauDaiHoc,							
				DonXinTaiCapPhep = s.DonXinTaiCapPhep,							
				NghienCuuCuaSinhVienDaiHoc = s.NghienCuuCuaSinhVienDaiHoc,							
				SoGiayPhepCu = s.SoGiayPhepCu,							
				TenNCSYH = s.TenNCSYH,							
				JSON_CacNCV = s.JSON_CacNCV,							
				DonViChuTri = s.DonViChuTri,							
				NguoiGiaoDich_HoTen = s.NguoiGiaoDich_HoTen,							
				NguoiGiaoDich_DiaChiGiaoDich = s.NguoiGiaoDich_DiaChiGiaoDich,							
				NguoiGiaoDich_DienThoaiCQ = s.NguoiGiaoDich_DienThoaiCQ,							
				NguoiGiaoDich_DienThoaiFx = s.NguoiGiaoDich_DienThoaiFx,							
				NguoiGiaoDich_DienThoaiNR = s.NguoiGiaoDich_DienThoaiNR,							
				NguoiGiaoDich_DienThoaiDD = s.NguoiGiaoDich_DienThoaiDD,							
				NguoiGiaoDich_Email = s.NguoiGiaoDich_Email,							
				JSON_CacCoQuan = s.JSON_CacCoQuan,							
				QuyChe_TreEm = s.QuyChe_TreEm,							
				QuyChe_NguoiQuanHeLeThuoc = s.QuyChe_NguoiQuanHeLeThuoc,							
				QuyChe_PhongXa = s.QuyChe_PhongXa,							
				QuyChe_PhacDoDieuTri = s.QuyChe_PhacDoDieuTri,							
				QuyChe_GienNguoi = s.QuyChe_GienNguoi,							
				QuyChe_NguoiTonThuongThanKinh = s.QuyChe_NguoiTonThuongThanKinh,							
				QuyChe_CacTapTheNhomNguoi = s.QuyChe_CacTapTheNhomNguoi,							
				QuyChe_NghienCuuDichTeHoc = s.QuyChe_NghienCuuDichTeHoc,							
				QuyChe_NguoiCanChamSocYTe = s.QuyChe_NguoiCanChamSocYTe,							
				QuyChe_NguoiDanToc = s.QuyChe_NguoiDanToc,							
				QuyChe_ThuNghiemLamSang = s.QuyChe_ThuNghiemLamSang,							
				QuyChe_SuDungMauMoNguoi = s.QuyChe_SuDungMauMoNguoi,							
				ThongTinNguonTaiTro = s.ThongTinNguonTaiTro,							
				ThongTinNCYSHSinhVien = s.ThongTinNCYSHSinhVien,							
				QuyTrinh_MoTaDuAn = s.QuyTrinh_MoTaDuAn,							
				QuyTrinh_QuyTrinhThucHien = s.QuyTrinh_QuyTrinhThucHien,							
				QuyTrinh_MucDich = s.QuyTrinh_MucDich,							
				QuyTrinh_VanDeLienQuan = s.QuyTrinh_VanDeLienQuan,							
				QuyTrinh_DiaDiemNghienCuu = s.QuyTrinh_DiaDiemNghienCuu,							
				QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia = s.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia,							
				NguyCoTiemTang_NhomNghienCuu = s.NguyCoTiemTang_NhomNghienCuu,							
				NguyCoTiemTang_NguoiThamGia = s.NguyCoTiemTang_NguoiThamGia,							
				NguyCoTiemTang_CongDongCuaTruong = s.NguyCoTiemTang_CongDongCuaTruong,							
				NguyCoTiemTang_CongDongLonHon = s.NguyCoTiemTang_CongDongLonHon,							
				NguyCoTiemTang_SoSanhRuiRo = s.NguyCoTiemTang_SoSanhRuiRo,							
				NguyCoTiemTang_QuyTrinhGiamRuiRo = s.NguyCoTiemTang_QuyTrinhGiamRuiRo,							
				NguyCoTiemTang_CachXuLyRuiRo = s.NguyCoTiemTang_CachXuLyRuiRo,							
				LoiIchTiemTang_NhungLoiIch = s.LoiIchTiemTang_NhungLoiIch,							
				LoiIchTiemTang_AiDuocLoi = s.LoiIchTiemTang_AiDuocLoi,							
				LoiIchTiemTang_DongGopKhoaHoc = s.LoiIchTiemTang_DongGopKhoaHoc,							
				LoiIchTiemTang_SoSanh = s.LoiIchTiemTang_SoSanh,							
				HTML = s.HTML,							
				IsDisabled = s.IsDisabled,							
				IsDeleted = s.IsDeleted,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,					
			});
                              
        }

		public static DTO_PRO_PhieuXemXetDaoDuc toDTO(tbl_PRO_PhieuXemXetDaoDuc dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_PhieuXemXetDaoDuc()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					MaSo = dbResult.MaSo,							
					NghienCuuDuocTaiTro = dbResult.NghienCuuDuocTaiTro,							
					XinPhepTapThe = dbResult.XinPhepTapThe,							
					KhongThuocNghienCuuNao = dbResult.KhongThuocNghienCuuNao,							
					NghienCuuHocVienSauDaiHoc = dbResult.NghienCuuHocVienSauDaiHoc,							
					DonXinTaiCapPhep = dbResult.DonXinTaiCapPhep,							
					NghienCuuCuaSinhVienDaiHoc = dbResult.NghienCuuCuaSinhVienDaiHoc,							
					SoGiayPhepCu = dbResult.SoGiayPhepCu,							
					TenNCSYH = dbResult.TenNCSYH,							
					JSON_CacNCV = dbResult.JSON_CacNCV,							
					DonViChuTri = dbResult.DonViChuTri,							
					NguoiGiaoDich_HoTen = dbResult.NguoiGiaoDich_HoTen,							
					NguoiGiaoDich_DiaChiGiaoDich = dbResult.NguoiGiaoDich_DiaChiGiaoDich,							
					NguoiGiaoDich_DienThoaiCQ = dbResult.NguoiGiaoDich_DienThoaiCQ,							
					NguoiGiaoDich_DienThoaiFx = dbResult.NguoiGiaoDich_DienThoaiFx,							
					NguoiGiaoDich_DienThoaiNR = dbResult.NguoiGiaoDich_DienThoaiNR,							
					NguoiGiaoDich_DienThoaiDD = dbResult.NguoiGiaoDich_DienThoaiDD,							
					NguoiGiaoDich_Email = dbResult.NguoiGiaoDich_Email,							
					JSON_CacCoQuan = dbResult.JSON_CacCoQuan,							
					QuyChe_TreEm = dbResult.QuyChe_TreEm,							
					QuyChe_NguoiQuanHeLeThuoc = dbResult.QuyChe_NguoiQuanHeLeThuoc,							
					QuyChe_PhongXa = dbResult.QuyChe_PhongXa,							
					QuyChe_PhacDoDieuTri = dbResult.QuyChe_PhacDoDieuTri,							
					QuyChe_GienNguoi = dbResult.QuyChe_GienNguoi,							
					QuyChe_NguoiTonThuongThanKinh = dbResult.QuyChe_NguoiTonThuongThanKinh,							
					QuyChe_CacTapTheNhomNguoi = dbResult.QuyChe_CacTapTheNhomNguoi,							
					QuyChe_NghienCuuDichTeHoc = dbResult.QuyChe_NghienCuuDichTeHoc,							
					QuyChe_NguoiCanChamSocYTe = dbResult.QuyChe_NguoiCanChamSocYTe,							
					QuyChe_NguoiDanToc = dbResult.QuyChe_NguoiDanToc,							
					QuyChe_ThuNghiemLamSang = dbResult.QuyChe_ThuNghiemLamSang,							
					QuyChe_SuDungMauMoNguoi = dbResult.QuyChe_SuDungMauMoNguoi,							
					ThongTinNguonTaiTro = dbResult.ThongTinNguonTaiTro,							
					ThongTinNCYSHSinhVien = dbResult.ThongTinNCYSHSinhVien,							
					QuyTrinh_MoTaDuAn = dbResult.QuyTrinh_MoTaDuAn,							
					QuyTrinh_QuyTrinhThucHien = dbResult.QuyTrinh_QuyTrinhThucHien,							
					QuyTrinh_MucDich = dbResult.QuyTrinh_MucDich,							
					QuyTrinh_VanDeLienQuan = dbResult.QuyTrinh_VanDeLienQuan,							
					QuyTrinh_DiaDiemNghienCuu = dbResult.QuyTrinh_DiaDiemNghienCuu,							
					QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia = dbResult.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia,							
					NguyCoTiemTang_NhomNghienCuu = dbResult.NguyCoTiemTang_NhomNghienCuu,							
					NguyCoTiemTang_NguoiThamGia = dbResult.NguyCoTiemTang_NguoiThamGia,							
					NguyCoTiemTang_CongDongCuaTruong = dbResult.NguyCoTiemTang_CongDongCuaTruong,							
					NguyCoTiemTang_CongDongLonHon = dbResult.NguyCoTiemTang_CongDongLonHon,							
					NguyCoTiemTang_SoSanhRuiRo = dbResult.NguyCoTiemTang_SoSanhRuiRo,							
					NguyCoTiemTang_QuyTrinhGiamRuiRo = dbResult.NguyCoTiemTang_QuyTrinhGiamRuiRo,							
					NguyCoTiemTang_CachXuLyRuiRo = dbResult.NguyCoTiemTang_CachXuLyRuiRo,							
					LoiIchTiemTang_NhungLoiIch = dbResult.LoiIchTiemTang_NhungLoiIch,							
					LoiIchTiemTang_AiDuocLoi = dbResult.LoiIchTiemTang_AiDuocLoi,							
					LoiIchTiemTang_DongGopKhoaHoc = dbResult.LoiIchTiemTang_DongGopKhoaHoc,							
					LoiIchTiemTang_SoSanh = dbResult.LoiIchTiemTang_SoSanh,							
					HTML = dbResult.HTML,							
					IsDisabled = dbResult.IsDisabled,							
					IsDeleted = dbResult.IsDeleted,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_PhieuXemXetDaoDuc> get_PRO_PhieuXemXetDaoDuc(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_PhieuXemXetDaoDuc.Where(d => d.IsDeleted == false );

			//Query keyword



			//Query ID (int)
			if (QueryStrings.Any(d => d.Key == "ID"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "ID").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.ID));
            }

			//Query IDDeTai (int)
			if (QueryStrings.Any(d => d.Key == "IDDeTai"))
            {
                var IDList = QueryStrings.FirstOrDefault(d => d.Key == "IDDeTai").Value.Replace("[", "").Replace("]", "").Split(',');
                List<int> IDs = new List<int>();
                foreach (var item in IDList)
                    if (int.TryParse(item, out int i))
                        IDs.Add(i);
                if (IDs.Count > 0)
                    query = query.Where(d => IDs.Contains(d.IDDeTai));
            }

			//Query MaSo (string)
			if (QueryStrings.Any(d => d.Key == "MaSo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "MaSo").Value;
                query = query.Where(d=>d.MaSo == keyword);
            }

			//Query NghienCuuDuocTaiTro (bool)
			if (QueryStrings.Any(d => d.Key == "NghienCuuDuocTaiTro"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghienCuuDuocTaiTro").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghienCuuDuocTaiTro);
            }

			//Query XinPhepTapThe (bool)
			if (QueryStrings.Any(d => d.Key == "XinPhepTapThe"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "XinPhepTapThe").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.XinPhepTapThe);
            }

			//Query KhongThuocNghienCuuNao (bool)
			if (QueryStrings.Any(d => d.Key == "KhongThuocNghienCuuNao"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "KhongThuocNghienCuuNao").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.KhongThuocNghienCuuNao);
            }

			//Query NghienCuuHocVienSauDaiHoc (bool)
			if (QueryStrings.Any(d => d.Key == "NghienCuuHocVienSauDaiHoc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghienCuuHocVienSauDaiHoc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghienCuuHocVienSauDaiHoc);
            }

			//Query DonXinTaiCapPhep (bool)
			if (QueryStrings.Any(d => d.Key == "DonXinTaiCapPhep"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "DonXinTaiCapPhep").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.DonXinTaiCapPhep);
            }

			//Query NghienCuuCuaSinhVienDaiHoc (bool)
			if (QueryStrings.Any(d => d.Key == "NghienCuuCuaSinhVienDaiHoc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NghienCuuCuaSinhVienDaiHoc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NghienCuuCuaSinhVienDaiHoc);
            }

			//Query SoGiayPhepCu (bool)
			if (QueryStrings.Any(d => d.Key == "SoGiayPhepCu"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "SoGiayPhepCu").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.SoGiayPhepCu);
            }

			//Query TenNCSYH (string)
			if (QueryStrings.Any(d => d.Key == "TenNCSYH") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "TenNCSYH").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "TenNCSYH").Value;
                query = query.Where(d=>d.TenNCSYH == keyword);
            }

			//Query JSON_CacNCV (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CacNCV") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacNCV").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacNCV").Value;
                query = query.Where(d=>d.JSON_CacNCV == keyword);
            }

			//Query DonViChuTri (string)
			if (QueryStrings.Any(d => d.Key == "DonViChuTri") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DonViChuTri").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DonViChuTri").Value;
                query = query.Where(d=>d.DonViChuTri == keyword);
            }

			//Query NguoiGiaoDich_HoTen (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_HoTen") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_HoTen").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_HoTen").Value;
                query = query.Where(d=>d.NguoiGiaoDich_HoTen == keyword);
            }

			//Query NguoiGiaoDich_DiaChiGiaoDich (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DiaChiGiaoDich") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DiaChiGiaoDich").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DiaChiGiaoDich").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DiaChiGiaoDich == keyword);
            }

			//Query NguoiGiaoDich_DienThoaiCQ (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DienThoaiCQ") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiCQ").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiCQ").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DienThoaiCQ == keyword);
            }

			//Query NguoiGiaoDich_DienThoaiFx (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DienThoaiFx") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiFx").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiFx").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DienThoaiFx == keyword);
            }

			//Query NguoiGiaoDich_DienThoaiNR (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DienThoaiNR") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiNR").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiNR").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DienThoaiNR == keyword);
            }

			//Query NguoiGiaoDich_DienThoaiDD (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_DienThoaiDD") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiDD").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_DienThoaiDD").Value;
                query = query.Where(d=>d.NguoiGiaoDich_DienThoaiDD == keyword);
            }

			//Query NguoiGiaoDich_Email (string)
			if (QueryStrings.Any(d => d.Key == "NguoiGiaoDich_Email") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_Email").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguoiGiaoDich_Email").Value;
                query = query.Where(d=>d.NguoiGiaoDich_Email == keyword);
            }

			//Query JSON_CacCoQuan (string)
			if (QueryStrings.Any(d => d.Key == "JSON_CacCoQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacCoQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "JSON_CacCoQuan").Value;
                query = query.Where(d=>d.JSON_CacCoQuan == keyword);
            }

			//Query QuyChe_TreEm (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_TreEm"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_TreEm").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_TreEm);
            }

			//Query QuyChe_NguoiQuanHeLeThuoc (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NguoiQuanHeLeThuoc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NguoiQuanHeLeThuoc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NguoiQuanHeLeThuoc);
            }

			//Query QuyChe_PhongXa (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_PhongXa"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_PhongXa").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_PhongXa);
            }

			//Query QuyChe_PhacDoDieuTri (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_PhacDoDieuTri"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_PhacDoDieuTri").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_PhacDoDieuTri);
            }

			//Query QuyChe_GienNguoi (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_GienNguoi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_GienNguoi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_GienNguoi);
            }

			//Query QuyChe_NguoiTonThuongThanKinh (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NguoiTonThuongThanKinh"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NguoiTonThuongThanKinh").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NguoiTonThuongThanKinh);
            }

			//Query QuyChe_CacTapTheNhomNguoi (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_CacTapTheNhomNguoi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_CacTapTheNhomNguoi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_CacTapTheNhomNguoi);
            }

			//Query QuyChe_NghienCuuDichTeHoc (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NghienCuuDichTeHoc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NghienCuuDichTeHoc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NghienCuuDichTeHoc);
            }

			//Query QuyChe_NguoiCanChamSocYTe (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NguoiCanChamSocYTe"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NguoiCanChamSocYTe").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NguoiCanChamSocYTe);
            }

			//Query QuyChe_NguoiDanToc (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_NguoiDanToc"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_NguoiDanToc").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_NguoiDanToc);
            }

			//Query QuyChe_ThuNghiemLamSang (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_ThuNghiemLamSang"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_ThuNghiemLamSang").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_ThuNghiemLamSang);
            }

			//Query QuyChe_SuDungMauMoNguoi (bool)
			if (QueryStrings.Any(d => d.Key == "QuyChe_SuDungMauMoNguoi"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "QuyChe_SuDungMauMoNguoi").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.QuyChe_SuDungMauMoNguoi);
            }

			//Query ThongTinNguonTaiTro (string)
			if (QueryStrings.Any(d => d.Key == "ThongTinNguonTaiTro") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThongTinNguonTaiTro").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThongTinNguonTaiTro").Value;
                query = query.Where(d=>d.ThongTinNguonTaiTro == keyword);
            }

			//Query ThongTinNCYSHSinhVien (string)
			if (QueryStrings.Any(d => d.Key == "ThongTinNCYSHSinhVien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThongTinNCYSHSinhVien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThongTinNCYSHSinhVien").Value;
                query = query.Where(d=>d.ThongTinNCYSHSinhVien == keyword);
            }

			//Query QuyTrinh_MoTaDuAn (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_MoTaDuAn") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_MoTaDuAn").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_MoTaDuAn").Value;
                query = query.Where(d=>d.QuyTrinh_MoTaDuAn == keyword);
            }

			//Query QuyTrinh_QuyTrinhThucHien (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_QuyTrinhThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_QuyTrinhThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_QuyTrinhThucHien").Value;
                query = query.Where(d=>d.QuyTrinh_QuyTrinhThucHien == keyword);
            }

			//Query QuyTrinh_MucDich (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_MucDich") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_MucDich").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_MucDich").Value;
                query = query.Where(d=>d.QuyTrinh_MucDich == keyword);
            }

			//Query QuyTrinh_VanDeLienQuan (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_VanDeLienQuan") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_VanDeLienQuan").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_VanDeLienQuan").Value;
                query = query.Where(d=>d.QuyTrinh_VanDeLienQuan == keyword);
            }

			//Query QuyTrinh_DiaDiemNghienCuu (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_DiaDiemNghienCuu") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_DiaDiemNghienCuu").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_DiaDiemNghienCuu").Value;
                query = query.Where(d=>d.QuyTrinh_DiaDiemNghienCuu == keyword);
            }

			//Query QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia").Value;
                query = query.Where(d=>d.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia == keyword);
            }

			//Query NguyCoTiemTang_NhomNghienCuu (bool)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_NhomNghienCuu"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_NhomNghienCuu").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguyCoTiemTang_NhomNghienCuu);
            }

			//Query NguyCoTiemTang_NguoiThamGia (bool)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_NguoiThamGia"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_NguoiThamGia").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguyCoTiemTang_NguoiThamGia);
            }

			//Query NguyCoTiemTang_CongDongCuaTruong (bool)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_CongDongCuaTruong"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_CongDongCuaTruong").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguyCoTiemTang_CongDongCuaTruong);
            }

			//Query NguyCoTiemTang_CongDongLonHon (bool)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_CongDongLonHon"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_CongDongLonHon").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.NguyCoTiemTang_CongDongLonHon);
            }

			//Query NguyCoTiemTang_SoSanhRuiRo (string)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_SoSanhRuiRo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_SoSanhRuiRo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_SoSanhRuiRo").Value;
                query = query.Where(d=>d.NguyCoTiemTang_SoSanhRuiRo == keyword);
            }

			//Query NguyCoTiemTang_QuyTrinhGiamRuiRo (string)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_QuyTrinhGiamRuiRo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_QuyTrinhGiamRuiRo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_QuyTrinhGiamRuiRo").Value;
                query = query.Where(d=>d.NguyCoTiemTang_QuyTrinhGiamRuiRo == keyword);
            }

			//Query NguyCoTiemTang_CachXuLyRuiRo (string)
			if (QueryStrings.Any(d => d.Key == "NguyCoTiemTang_CachXuLyRuiRo") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_CachXuLyRuiRo").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NguyCoTiemTang_CachXuLyRuiRo").Value;
                query = query.Where(d=>d.NguyCoTiemTang_CachXuLyRuiRo == keyword);
            }

			//Query LoiIchTiemTang_NhungLoiIch (string)
			if (QueryStrings.Any(d => d.Key == "LoiIchTiemTang_NhungLoiIch") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_NhungLoiIch").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_NhungLoiIch").Value;
                query = query.Where(d=>d.LoiIchTiemTang_NhungLoiIch == keyword);
            }

			//Query LoiIchTiemTang_AiDuocLoi (string)
			if (QueryStrings.Any(d => d.Key == "LoiIchTiemTang_AiDuocLoi") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_AiDuocLoi").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_AiDuocLoi").Value;
                query = query.Where(d=>d.LoiIchTiemTang_AiDuocLoi == keyword);
            }

			//Query LoiIchTiemTang_DongGopKhoaHoc (string)
			if (QueryStrings.Any(d => d.Key == "LoiIchTiemTang_DongGopKhoaHoc") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_DongGopKhoaHoc").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_DongGopKhoaHoc").Value;
                query = query.Where(d=>d.LoiIchTiemTang_DongGopKhoaHoc == keyword);
            }

			//Query LoiIchTiemTang_SoSanh (string)
			if (QueryStrings.Any(d => d.Key == "LoiIchTiemTang_SoSanh") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_SoSanh").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LoiIchTiemTang_SoSanh").Value;
                query = query.Where(d=>d.LoiIchTiemTang_SoSanh == keyword);
            }

			//Query HTML (string)
			if (QueryStrings.Any(d => d.Key == "HTML") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "HTML").Value;
                query = query.Where(d=>d.HTML == keyword);
            }

			//Query IsDisabled (bool)
			if (QueryStrings.Any(d => d.Key == "IsDisabled"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDisabled").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDisabled);
            }

			//Query IsDeleted (bool)
			if (QueryStrings.Any(d => d.Key == "IsDeleted"))
            {
                var qValue = QueryStrings.FirstOrDefault(d => d.Key == "IsDeleted").Value;
                if (bool.TryParse(qValue, out bool qBoolValue))
                    query = query.Where(d => qBoolValue == d.IsDeleted);
            }

			//Query CreatedDate (System.DateTime)
			if (QueryStrings.Any(d => d.Key == "CreatedDateFrom") && QueryStrings.Any(d => d.Key == "CreatedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "CreatedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.CreatedDate && d.CreatedDate <= toDate);

			//Query CreatedBy (string)
			if (QueryStrings.Any(d => d.Key == "CreatedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "CreatedBy").Value;
                query = query.Where(d=>d.CreatedBy == keyword);
            }

			//Query ModifiedDate (Nullable<System.DateTime>)
			if (QueryStrings.Any(d => d.Key == "ModifiedDateFrom") && QueryStrings.Any(d => d.Key == "ModifiedDateTo"))
                if (DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateFrom").Value, out DateTime fromDate) && DateTime.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedDateTo").Value, out DateTime toDate))
                    query = query.Where(d => fromDate <= d.ModifiedDate && d.ModifiedDate <= toDate);

			//Query ModifiedBy (string)
			if (QueryStrings.Any(d => d.Key == "ModifiedBy") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ModifiedBy").Value;
                query = query.Where(d=>d.ModifiedBy == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PRO_PhieuXemXetDaoDuc get_PRO_PhieuXemXetDaoDuc(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_PhieuXemXetDaoDuc.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_PhieuXemXetDaoDuc(AppEntities db, int ID, DTO_PRO_PhieuXemXetDaoDuc item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_PhieuXemXetDaoDuc.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.MaSo = item.MaSo;							
				dbitem.NghienCuuDuocTaiTro = item.NghienCuuDuocTaiTro;							
				dbitem.XinPhepTapThe = item.XinPhepTapThe;							
				dbitem.KhongThuocNghienCuuNao = item.KhongThuocNghienCuuNao;							
				dbitem.NghienCuuHocVienSauDaiHoc = item.NghienCuuHocVienSauDaiHoc;							
				dbitem.DonXinTaiCapPhep = item.DonXinTaiCapPhep;							
				dbitem.NghienCuuCuaSinhVienDaiHoc = item.NghienCuuCuaSinhVienDaiHoc;							
				dbitem.SoGiayPhepCu = item.SoGiayPhepCu;							
				dbitem.TenNCSYH = item.TenNCSYH;							
				dbitem.JSON_CacNCV = item.JSON_CacNCV;							
				dbitem.DonViChuTri = item.DonViChuTri;							
				dbitem.NguoiGiaoDich_HoTen = item.NguoiGiaoDich_HoTen;							
				dbitem.NguoiGiaoDich_DiaChiGiaoDich = item.NguoiGiaoDich_DiaChiGiaoDich;							
				dbitem.NguoiGiaoDich_DienThoaiCQ = item.NguoiGiaoDich_DienThoaiCQ;							
				dbitem.NguoiGiaoDich_DienThoaiFx = item.NguoiGiaoDich_DienThoaiFx;							
				dbitem.NguoiGiaoDich_DienThoaiNR = item.NguoiGiaoDich_DienThoaiNR;							
				dbitem.NguoiGiaoDich_DienThoaiDD = item.NguoiGiaoDich_DienThoaiDD;							
				dbitem.NguoiGiaoDich_Email = item.NguoiGiaoDich_Email;							
				dbitem.JSON_CacCoQuan = item.JSON_CacCoQuan;							
				dbitem.QuyChe_TreEm = item.QuyChe_TreEm;							
				dbitem.QuyChe_NguoiQuanHeLeThuoc = item.QuyChe_NguoiQuanHeLeThuoc;							
				dbitem.QuyChe_PhongXa = item.QuyChe_PhongXa;							
				dbitem.QuyChe_PhacDoDieuTri = item.QuyChe_PhacDoDieuTri;							
				dbitem.QuyChe_GienNguoi = item.QuyChe_GienNguoi;							
				dbitem.QuyChe_NguoiTonThuongThanKinh = item.QuyChe_NguoiTonThuongThanKinh;							
				dbitem.QuyChe_CacTapTheNhomNguoi = item.QuyChe_CacTapTheNhomNguoi;							
				dbitem.QuyChe_NghienCuuDichTeHoc = item.QuyChe_NghienCuuDichTeHoc;							
				dbitem.QuyChe_NguoiCanChamSocYTe = item.QuyChe_NguoiCanChamSocYTe;							
				dbitem.QuyChe_NguoiDanToc = item.QuyChe_NguoiDanToc;							
				dbitem.QuyChe_ThuNghiemLamSang = item.QuyChe_ThuNghiemLamSang;							
				dbitem.QuyChe_SuDungMauMoNguoi = item.QuyChe_SuDungMauMoNguoi;							
				dbitem.ThongTinNguonTaiTro = item.ThongTinNguonTaiTro;							
				dbitem.ThongTinNCYSHSinhVien = item.ThongTinNCYSHSinhVien;							
				dbitem.QuyTrinh_MoTaDuAn = item.QuyTrinh_MoTaDuAn;							
				dbitem.QuyTrinh_QuyTrinhThucHien = item.QuyTrinh_QuyTrinhThucHien;							
				dbitem.QuyTrinh_MucDich = item.QuyTrinh_MucDich;							
				dbitem.QuyTrinh_VanDeLienQuan = item.QuyTrinh_VanDeLienQuan;							
				dbitem.QuyTrinh_DiaDiemNghienCuu = item.QuyTrinh_DiaDiemNghienCuu;							
				dbitem.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia = item.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia;							
				dbitem.NguyCoTiemTang_NhomNghienCuu = item.NguyCoTiemTang_NhomNghienCuu;							
				dbitem.NguyCoTiemTang_NguoiThamGia = item.NguyCoTiemTang_NguoiThamGia;							
				dbitem.NguyCoTiemTang_CongDongCuaTruong = item.NguyCoTiemTang_CongDongCuaTruong;							
				dbitem.NguyCoTiemTang_CongDongLonHon = item.NguyCoTiemTang_CongDongLonHon;							
				dbitem.NguyCoTiemTang_SoSanhRuiRo = item.NguyCoTiemTang_SoSanhRuiRo;							
				dbitem.NguyCoTiemTang_QuyTrinhGiamRuiRo = item.NguyCoTiemTang_QuyTrinhGiamRuiRo;							
				dbitem.NguyCoTiemTang_CachXuLyRuiRo = item.NguyCoTiemTang_CachXuLyRuiRo;							
				dbitem.LoiIchTiemTang_NhungLoiIch = item.LoiIchTiemTang_NhungLoiIch;							
				dbitem.LoiIchTiemTang_AiDuocLoi = item.LoiIchTiemTang_AiDuocLoi;							
				dbitem.LoiIchTiemTang_DongGopKhoaHoc = item.LoiIchTiemTang_DongGopKhoaHoc;							
				dbitem.LoiIchTiemTang_SoSanh = item.LoiIchTiemTang_SoSanh;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_PhieuXemXetDaoDuc", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_PhieuXemXetDaoDuc",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_PhieuXemXetDaoDuc post_PRO_PhieuXemXetDaoDuc(AppEntities db, DTO_PRO_PhieuXemXetDaoDuc item, string Username)
        {
            tbl_PRO_PhieuXemXetDaoDuc dbitem = new tbl_PRO_PhieuXemXetDaoDuc();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.MaSo = item.MaSo;							
				dbitem.NghienCuuDuocTaiTro = item.NghienCuuDuocTaiTro;							
				dbitem.XinPhepTapThe = item.XinPhepTapThe;							
				dbitem.KhongThuocNghienCuuNao = item.KhongThuocNghienCuuNao;							
				dbitem.NghienCuuHocVienSauDaiHoc = item.NghienCuuHocVienSauDaiHoc;							
				dbitem.DonXinTaiCapPhep = item.DonXinTaiCapPhep;							
				dbitem.NghienCuuCuaSinhVienDaiHoc = item.NghienCuuCuaSinhVienDaiHoc;							
				dbitem.SoGiayPhepCu = item.SoGiayPhepCu;							
				dbitem.TenNCSYH = item.TenNCSYH;							
				dbitem.JSON_CacNCV = item.JSON_CacNCV;							
				dbitem.DonViChuTri = item.DonViChuTri;							
				dbitem.NguoiGiaoDich_HoTen = item.NguoiGiaoDich_HoTen;							
				dbitem.NguoiGiaoDich_DiaChiGiaoDich = item.NguoiGiaoDich_DiaChiGiaoDich;							
				dbitem.NguoiGiaoDich_DienThoaiCQ = item.NguoiGiaoDich_DienThoaiCQ;							
				dbitem.NguoiGiaoDich_DienThoaiFx = item.NguoiGiaoDich_DienThoaiFx;							
				dbitem.NguoiGiaoDich_DienThoaiNR = item.NguoiGiaoDich_DienThoaiNR;							
				dbitem.NguoiGiaoDich_DienThoaiDD = item.NguoiGiaoDich_DienThoaiDD;							
				dbitem.NguoiGiaoDich_Email = item.NguoiGiaoDich_Email;							
				dbitem.JSON_CacCoQuan = item.JSON_CacCoQuan;							
				dbitem.QuyChe_TreEm = item.QuyChe_TreEm;							
				dbitem.QuyChe_NguoiQuanHeLeThuoc = item.QuyChe_NguoiQuanHeLeThuoc;							
				dbitem.QuyChe_PhongXa = item.QuyChe_PhongXa;							
				dbitem.QuyChe_PhacDoDieuTri = item.QuyChe_PhacDoDieuTri;							
				dbitem.QuyChe_GienNguoi = item.QuyChe_GienNguoi;							
				dbitem.QuyChe_NguoiTonThuongThanKinh = item.QuyChe_NguoiTonThuongThanKinh;							
				dbitem.QuyChe_CacTapTheNhomNguoi = item.QuyChe_CacTapTheNhomNguoi;							
				dbitem.QuyChe_NghienCuuDichTeHoc = item.QuyChe_NghienCuuDichTeHoc;							
				dbitem.QuyChe_NguoiCanChamSocYTe = item.QuyChe_NguoiCanChamSocYTe;							
				dbitem.QuyChe_NguoiDanToc = item.QuyChe_NguoiDanToc;							
				dbitem.QuyChe_ThuNghiemLamSang = item.QuyChe_ThuNghiemLamSang;							
				dbitem.QuyChe_SuDungMauMoNguoi = item.QuyChe_SuDungMauMoNguoi;							
				dbitem.ThongTinNguonTaiTro = item.ThongTinNguonTaiTro;							
				dbitem.ThongTinNCYSHSinhVien = item.ThongTinNCYSHSinhVien;							
				dbitem.QuyTrinh_MoTaDuAn = item.QuyTrinh_MoTaDuAn;							
				dbitem.QuyTrinh_QuyTrinhThucHien = item.QuyTrinh_QuyTrinhThucHien;							
				dbitem.QuyTrinh_MucDich = item.QuyTrinh_MucDich;							
				dbitem.QuyTrinh_VanDeLienQuan = item.QuyTrinh_VanDeLienQuan;							
				dbitem.QuyTrinh_DiaDiemNghienCuu = item.QuyTrinh_DiaDiemNghienCuu;							
				dbitem.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia = item.QuyTrinh_NghienCuuTaiNoiLamViecNguoiThamGia;							
				dbitem.NguyCoTiemTang_NhomNghienCuu = item.NguyCoTiemTang_NhomNghienCuu;							
				dbitem.NguyCoTiemTang_NguoiThamGia = item.NguyCoTiemTang_NguoiThamGia;							
				dbitem.NguyCoTiemTang_CongDongCuaTruong = item.NguyCoTiemTang_CongDongCuaTruong;							
				dbitem.NguyCoTiemTang_CongDongLonHon = item.NguyCoTiemTang_CongDongLonHon;							
				dbitem.NguyCoTiemTang_SoSanhRuiRo = item.NguyCoTiemTang_SoSanhRuiRo;							
				dbitem.NguyCoTiemTang_QuyTrinhGiamRuiRo = item.NguyCoTiemTang_QuyTrinhGiamRuiRo;							
				dbitem.NguyCoTiemTang_CachXuLyRuiRo = item.NguyCoTiemTang_CachXuLyRuiRo;							
				dbitem.LoiIchTiemTang_NhungLoiIch = item.LoiIchTiemTang_NhungLoiIch;							
				dbitem.LoiIchTiemTang_AiDuocLoi = item.LoiIchTiemTang_AiDuocLoi;							
				dbitem.LoiIchTiemTang_DongGopKhoaHoc = item.LoiIchTiemTang_DongGopKhoaHoc;							
				dbitem.LoiIchTiemTang_SoSanh = item.LoiIchTiemTang_SoSanh;							
				dbitem.HTML = item.HTML;							
				dbitem.IsDisabled = item.IsDisabled;							
				dbitem.IsDeleted = item.IsDeleted;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_PhieuXemXetDaoDuc.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_PhieuXemXetDaoDuc", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_PhieuXemXetDaoDuc",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_PhieuXemXetDaoDuc(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_PhieuXemXetDaoDuc.Find(ID);
            if (dbitem != null)
            {
							
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				dbitem.IsDeleted = true;
							                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_PhieuXemXetDaoDuc", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_PhieuXemXetDaoDuc",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_PhieuXemXetDaoDuc_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_PhieuXemXetDaoDuc.Any(e => e.ID == id);
		}
		
    }

}






