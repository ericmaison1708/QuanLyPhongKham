namespace QuanLyPhongKham.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVuKham")]
    public partial class DichVuKham
    {
        [Key]
        [StringLength(5)]
        public string ID { get; set; }

        [StringLength(100)]
        public string Ten { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }
    }
}