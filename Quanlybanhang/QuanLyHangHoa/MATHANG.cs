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
    
    public partial class MATHANG
    {
        public MATHANG()
        {
            this.CHITIETNHAPs = new HashSet<CHITIETNHAP>();
            this.CHITIETXUATs = new HashSet<CHITIETXUAT>();
            this.KHOes = new HashSet<KHO>();
        }
    
        public int MATHANGID { get; set; }
        public string TENMH { get; set; }
        public string DONVITINH { get; set; }
        public string THANHPHAN { get; set; }
        public Nullable<int> NHASANXUATID { get; set; }
    
        public virtual ICollection<CHITIETNHAP> CHITIETNHAPs { get; set; }
        public virtual ICollection<CHITIETXUAT> CHITIETXUATs { get; set; }
        public virtual ICollection<KHO> KHOes { get; set; }
        public virtual NHASANXUAT NHASANXUAT { get; set; }
    }
}
