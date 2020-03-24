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
    
    
    public partial class tbl_PRO_BangKhaiNhanSu
    {
        public int ID { get; set; }
        public int IDDeTai { get; set; }
        public string YTuong_NguoiThucHien { get; set; }
        public Nullable<decimal> YTuong_ChiPhi { get; set; }
        public string PhuongPhap_NguoiThucHien { get; set; }
        public Nullable<decimal> PhuongPhap_ChiPhi { get; set; }
        public string QuyTrinhNhanMau_NguoiThucHien { get; set; }
        public Nullable<decimal> QuyTrinhNhanMau_ChiPhi { get; set; }
        public string ThucHienNhanMau_NguoiThucHien { get; set; }
        public Nullable<decimal> ThucHienNhanMau_ChiPhi { get; set; }
        public string NhapDuLieuVaoPM_NguoiThucHien { get; set; }
        public Nullable<decimal> NhapDuLieuVaoPM_ChiPhi { get; set; }
        public string VietBaiBaoCaoTiengViet_NguoiThucHien { get; set; }
        public Nullable<decimal> VietBaiBaoCaoTiengViet_ChiPhi { get; set; }
        public string VietBaiBaoCaoTiengAnh_NguoiThucHien { get; set; }
        public Nullable<decimal> VietBaiBaoCaoTiengAnh_ChiPhi { get; set; }
        public string ReviewTinhKhaThi_NguoiThucHien { get; set; }
        public Nullable<decimal> ReviewTinhKhaThi_ChiPhi { get; set; }
        public string XayDungPhanMem_NguoiThucHien { get; set; }
        public Nullable<decimal> XayDungPhanMem_ChiPhi { get; set; }
        public string XayDungKeHoachPhanTich_NguoiThucHien { get; set; }
        public Nullable<decimal> XayDungKeHoachPhanTich_ChiPhi { get; set; }
        public string LamSachSoLieu_NguoiThucHien { get; set; }
        public Nullable<decimal> LamSachSoLieu_ChiPhi { get; set; }
        public string PhanTichSoLieu_NguoiThucHien { get; set; }
        public Nullable<decimal> PhanTichSoLieu_ChiPhi { get; set; }
        public string XayDungKeHoachDieuPhoi_NguoiThucHien { get; set; }
        public Nullable<decimal> XayDungKeHoachDieuPhoi_ChiPhi { get; set; }
        public string ChuanBiHoSoGiayTo_NguoiThucHien { get; set; }
        public Nullable<decimal> ChuanBiHoSoGiayTo_ChiPhi { get; set; }
        public string DieuPhoiHoatDongNghienCuu_NguoiThucHien { get; set; }
        public Nullable<decimal> DieuPhoiHoatDongNghienCuu_ChiPhi { get; set; }
        public string QuanLyDieuHanhChung_NguoiThucHien { get; set; }
        public Nullable<decimal> QuanLyDieuHanhChung_ChiPhi { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string FormConfig { get; set; }
        public virtual tbl_PRO_DeTai tbl_PRO_DeTai { get; set; }
    }
}
namespace DTOModel
{
	using System;
	public partial class DTO_PRO_BangKhaiNhanSu
	{
		public int ID { get; set; }
		public int IDDeTai { get; set; }
		public string YTuong_NguoiThucHien { get; set; }
		public Nullable<decimal> YTuong_ChiPhi { get; set; }
		public string PhuongPhap_NguoiThucHien { get; set; }
		public Nullable<decimal> PhuongPhap_ChiPhi { get; set; }
		public string QuyTrinhNhanMau_NguoiThucHien { get; set; }
		public Nullable<decimal> QuyTrinhNhanMau_ChiPhi { get; set; }
		public string ThucHienNhanMau_NguoiThucHien { get; set; }
		public Nullable<decimal> ThucHienNhanMau_ChiPhi { get; set; }
		public string NhapDuLieuVaoPM_NguoiThucHien { get; set; }
		public Nullable<decimal> NhapDuLieuVaoPM_ChiPhi { get; set; }
		public string VietBaiBaoCaoTiengViet_NguoiThucHien { get; set; }
		public Nullable<decimal> VietBaiBaoCaoTiengViet_ChiPhi { get; set; }
		public string VietBaiBaoCaoTiengAnh_NguoiThucHien { get; set; }
		public Nullable<decimal> VietBaiBaoCaoTiengAnh_ChiPhi { get; set; }
		public string ReviewTinhKhaThi_NguoiThucHien { get; set; }
		public Nullable<decimal> ReviewTinhKhaThi_ChiPhi { get; set; }
		public string XayDungPhanMem_NguoiThucHien { get; set; }
		public Nullable<decimal> XayDungPhanMem_ChiPhi { get; set; }
		public string XayDungKeHoachPhanTich_NguoiThucHien { get; set; }
		public Nullable<decimal> XayDungKeHoachPhanTich_ChiPhi { get; set; }
		public string LamSachSoLieu_NguoiThucHien { get; set; }
		public Nullable<decimal> LamSachSoLieu_ChiPhi { get; set; }
		public string PhanTichSoLieu_NguoiThucHien { get; set; }
		public Nullable<decimal> PhanTichSoLieu_ChiPhi { get; set; }
		public string XayDungKeHoachDieuPhoi_NguoiThucHien { get; set; }
		public Nullable<decimal> XayDungKeHoachDieuPhoi_ChiPhi { get; set; }
		public string ChuanBiHoSoGiayTo_NguoiThucHien { get; set; }
		public Nullable<decimal> ChuanBiHoSoGiayTo_ChiPhi { get; set; }
		public string DieuPhoiHoatDongNghienCuu_NguoiThucHien { get; set; }
		public Nullable<decimal> DieuPhoiHoatDongNghienCuu_ChiPhi { get; set; }
		public string QuanLyDieuHanhChung_NguoiThucHien { get; set; }
		public Nullable<decimal> QuanLyDieuHanhChung_ChiPhi { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public string CreatedBy { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
		public string ModifiedBy { get; set; }
		public string FormConfig { get; set; }
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

    public static partial class BS_PRO_BangKhaiNhanSu 
    {
		public static IQueryable<DTO_PRO_BangKhaiNhanSu> toDTO(IQueryable<tbl_PRO_BangKhaiNhanSu> query)
        {
			return query
			.Select(s => new DTO_PRO_BangKhaiNhanSu(){							
				ID = s.ID,							
				IDDeTai = s.IDDeTai,							
				YTuong_NguoiThucHien = s.YTuong_NguoiThucHien,							
				YTuong_ChiPhi = s.YTuong_ChiPhi,							
				PhuongPhap_NguoiThucHien = s.PhuongPhap_NguoiThucHien,							
				PhuongPhap_ChiPhi = s.PhuongPhap_ChiPhi,							
				QuyTrinhNhanMau_NguoiThucHien = s.QuyTrinhNhanMau_NguoiThucHien,							
				QuyTrinhNhanMau_ChiPhi = s.QuyTrinhNhanMau_ChiPhi,							
				ThucHienNhanMau_NguoiThucHien = s.ThucHienNhanMau_NguoiThucHien,							
				ThucHienNhanMau_ChiPhi = s.ThucHienNhanMau_ChiPhi,							
				NhapDuLieuVaoPM_NguoiThucHien = s.NhapDuLieuVaoPM_NguoiThucHien,							
				NhapDuLieuVaoPM_ChiPhi = s.NhapDuLieuVaoPM_ChiPhi,							
				VietBaiBaoCaoTiengViet_NguoiThucHien = s.VietBaiBaoCaoTiengViet_NguoiThucHien,							
				VietBaiBaoCaoTiengViet_ChiPhi = s.VietBaiBaoCaoTiengViet_ChiPhi,							
				VietBaiBaoCaoTiengAnh_NguoiThucHien = s.VietBaiBaoCaoTiengAnh_NguoiThucHien,							
				VietBaiBaoCaoTiengAnh_ChiPhi = s.VietBaiBaoCaoTiengAnh_ChiPhi,							
				ReviewTinhKhaThi_NguoiThucHien = s.ReviewTinhKhaThi_NguoiThucHien,							
				ReviewTinhKhaThi_ChiPhi = s.ReviewTinhKhaThi_ChiPhi,							
				XayDungPhanMem_NguoiThucHien = s.XayDungPhanMem_NguoiThucHien,							
				XayDungPhanMem_ChiPhi = s.XayDungPhanMem_ChiPhi,							
				XayDungKeHoachPhanTich_NguoiThucHien = s.XayDungKeHoachPhanTich_NguoiThucHien,							
				XayDungKeHoachPhanTich_ChiPhi = s.XayDungKeHoachPhanTich_ChiPhi,							
				LamSachSoLieu_NguoiThucHien = s.LamSachSoLieu_NguoiThucHien,							
				LamSachSoLieu_ChiPhi = s.LamSachSoLieu_ChiPhi,							
				PhanTichSoLieu_NguoiThucHien = s.PhanTichSoLieu_NguoiThucHien,							
				PhanTichSoLieu_ChiPhi = s.PhanTichSoLieu_ChiPhi,							
				XayDungKeHoachDieuPhoi_NguoiThucHien = s.XayDungKeHoachDieuPhoi_NguoiThucHien,							
				XayDungKeHoachDieuPhoi_ChiPhi = s.XayDungKeHoachDieuPhoi_ChiPhi,							
				ChuanBiHoSoGiayTo_NguoiThucHien = s.ChuanBiHoSoGiayTo_NguoiThucHien,							
				ChuanBiHoSoGiayTo_ChiPhi = s.ChuanBiHoSoGiayTo_ChiPhi,							
				DieuPhoiHoatDongNghienCuu_NguoiThucHien = s.DieuPhoiHoatDongNghienCuu_NguoiThucHien,							
				DieuPhoiHoatDongNghienCuu_ChiPhi = s.DieuPhoiHoatDongNghienCuu_ChiPhi,							
				QuanLyDieuHanhChung_NguoiThucHien = s.QuanLyDieuHanhChung_NguoiThucHien,							
				QuanLyDieuHanhChung_ChiPhi = s.QuanLyDieuHanhChung_ChiPhi,							
				CreatedDate = s.CreatedDate,							
				CreatedBy = s.CreatedBy,							
				ModifiedDate = s.ModifiedDate,							
				ModifiedBy = s.ModifiedBy,							
				FormConfig = s.FormConfig,					
			});
                              
        }

		public static DTO_PRO_BangKhaiNhanSu toDTO(tbl_PRO_BangKhaiNhanSu dbResult)
        {
			if (dbResult != null)
			{
				return new DTO_PRO_BangKhaiNhanSu()
				{							
					ID = dbResult.ID,							
					IDDeTai = dbResult.IDDeTai,							
					YTuong_NguoiThucHien = dbResult.YTuong_NguoiThucHien,							
					YTuong_ChiPhi = dbResult.YTuong_ChiPhi,							
					PhuongPhap_NguoiThucHien = dbResult.PhuongPhap_NguoiThucHien,							
					PhuongPhap_ChiPhi = dbResult.PhuongPhap_ChiPhi,							
					QuyTrinhNhanMau_NguoiThucHien = dbResult.QuyTrinhNhanMau_NguoiThucHien,							
					QuyTrinhNhanMau_ChiPhi = dbResult.QuyTrinhNhanMau_ChiPhi,							
					ThucHienNhanMau_NguoiThucHien = dbResult.ThucHienNhanMau_NguoiThucHien,							
					ThucHienNhanMau_ChiPhi = dbResult.ThucHienNhanMau_ChiPhi,							
					NhapDuLieuVaoPM_NguoiThucHien = dbResult.NhapDuLieuVaoPM_NguoiThucHien,							
					NhapDuLieuVaoPM_ChiPhi = dbResult.NhapDuLieuVaoPM_ChiPhi,							
					VietBaiBaoCaoTiengViet_NguoiThucHien = dbResult.VietBaiBaoCaoTiengViet_NguoiThucHien,							
					VietBaiBaoCaoTiengViet_ChiPhi = dbResult.VietBaiBaoCaoTiengViet_ChiPhi,							
					VietBaiBaoCaoTiengAnh_NguoiThucHien = dbResult.VietBaiBaoCaoTiengAnh_NguoiThucHien,							
					VietBaiBaoCaoTiengAnh_ChiPhi = dbResult.VietBaiBaoCaoTiengAnh_ChiPhi,							
					ReviewTinhKhaThi_NguoiThucHien = dbResult.ReviewTinhKhaThi_NguoiThucHien,							
					ReviewTinhKhaThi_ChiPhi = dbResult.ReviewTinhKhaThi_ChiPhi,							
					XayDungPhanMem_NguoiThucHien = dbResult.XayDungPhanMem_NguoiThucHien,							
					XayDungPhanMem_ChiPhi = dbResult.XayDungPhanMem_ChiPhi,							
					XayDungKeHoachPhanTich_NguoiThucHien = dbResult.XayDungKeHoachPhanTich_NguoiThucHien,							
					XayDungKeHoachPhanTich_ChiPhi = dbResult.XayDungKeHoachPhanTich_ChiPhi,							
					LamSachSoLieu_NguoiThucHien = dbResult.LamSachSoLieu_NguoiThucHien,							
					LamSachSoLieu_ChiPhi = dbResult.LamSachSoLieu_ChiPhi,							
					PhanTichSoLieu_NguoiThucHien = dbResult.PhanTichSoLieu_NguoiThucHien,							
					PhanTichSoLieu_ChiPhi = dbResult.PhanTichSoLieu_ChiPhi,							
					XayDungKeHoachDieuPhoi_NguoiThucHien = dbResult.XayDungKeHoachDieuPhoi_NguoiThucHien,							
					XayDungKeHoachDieuPhoi_ChiPhi = dbResult.XayDungKeHoachDieuPhoi_ChiPhi,							
					ChuanBiHoSoGiayTo_NguoiThucHien = dbResult.ChuanBiHoSoGiayTo_NguoiThucHien,							
					ChuanBiHoSoGiayTo_ChiPhi = dbResult.ChuanBiHoSoGiayTo_ChiPhi,							
					DieuPhoiHoatDongNghienCuu_NguoiThucHien = dbResult.DieuPhoiHoatDongNghienCuu_NguoiThucHien,							
					DieuPhoiHoatDongNghienCuu_ChiPhi = dbResult.DieuPhoiHoatDongNghienCuu_ChiPhi,							
					QuanLyDieuHanhChung_NguoiThucHien = dbResult.QuanLyDieuHanhChung_NguoiThucHien,							
					QuanLyDieuHanhChung_ChiPhi = dbResult.QuanLyDieuHanhChung_ChiPhi,							
					CreatedDate = dbResult.CreatedDate,							
					CreatedBy = dbResult.CreatedBy,							
					ModifiedDate = dbResult.ModifiedDate,							
					ModifiedBy = dbResult.ModifiedBy,							
					FormConfig = dbResult.FormConfig,
				};
			}
			else
				return null; 
        }

        public static IQueryable<DTO_PRO_BangKhaiNhanSu> get_PRO_BangKhaiNhanSu(AppEntities db, Dictionary<string, string> QueryStrings)
        {
			var query = db.tbl_PRO_BangKhaiNhanSu.AsQueryable();

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

			//Query YTuong_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "YTuong_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "YTuong_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "YTuong_NguoiThucHien").Value;
                query = query.Where(d=>d.YTuong_NguoiThucHien == keyword);
            }

			//Query YTuong_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "YTuong_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "YTuong_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "YTuong_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "YTuong_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.YTuong_ChiPhi && d.YTuong_ChiPhi <= toVal);

			//Query PhuongPhap_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "PhuongPhap_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhuongPhap_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhuongPhap_NguoiThucHien").Value;
                query = query.Where(d=>d.PhuongPhap_NguoiThucHien == keyword);
            }

			//Query PhuongPhap_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "PhuongPhap_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "PhuongPhap_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "PhuongPhap_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "PhuongPhap_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.PhuongPhap_ChiPhi && d.PhuongPhap_ChiPhi <= toVal);

			//Query QuyTrinhNhanMau_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "QuyTrinhNhanMau_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinhNhanMau_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinhNhanMau_NguoiThucHien").Value;
                query = query.Where(d=>d.QuyTrinhNhanMau_NguoiThucHien == keyword);
            }

			//Query QuyTrinhNhanMau_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "QuyTrinhNhanMau_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "QuyTrinhNhanMau_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinhNhanMau_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "QuyTrinhNhanMau_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.QuyTrinhNhanMau_ChiPhi && d.QuyTrinhNhanMau_ChiPhi <= toVal);

			//Query ThucHienNhanMau_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "ThucHienNhanMau_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ThucHienNhanMau_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ThucHienNhanMau_NguoiThucHien").Value;
                query = query.Where(d=>d.ThucHienNhanMau_NguoiThucHien == keyword);
            }

