namespace QuanLyPhongKham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(25)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(25)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(10)]
        public string QuyenTaiKhoan { get; set; }
    }
}