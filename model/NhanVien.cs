namespace QuanLyPhongKham.model
{
    using QuanLyPhongKham.model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            hoaDon = new HashSet<HoaDon>();
            phieuKhamBenh = new HashSet<PhieuKhamBenh>();
            phieuNhapThuoc = new HashSet<PhieuNhapThuoc>();
        }

        [Key]
        [StringLength(5)]
        public string ID { get; set; }

        [StringLength(40)]
        public string HoTen { get; set; }

        [StringLength(4)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string ChucVu { get; set; }

        [StringLength(30)]
        public string QueQuan { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> hoaDon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuKhamBenh> phieuKhamBenh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhapThuoc> phieuNhapThuoc { get; set; }
    }
}