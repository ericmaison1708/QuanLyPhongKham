namespace QuanLyPhongKham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhapThuoc")]
    public partial class PhieuNhapThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhapThuoc()
        {
            CT_phieuNhapThuoc = new HashSet<CT_PhieuNhapThuoc>();
        }

        [Key]
        [StringLength(6)]
        public string ID { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_NhanVien { get; set; }

        [Required]
        [StringLength(6)]
        public string ID_NhaCungCap { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgayLap { get; set; }

        [Column(TypeName = "money")]
        public decimal TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PhieuNhapThuoc> CT_phieuNhapThuoc { get; set; }

        public virtual NhanVien nhanVien { get; set; }

        public virtual NhaCungCap nhaCungCap { get; set; }

    }
}