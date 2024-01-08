namespace QuanLyPhongKham.model
{
    using QuanLyPhongKham.model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_DonThuoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string ID_DonThuoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ID_PhieuKetQua { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string ID_PhieuKhamBenh { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string ID_Thuoc { get; set; }

        public string CachDung { get; set; }
        public int SoLuong { get; set; }

        public virtual Thuoc thuoc { get; set; }

        public virtual DonThuoc donThuoc { get; set; }
    }
}