namespace QuanLyPhongKham.model
{
    using QuanLyPhongKham.model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuKhamBenh")]
    public partial class PhieuKhamBenh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuKhamBenh()
        {
            phieuKetQua = new HashSet<PhieuKetQua>();
        }

        [Key]
        [StringLength(6)]
        public string ID { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_PhieuKhamBenh { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_NhanVien { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_BenhNhan { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NGAYLAP { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }


        public virtual BenhNhan benhNhan { get; set; }

        public virtual NhanVien nhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuKetQua> phieuKetQua { get; set; }
    }
}