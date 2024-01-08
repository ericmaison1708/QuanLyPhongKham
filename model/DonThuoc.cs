namespace QuanLyPhongKham.model
{
    using QuanLyPhongKham.model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TDonThuoc")]
    public partial class DonThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonThuoc()
        {
            CT_hoaDon = new HashSet<CT_HoaDon>();
            CT_donThuoc = new HashSet<CT_DonThuoc>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ID_PhieuKetQua { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string ID_PhieuKhamBenh { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgayLap { get; set; }

        [Column(TypeName = "money")]
        public decimal TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HoaDon> CT_hoaDon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DonThuoc> CT_donThuoc { get; set; }

        public virtual PhieuKetQua phieuKetQua { get; set; }
    }
}