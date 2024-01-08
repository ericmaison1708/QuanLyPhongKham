namespace QuanLyPhongKham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NCC")]
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            CT_cungCapThuoc = new HashSet<CT_CungCapThuoc>();
        }

        [Key]
        [StringLength(6)]
        public string ID { get; set; }

        [StringLength(100)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(60)]
        public string Website { get; set; }

    }
}