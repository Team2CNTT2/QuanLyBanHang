//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyHangHoa
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
            this.NHAPs = new HashSet<NHAP>();
            this.XUATs = new HashSet<XUAT>();
        }
    
        public int NHANVIENID { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public Nullable<int> GIOITINH { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> CHUCVUID { get; set; }
        public Nullable<int> PHONGBANID { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual PHONGBAN PHONGBAN { get; set; }
        public virtual ICollection<NHAP> NHAPs { get; set; }
        public virtual ICollection<XUAT> XUATs { get; set; }
    }
}