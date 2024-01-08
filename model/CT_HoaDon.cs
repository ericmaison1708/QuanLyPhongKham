namespace QuanLyPhongKham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HoaDon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string ID_HoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string ID_DonThuoc { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string ID_PhieuKetQua { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string ID_PhieuKhamBenh { get; set; }

        public virtual HoaDon hoaDon { get; set; }

        public virtual DonThuoc donThuoc { get; set; }
    }
}