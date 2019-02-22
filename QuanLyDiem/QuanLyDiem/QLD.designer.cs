﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDiem
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyDiem")]
	public partial class QLDDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public QLDDataContext() : 
				base(global::QuanLyDiem.Properties.Settings.Default.QuanLyDiemConnectionString4, mappingSource)
		{
			OnCreated();
		}
		
		public QLDDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLDDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLDDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLDDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BangDiemHP")]
		public ISingleResult<BangDiemHPResult> BangDiemHP([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string malop, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string mamon)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), malop, mamon);
			return ((ISingleResult<BangDiemHPResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteHK")]
		public int DeleteHK([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maHK)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maHK);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DiemHP_Updatelan1")]
		public int DiemHP_Updatelan1([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> diemlan1, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maMon, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maSV)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diemlan1, maMon, maSV);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DiemHP_Updatelan2")]
		public int DiemHP_Updatelan2([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> diemlan2, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maMon, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maSV)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diemlan2, maMon, maSV);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DiemHPInsert")]
		public int DiemHPInsert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maMon, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maSV)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maMon, maSV);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DiemHPSearch")]
		public ISingleResult<DiemHPSearchResult> DiemHPSearch([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maMon, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maSV)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maMon, maSV);
			return ((ISingleResult<DiemHPSearchResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetMonHoc")]
		public ISingleResult<GetMonHocResult> GetMonHoc()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetMonHocResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.HocKyAll")]
		public ISingleResult<HocKyAllResult> HocKyAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<HocKyAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertHK")]
		public int InsertHK([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maHK, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tenHK)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maHK, tenHK);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.LopAll")]
		public ISingleResult<LopAllResult> LopAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<LopAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.MonHPSelectMK")]
		public ISingleResult<MonHPSelectMKResult> MonHPSelectMK([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maHK)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maHK);
			return ((ISingleResult<MonHPSelectMKResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SinhvienSelectID")]
		public ISingleResult<SinhvienSelectIDResult> SinhvienSelectID([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maSV)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maSV);
			return ((ISingleResult<SinhvienSelectIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SinhvienSelectMaLop")]
		public ISingleResult<SinhvienSelectMaLopResult> SinhvienSelectMaLop([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string malop)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), malop);
			return ((ISingleResult<SinhvienSelectMaLopResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SinhVienSelectAll")]
		public ISingleResult<SinhVienSelectAllResult> SinhVienSelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SinhVienSelectAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SuaMonHoc")]
		public int SuaMonHoc([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maMon, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tenMon, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> soTC, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maHK)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maMon, tenMon, soTC, maHK);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ThemMonHoc")]
		public int ThemMonHoc([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maMon, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tenMon, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> soTC, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maHK)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maMon, tenMon, soTC, maHK);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateHK")]
		public int UpdateHK([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maHK, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tenHK)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maHK, tenHK);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.XoaMonHoc")]
		public int XoaMonHoc([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string maMon)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maMon);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class BangDiemHPResult
	{
		
		private string _MaSV;
		
		private string _TenSV;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private System.Nullable<double> _DiemHS1;
		
		private System.Nullable<double> _DiemHS2;
		
		public BangDiemHPResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this._MaSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSV", DbType="NVarChar(50)")]
		public string TenSV
		{
			get
			{
				return this._TenSV;
			}
			set
			{
				if ((this._TenSV != value))
				{
					this._TenSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this._NgaySinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemHS1", DbType="Float")]
		public System.Nullable<double> DiemHS1
		{
			get
			{
				return this._DiemHS1;
			}
			set
			{
				if ((this._DiemHS1 != value))
				{
					this._DiemHS1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemHS2", DbType="Float")]
		public System.Nullable<double> DiemHS2
		{
			get
			{
				return this._DiemHS2;
			}
			set
			{
				if ((this._DiemHS2 != value))
				{
					this._DiemHS2 = value;
				}
			}
		}
	}
	
	public partial class DiemHPSearchResult
	{
		
		private string _MaSV;
		
		private string _MaMon;
		
		private System.Nullable<double> _DiemHS1;
		
		private System.Nullable<double> _DiemHS2;
		
		public DiemHPSearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this._MaSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMon", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaMon
		{
			get
			{
				return this._MaMon;
			}
			set
			{
				if ((this._MaMon != value))
				{
					this._MaMon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemHS1", DbType="Float")]
		public System.Nullable<double> DiemHS1
		{
			get
			{
				return this._DiemHS1;
			}
			set
			{
				if ((this._DiemHS1 != value))
				{
					this._DiemHS1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemHS2", DbType="Float")]
		public System.Nullable<double> DiemHS2
		{
			get
			{
				return this._DiemHS2;
			}
			set
			{
				if ((this._DiemHS2 != value))
				{
					this._DiemHS2 = value;
				}
			}
		}
	}
	
	public partial class GetMonHocResult
	{
		
		private string _MaMon;
		
		private string _TenMon;
		
		private System.Nullable<int> _SoTC;
		
		private string _MaHK;
		
		public GetMonHocResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMon", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaMon
		{
			get
			{
				return this._MaMon;
			}
			set
			{
				if ((this._MaMon != value))
				{
					this._MaMon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMon", DbType="NVarChar(50)")]
		public string TenMon
		{
			get
			{
				return this._TenMon;
			}
			set
			{
				if ((this._TenMon != value))
				{
					this._TenMon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTC", DbType="Int")]
		public System.Nullable<int> SoTC
		{
			get
			{
				return this._SoTC;
			}
			set
			{
				if ((this._SoTC != value))
				{
					this._SoTC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHK", DbType="NVarChar(50)")]
		public string MaHK
		{
			get
			{
				return this._MaHK;
			}
			set
			{
				if ((this._MaHK != value))
				{
					this._MaHK = value;
				}
			}
		}
	}
	
	public partial class HocKyAllResult
	{
		
		private string _MaHK;
		
		private string _TenHK;
		
		public HocKyAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHK", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaHK
		{
			get
			{
				return this._MaHK;
			}
			set
			{
				if ((this._MaHK != value))
				{
					this._MaHK = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHK", DbType="NVarChar(50)")]
		public string TenHK
		{
			get
			{
				return this._TenHK;
			}
			set
			{
				if ((this._TenHK != value))
				{
					this._TenHK = value;
				}
			}
		}
	}
	
	public partial class LopAllResult
	{
		
		private string _MaLop;
		
		private string _TenLop;
		
		public LopAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this._MaLop = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLop", DbType="NVarChar(100)")]
		public string TenLop
		{
			get
			{
				return this._TenLop;
			}
			set
			{
				if ((this._TenLop != value))
				{
					this._TenLop = value;
				}
			}
		}
	}
	
	public partial class MonHPSelectMKResult
	{
		
		private string _MaMon;
		
		private string _TenMon;
		
		private System.Nullable<int> _SoTC;
		
		private string _MaHK;
		
		public MonHPSelectMKResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMon", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaMon
		{
			get
			{
				return this._MaMon;
			}
			set
			{
				if ((this._MaMon != value))
				{
					this._MaMon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMon", DbType="NVarChar(50)")]
		public string TenMon
		{
			get
			{
				return this._TenMon;
			}
			set
			{
				if ((this._TenMon != value))
				{
					this._TenMon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTC", DbType="Int")]
		public System.Nullable<int> SoTC
		{
			get
			{
				return this._SoTC;
			}
			set
			{
				if ((this._SoTC != value))
				{
					this._SoTC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHK", DbType="NVarChar(50)")]
		public string MaHK
		{
			get
			{
				return this._MaHK;
			}
			set
			{
				if ((this._MaHK != value))
				{
					this._MaHK = value;
				}
			}
		}
	}
	
	public partial class SinhvienSelectIDResult
	{
		
		private string _MaSV;
		
		private string _TenSV;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private System.Nullable<bool> _GioiTinh;
		
		private string _DanToc;
		
		private string _Diachi;
		
		private string _MaLop;
		
		public SinhvienSelectIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this._MaSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSV", DbType="NVarChar(50)")]
		public string TenSV
		{
			get
			{
				return this._TenSV;
			}
			set
			{
				if ((this._TenSV != value))
				{
					this._TenSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this._NgaySinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="Bit")]
		public System.Nullable<bool> GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this._GioiTinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DanToc", DbType="NVarChar(50)")]
		public string DanToc
		{
			get
			{
				return this._DanToc;
			}
			set
			{
				if ((this._DanToc != value))
				{
					this._DanToc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diachi", DbType="NVarChar(100)")]
		public string Diachi
		{
			get
			{
				return this._Diachi;
			}
			set
			{
				if ((this._Diachi != value))
				{
					this._Diachi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this._MaLop = value;
				}
			}
		}
	}
	
	public partial class SinhvienSelectMaLopResult
	{
		
		private string _MaSV;
		
		private string _TenSV;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private System.Nullable<bool> _GioiTinh;
		
		private string _DanToc;
		
		private string _Diachi;
		
		private string _MaLop;
		
		public SinhvienSelectMaLopResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this._MaSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSV", DbType="NVarChar(50)")]
		public string TenSV
		{
			get
			{
				return this._TenSV;
			}
			set
			{
				if ((this._TenSV != value))
				{
					this._TenSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this._NgaySinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="Bit")]
		public System.Nullable<bool> GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this._GioiTinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DanToc", DbType="NVarChar(50)")]
		public string DanToc
		{
			get
			{
				return this._DanToc;
			}
			set
			{
				if ((this._DanToc != value))
				{
					this._DanToc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diachi", DbType="NVarChar(100)")]
		public string Diachi
		{
			get
			{
				return this._Diachi;
			}
			set
			{
				if ((this._Diachi != value))
				{
					this._Diachi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this._MaLop = value;
				}
			}
		}
	}
	
	public partial class SinhVienSelectAllResult
	{
		
		private string _MaSV;
		
		private string _TenSV;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private System.Nullable<bool> _GioiTinh;
		
		private string _DanToc;
		
		private string _Diachi;
		
		private string _MaLop;
		
		public SinhVienSelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this._MaSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSV", DbType="NVarChar(50)")]
		public string TenSV
		{
			get
			{
				return this._TenSV;
			}
			set
			{
				if ((this._TenSV != value))
				{
					this._TenSV = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this._NgaySinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="Bit")]
		public System.Nullable<bool> GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this._GioiTinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DanToc", DbType="NVarChar(50)")]
		public string DanToc
		{
			get
			{
				return this._DanToc;
			}
			set
			{
				if ((this._DanToc != value))
				{
					this._DanToc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diachi", DbType="NVarChar(100)")]
		public string Diachi
		{
			get
			{
				return this._Diachi;
			}
			set
			{
				if ((this._Diachi != value))
				{
					this._Diachi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this._MaLop = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