			//Query ThucHienNhanMau_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "ThucHienNhanMau_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "ThucHienNhanMau_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThucHienNhanMau_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ThucHienNhanMau_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.ThucHienNhanMau_ChiPhi && d.ThucHienNhanMau_ChiPhi <= toVal);

			//Query NhapDuLieuVaoPM_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "NhapDuLieuVaoPM_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "NhapDuLieuVaoPM_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "NhapDuLieuVaoPM_NguoiThucHien").Value;
                query = query.Where(d=>d.NhapDuLieuVaoPM_NguoiThucHien == keyword);
            }

			//Query NhapDuLieuVaoPM_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "NhapDuLieuVaoPM_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "NhapDuLieuVaoPM_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NhapDuLieuVaoPM_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "NhapDuLieuVaoPM_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.NhapDuLieuVaoPM_ChiPhi && d.NhapDuLieuVaoPM_ChiPhi <= toVal);

			//Query VietBaiBaoCaoTiengViet_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "VietBaiBaoCaoTiengViet_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "VietBaiBaoCaoTiengViet_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "VietBaiBaoCaoTiengViet_NguoiThucHien").Value;
                query = query.Where(d=>d.VietBaiBaoCaoTiengViet_NguoiThucHien == keyword);
            }

			//Query VietBaiBaoCaoTiengViet_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "VietBaiBaoCaoTiengViet_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "VietBaiBaoCaoTiengViet_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "VietBaiBaoCaoTiengViet_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "VietBaiBaoCaoTiengViet_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.VietBaiBaoCaoTiengViet_ChiPhi && d.VietBaiBaoCaoTiengViet_ChiPhi <= toVal);

			//Query VietBaiBaoCaoTiengAnh_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "VietBaiBaoCaoTiengAnh_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "VietBaiBaoCaoTiengAnh_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "VietBaiBaoCaoTiengAnh_NguoiThucHien").Value;
                query = query.Where(d=>d.VietBaiBaoCaoTiengAnh_NguoiThucHien == keyword);
            }

			//Query VietBaiBaoCaoTiengAnh_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "VietBaiBaoCaoTiengAnh_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "VietBaiBaoCaoTiengAnh_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "VietBaiBaoCaoTiengAnh_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "VietBaiBaoCaoTiengAnh_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.VietBaiBaoCaoTiengAnh_ChiPhi && d.VietBaiBaoCaoTiengAnh_ChiPhi <= toVal);

			//Query ReviewTinhKhaThi_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "ReviewTinhKhaThi_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ReviewTinhKhaThi_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ReviewTinhKhaThi_NguoiThucHien").Value;
                query = query.Where(d=>d.ReviewTinhKhaThi_NguoiThucHien == keyword);
            }

			//Query ReviewTinhKhaThi_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "ReviewTinhKhaThi_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "ReviewTinhKhaThi_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ReviewTinhKhaThi_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ReviewTinhKhaThi_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.ReviewTinhKhaThi_ChiPhi && d.ReviewTinhKhaThi_ChiPhi <= toVal);

			//Query XayDungPhanMem_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "XayDungPhanMem_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "XayDungPhanMem_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "XayDungPhanMem_NguoiThucHien").Value;
                query = query.Where(d=>d.XayDungPhanMem_NguoiThucHien == keyword);
            }

			//Query XayDungPhanMem_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "XayDungPhanMem_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "XayDungPhanMem_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "XayDungPhanMem_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "XayDungPhanMem_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.XayDungPhanMem_ChiPhi && d.XayDungPhanMem_ChiPhi <= toVal);

			//Query XayDungKeHoachPhanTich_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "XayDungKeHoachPhanTich_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "XayDungKeHoachPhanTich_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "XayDungKeHoachPhanTich_NguoiThucHien").Value;
                query = query.Where(d=>d.XayDungKeHoachPhanTich_NguoiThucHien == keyword);
            }

			//Query XayDungKeHoachPhanTich_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "XayDungKeHoachPhanTich_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "XayDungKeHoachPhanTich_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "XayDungKeHoachPhanTich_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "XayDungKeHoachPhanTich_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.XayDungKeHoachPhanTich_ChiPhi && d.XayDungKeHoachPhanTich_ChiPhi <= toVal);

			//Query LamSachSoLieu_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "LamSachSoLieu_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "LamSachSoLieu_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "LamSachSoLieu_NguoiThucHien").Value;
                query = query.Where(d=>d.LamSachSoLieu_NguoiThucHien == keyword);
            }

			//Query LamSachSoLieu_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "LamSachSoLieu_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "LamSachSoLieu_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "LamSachSoLieu_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "LamSachSoLieu_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.LamSachSoLieu_ChiPhi && d.LamSachSoLieu_ChiPhi <= toVal);

			//Query PhanTichSoLieu_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "PhanTichSoLieu_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "PhanTichSoLieu_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "PhanTichSoLieu_NguoiThucHien").Value;
                query = query.Where(d=>d.PhanTichSoLieu_NguoiThucHien == keyword);
            }

			//Query PhanTichSoLieu_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "PhanTichSoLieu_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "PhanTichSoLieu_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "PhanTichSoLieu_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "PhanTichSoLieu_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.PhanTichSoLieu_ChiPhi && d.PhanTichSoLieu_ChiPhi <= toVal);

			//Query XayDungKeHoachDieuPhoi_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "XayDungKeHoachDieuPhoi_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "XayDungKeHoachDieuPhoi_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "XayDungKeHoachDieuPhoi_NguoiThucHien").Value;
                query = query.Where(d=>d.XayDungKeHoachDieuPhoi_NguoiThucHien == keyword);
            }

			//Query XayDungKeHoachDieuPhoi_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "XayDungKeHoachDieuPhoi_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "XayDungKeHoachDieuPhoi_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "XayDungKeHoachDieuPhoi_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "XayDungKeHoachDieuPhoi_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.XayDungKeHoachDieuPhoi_ChiPhi && d.XayDungKeHoachDieuPhoi_ChiPhi <= toVal);

			//Query ChuanBiHoSoGiayTo_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "ChuanBiHoSoGiayTo_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "ChuanBiHoSoGiayTo_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "ChuanBiHoSoGiayTo_NguoiThucHien").Value;
                query = query.Where(d=>d.ChuanBiHoSoGiayTo_NguoiThucHien == keyword);
            }

			//Query ChuanBiHoSoGiayTo_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "ChuanBiHoSoGiayTo_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "ChuanBiHoSoGiayTo_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ChuanBiHoSoGiayTo_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "ChuanBiHoSoGiayTo_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.ChuanBiHoSoGiayTo_ChiPhi && d.ChuanBiHoSoGiayTo_ChiPhi <= toVal);

			//Query DieuPhoiHoatDongNghienCuu_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "DieuPhoiHoatDongNghienCuu_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "DieuPhoiHoatDongNghienCuu_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "DieuPhoiHoatDongNghienCuu_NguoiThucHien").Value;
                query = query.Where(d=>d.DieuPhoiHoatDongNghienCuu_NguoiThucHien == keyword);
            }

			//Query DieuPhoiHoatDongNghienCuu_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "DieuPhoiHoatDongNghienCuu_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "DieuPhoiHoatDongNghienCuu_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "DieuPhoiHoatDongNghienCuu_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "DieuPhoiHoatDongNghienCuu_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.DieuPhoiHoatDongNghienCuu_ChiPhi && d.DieuPhoiHoatDongNghienCuu_ChiPhi <= toVal);

			//Query QuanLyDieuHanhChung_NguoiThucHien (string)
			if (QueryStrings.Any(d => d.Key == "QuanLyDieuHanhChung_NguoiThucHien") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDieuHanhChung_NguoiThucHien").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDieuHanhChung_NguoiThucHien").Value;
                query = query.Where(d=>d.QuanLyDieuHanhChung_NguoiThucHien == keyword);
            }

			//Query QuanLyDieuHanhChung_ChiPhi (Nullable<decimal>)
			if (QueryStrings.Any(d => d.Key == "QuanLyDieuHanhChung_ChiPhiFrom") && QueryStrings.Any(d => d.Key == "QuanLyDieuHanhChung_ChiPhiTo"))
                if (decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDieuHanhChung_ChiPhiFrom").Value, out decimal fromVal) && decimal.TryParse(QueryStrings.FirstOrDefault(d => d.Key == "QuanLyDieuHanhChung_ChiPhiTo").Value, out decimal toVal))
                    query = query.Where(d => fromVal <= d.QuanLyDieuHanhChung_ChiPhi && d.QuanLyDieuHanhChung_ChiPhi <= toVal);

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

			//Query FormConfig (string)
			if (QueryStrings.Any(d => d.Key == "FormConfig") && !string.IsNullOrEmpty(QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value))
            {
                var keyword = QueryStrings.FirstOrDefault(d => d.Key == "FormConfig").Value;
                query = query.Where(d=>d.FormConfig == keyword);
            }


			return toDTO(query);

        }

		public static DTO_PRO_BangKhaiNhanSu get_PRO_BangKhaiNhanSu(AppEntities db, int id)
        {
            var dbResult = db.tbl_PRO_BangKhaiNhanSu.Find(id);

			return toDTO(dbResult);
			
        }
		

		public static bool put_PRO_BangKhaiNhanSu(AppEntities db, int ID, DTO_PRO_BangKhaiNhanSu item, string Username)
        {
            bool result = false;
            var dbitem = db.tbl_PRO_BangKhaiNhanSu.Find(ID);
            if (dbitem != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.YTuong_NguoiThucHien = item.YTuong_NguoiThucHien;							
				dbitem.YTuong_ChiPhi = item.YTuong_ChiPhi;							
				dbitem.PhuongPhap_NguoiThucHien = item.PhuongPhap_NguoiThucHien;							
				dbitem.PhuongPhap_ChiPhi = item.PhuongPhap_ChiPhi;							
				dbitem.QuyTrinhNhanMau_NguoiThucHien = item.QuyTrinhNhanMau_NguoiThucHien;							
				dbitem.QuyTrinhNhanMau_ChiPhi = item.QuyTrinhNhanMau_ChiPhi;							
				dbitem.ThucHienNhanMau_NguoiThucHien = item.ThucHienNhanMau_NguoiThucHien;							
				dbitem.ThucHienNhanMau_ChiPhi = item.ThucHienNhanMau_ChiPhi;							
				dbitem.NhapDuLieuVaoPM_NguoiThucHien = item.NhapDuLieuVaoPM_NguoiThucHien;							
				dbitem.NhapDuLieuVaoPM_ChiPhi = item.NhapDuLieuVaoPM_ChiPhi;							
				dbitem.VietBaiBaoCaoTiengViet_NguoiThucHien = item.VietBaiBaoCaoTiengViet_NguoiThucHien;							
				dbitem.VietBaiBaoCaoTiengViet_ChiPhi = item.VietBaiBaoCaoTiengViet_ChiPhi;							
				dbitem.VietBaiBaoCaoTiengAnh_NguoiThucHien = item.VietBaiBaoCaoTiengAnh_NguoiThucHien;							
				dbitem.VietBaiBaoCaoTiengAnh_ChiPhi = item.VietBaiBaoCaoTiengAnh_ChiPhi;							
				dbitem.ReviewTinhKhaThi_NguoiThucHien = item.ReviewTinhKhaThi_NguoiThucHien;							
				dbitem.ReviewTinhKhaThi_ChiPhi = item.ReviewTinhKhaThi_ChiPhi;							
				dbitem.XayDungPhanMem_NguoiThucHien = item.XayDungPhanMem_NguoiThucHien;							
				dbitem.XayDungPhanMem_ChiPhi = item.XayDungPhanMem_ChiPhi;							
				dbitem.XayDungKeHoachPhanTich_NguoiThucHien = item.XayDungKeHoachPhanTich_NguoiThucHien;							
				dbitem.XayDungKeHoachPhanTich_ChiPhi = item.XayDungKeHoachPhanTich_ChiPhi;							
				dbitem.LamSachSoLieu_NguoiThucHien = item.LamSachSoLieu_NguoiThucHien;							
				dbitem.LamSachSoLieu_ChiPhi = item.LamSachSoLieu_ChiPhi;							
				dbitem.PhanTichSoLieu_NguoiThucHien = item.PhanTichSoLieu_NguoiThucHien;							
				dbitem.PhanTichSoLieu_ChiPhi = item.PhanTichSoLieu_ChiPhi;							
				dbitem.XayDungKeHoachDieuPhoi_NguoiThucHien = item.XayDungKeHoachDieuPhoi_NguoiThucHien;							
				dbitem.XayDungKeHoachDieuPhoi_ChiPhi = item.XayDungKeHoachDieuPhoi_ChiPhi;							
				dbitem.ChuanBiHoSoGiayTo_NguoiThucHien = item.ChuanBiHoSoGiayTo_NguoiThucHien;							
				dbitem.ChuanBiHoSoGiayTo_ChiPhi = item.ChuanBiHoSoGiayTo_ChiPhi;							
				dbitem.DieuPhoiHoatDongNghienCuu_NguoiThucHien = item.DieuPhoiHoatDongNghienCuu_NguoiThucHien;							
				dbitem.DieuPhoiHoatDongNghienCuu_ChiPhi = item.DieuPhoiHoatDongNghienCuu_ChiPhi;							
				dbitem.QuanLyDieuHanhChung_NguoiThucHien = item.QuanLyDieuHanhChung_NguoiThucHien;							
				dbitem.QuanLyDieuHanhChung_ChiPhi = item.QuanLyDieuHanhChung_ChiPhi;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
				
                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BangKhaiNhanSu", DateTime.Now, Username);
									
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("put_PRO_BangKhaiNhanSu",e);
                    result = false;
                }
            }
            return result;
        }

		public static DTO_PRO_BangKhaiNhanSu post_PRO_BangKhaiNhanSu(AppEntities db, DTO_PRO_BangKhaiNhanSu item, string Username)
        {
            tbl_PRO_BangKhaiNhanSu dbitem = new tbl_PRO_BangKhaiNhanSu();
            if (item != null)
            {							
				dbitem.IDDeTai = item.IDDeTai;							
				dbitem.YTuong_NguoiThucHien = item.YTuong_NguoiThucHien;							
				dbitem.YTuong_ChiPhi = item.YTuong_ChiPhi;							
				dbitem.PhuongPhap_NguoiThucHien = item.PhuongPhap_NguoiThucHien;							
				dbitem.PhuongPhap_ChiPhi = item.PhuongPhap_ChiPhi;							
				dbitem.QuyTrinhNhanMau_NguoiThucHien = item.QuyTrinhNhanMau_NguoiThucHien;							
				dbitem.QuyTrinhNhanMau_ChiPhi = item.QuyTrinhNhanMau_ChiPhi;							
				dbitem.ThucHienNhanMau_NguoiThucHien = item.ThucHienNhanMau_NguoiThucHien;							
				dbitem.ThucHienNhanMau_ChiPhi = item.ThucHienNhanMau_ChiPhi;							
				dbitem.NhapDuLieuVaoPM_NguoiThucHien = item.NhapDuLieuVaoPM_NguoiThucHien;							
				dbitem.NhapDuLieuVaoPM_ChiPhi = item.NhapDuLieuVaoPM_ChiPhi;							
				dbitem.VietBaiBaoCaoTiengViet_NguoiThucHien = item.VietBaiBaoCaoTiengViet_NguoiThucHien;							
				dbitem.VietBaiBaoCaoTiengViet_ChiPhi = item.VietBaiBaoCaoTiengViet_ChiPhi;							
				dbitem.VietBaiBaoCaoTiengAnh_NguoiThucHien = item.VietBaiBaoCaoTiengAnh_NguoiThucHien;							
				dbitem.VietBaiBaoCaoTiengAnh_ChiPhi = item.VietBaiBaoCaoTiengAnh_ChiPhi;							
				dbitem.ReviewTinhKhaThi_NguoiThucHien = item.ReviewTinhKhaThi_NguoiThucHien;							
				dbitem.ReviewTinhKhaThi_ChiPhi = item.ReviewTinhKhaThi_ChiPhi;							
				dbitem.XayDungPhanMem_NguoiThucHien = item.XayDungPhanMem_NguoiThucHien;							
				dbitem.XayDungPhanMem_ChiPhi = item.XayDungPhanMem_ChiPhi;							
				dbitem.XayDungKeHoachPhanTich_NguoiThucHien = item.XayDungKeHoachPhanTich_NguoiThucHien;							
				dbitem.XayDungKeHoachPhanTich_ChiPhi = item.XayDungKeHoachPhanTich_ChiPhi;							
				dbitem.LamSachSoLieu_NguoiThucHien = item.LamSachSoLieu_NguoiThucHien;							
				dbitem.LamSachSoLieu_ChiPhi = item.LamSachSoLieu_ChiPhi;							
				dbitem.PhanTichSoLieu_NguoiThucHien = item.PhanTichSoLieu_NguoiThucHien;							
				dbitem.PhanTichSoLieu_ChiPhi = item.PhanTichSoLieu_ChiPhi;							
				dbitem.XayDungKeHoachDieuPhoi_NguoiThucHien = item.XayDungKeHoachDieuPhoi_NguoiThucHien;							
				dbitem.XayDungKeHoachDieuPhoi_ChiPhi = item.XayDungKeHoachDieuPhoi_ChiPhi;							
				dbitem.ChuanBiHoSoGiayTo_NguoiThucHien = item.ChuanBiHoSoGiayTo_NguoiThucHien;							
				dbitem.ChuanBiHoSoGiayTo_ChiPhi = item.ChuanBiHoSoGiayTo_ChiPhi;							
				dbitem.DieuPhoiHoatDongNghienCuu_NguoiThucHien = item.DieuPhoiHoatDongNghienCuu_NguoiThucHien;							
				dbitem.DieuPhoiHoatDongNghienCuu_ChiPhi = item.DieuPhoiHoatDongNghienCuu_ChiPhi;							
				dbitem.QuanLyDieuHanhChung_NguoiThucHien = item.QuanLyDieuHanhChung_NguoiThucHien;							
				dbitem.QuanLyDieuHanhChung_ChiPhi = item.QuanLyDieuHanhChung_ChiPhi;							
				dbitem.FormConfig = item.FormConfig;                
				
				dbitem.CreatedBy = Username;
				dbitem.CreatedDate = DateTime.Now;

				dbitem.ModifiedBy = Username;
				dbitem.ModifiedDate = DateTime.Now;
								

                try
                {
					db.tbl_PRO_BangKhaiNhanSu.Add(dbitem);
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BangKhaiNhanSu", DateTime.Now, Username);
														
					
                    item.ID =  dbitem.ID;
										
					item.CreatedBy = dbitem.CreatedBy;
					item.CreatedDate = dbitem.CreatedDate;

					item.ModifiedBy = dbitem.ModifiedBy;
					item.ModifiedDate = dbitem.ModifiedDate;
										
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("post_PRO_BangKhaiNhanSu",e);
                    item = null;
                }
            }
            return item;
        }

		public static bool delete_PRO_BangKhaiNhanSu(AppEntities db, int ID, string Username)
        {
			bool result = false;
            var dbitem = db.tbl_PRO_BangKhaiNhanSu.Find(ID);
            if (dbitem != null)
            {
			
				db.tbl_PRO_BangKhaiNhanSu.Remove(dbitem);
			                

                try
                {
                    db.SaveChanges();
				
					BS_CUS_Version.update_CUS_Version(db, null, "DTO_PRO_BangKhaiNhanSu", DateTime.Now, Username);
									
										
					
					result = true;
                }
                catch (DbEntityValidationException e)
                {
					errorLog.logMessage("delete_PRO_BangKhaiNhanSu",e);
                    result = false;
                }
            }
            return result;
        }

		
		public static bool check_PRO_BangKhaiNhanSu_Exists(AppEntities db, int id)
		{
			return db.tbl_PRO_BangKhaiNhanSu.Any(e => e.ID == id);
		}
		
    }

}






