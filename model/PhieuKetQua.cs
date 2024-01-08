namespace QuanLyPhongKham.model
{
    using QuanLyPhongKham.model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuKetQua")]
    public partial class PhieuKetQua
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuKetQua()
        {
            donThuoc = new HashSet<DonThuoc>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ID_PhieuKhamBenh { get; set; }

        [Required]
        [StringLength(5)]
        public string ID_BacSi { get; set; }

        [StringLength(100)]
        public string TienSu { get; set; }

        [StringLength(100)]
        public string Tai { get; set; }

        [StringLength(100)]
        public string Mui { get; set; }

        [StringLength(100)]
        public string Hong { get; set; }

        [StringLength(100)]
        public string ChanDoan { get; set; }

        [StringLength(100)]
        public string NoiDung { get; set; }

        [StringLength(100)]
        public string KetLuam { get; set; }

        public virtual BacSi bacSi { get; set; }

        public virtual PhieuKhamBenh phieuKhamBenh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonThuoc> donThuoc { get; set; }
    }
}