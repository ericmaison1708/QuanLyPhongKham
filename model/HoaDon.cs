namespace QuanLyPhongKham.model
{
    using QuanLyPhongKham.model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            CT_hoaDon = new HashSet<CT_HoaDon>();
        }

        [Key]
        [StringLength(5)]
        public string ID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgayLap { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_NhanVien { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_BenhNhan { get; set; }

        [Column(TypeName = "money")]
        public decimal TongTien { get; set; }

        public virtual BenhNhan benhNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HoaDon> CT_hoaDon { get; set; }

        public virtual NhanVien nhanVien { get; set; }
    }
}