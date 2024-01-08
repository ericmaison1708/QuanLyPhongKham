namespace QuanLyPhongKham.model
{
    using QuanLyPhongKham.model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUOC")]
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            CT_phieuNhapThuoc = new HashSet<CT_PhieuNhapThuoc>();
            CT_donThuoc = new HashSet<CT_DonThuoc>();
        }

        [Key]
        [StringLength(5)]
        public string ID { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_LoaiThuoc { get; set; }

        [Required]
        [StringLength(100)]
        public string Ten { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaNhap { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaBan { get; set; }

        [StringLength(10)]
        public string DonViTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime HSD { get; set; }

        public int SoLuong { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PhieuNhapThuoc> CT_phieuNhapThuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DonThuoc> CT_donThuoc { get; set; }

        public virtual LoaiThuoc loaiThuoc { get; set; }
    }
}
