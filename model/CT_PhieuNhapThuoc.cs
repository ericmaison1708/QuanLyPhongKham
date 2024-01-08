namespace QuanLyPhongKham.model
{
    using QuanLyPhongKham.model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PhieuNhapThuoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string ID_PhieuNhapThuoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string ID_Thuoc { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }

        [StringLength(10)]
        public string DonViTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NSX { get; set; }

        [Column(TypeName = "date")]
        public DateTime HSD { get; set; }

        public virtual PhieuNhapThuoc PhieuNhapThuoc { get; set; }
    }
}