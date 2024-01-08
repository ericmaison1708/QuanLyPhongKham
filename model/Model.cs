using QuanLyPhongKham.model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyPhongKham.model
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model121")
        {
        }

        public virtual DbSet<TaiKhoan> taiKhoan { get; set; }
        public virtual DbSet<BacSi> bacSi { get; set; }
        public virtual DbSet<NhanVien> nhanVien { get; set; }
        public virtual DbSet<BenhNhan> benhNhan { get; set; }

        public virtual DbSet<DichVuKham> dichVuKham { get; set; }
        public virtual DbSet<LoaiThuoc> loaiThuoc { get; set; }
        public virtual DbSet<Thuoc> thuoc { get; set; }

        public virtual DbSet<PhieuKhamBenh> phieuKhamBenh { get; set; }
        public virtual DbSet<PhieuKetQua> phieuKetQua { get; set; }
        public virtual DbSet<DonThuoc> donThuoc { get; set; }
        public virtual DbSet<CT_DonThuoc> CT_donThuoc { get; set; }
        public virtual DbSet<HoaDon> hoaDon { get; set; }
        public virtual DbSet<CT_HoaDon> CT_hoaDon { get; set; }

        public virtual DbSet<NhaCungCap> nhaCungCap { get; set; }
        public virtual DbSet<PhieuNhapThuoc> phieuNhapThuoc { get; set; }
        public virtual DbSet<CT_PhieuNhapThuoc> CT_phieuNhapThuoc { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BacSi>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BacSi>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BacSi>()
                .HasMany(e => e.phieuKetQua)
                .WithRequired(e => e.bacSi)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .HasMany(e => e.hoaDon)
                .WithRequired(e => e.benhNhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BenhNhan>()
                .HasMany(e => e.phieuKhamBenh)
                .WithRequired(e => e.benhNhan)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<CT_HoaDon>()
                .Property(e => e.ID_HoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HoaDon>()
                .Property(e => e.ID_DonThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HoaDon>()
                .Property(e => e.ID_PhieuKetQua)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HoaDon>()
                .Property(e => e.ID_PhieuKhamBenh)
                .IsFixedLength()
                .IsUnicode(false);


            modelBuilder.Entity<CT_PhieuNhapThuoc>()
                .Property(e => e.ID_PhieuNhapThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PhieuNhapThuoc>()
                .Property(e => e.ID_Thuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_PhieuNhapThuoc>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);


            modelBuilder.Entity<CT_DonThuoc>()
                .Property(e => e.ID_DonThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_DonThuoc>()
                .Property(e => e.ID_PhieuKetQua)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_DonThuoc>()
                .Property(e => e.ID_PhieuKhamBenh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_DonThuoc>()
                .Property(e => e.ID_Thuoc)
                .IsFixedLength()
                .IsUnicode(false);


            modelBuilder.Entity<DichVuKham>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVuKham>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);


            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.ID_NhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.ID_BenhNhan)
                .IsFixedLength()
                .IsUnicode(false);


            modelBuilder.Entity<LoaiThuoc>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiThuoc>()
                .HasMany(e => e.thuoc)
                .WithRequired(e => e.loaiThuoc)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.Website)
                .IsUnicode(false);


            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.hoaDon)
                .WithRequired(e => e.nhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.phieuKhamBenh)
                .WithRequired(e => e.nhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.phieuNhapThuoc)
                .WithRequired(e => e.nhanVien)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<PhieuKetQua>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKetQua>()
                .Property(e => e.ID_BacSi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKetQua>()
                .Property(e => e.ID_PhieuKhamBenh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKetQua>()
                .HasMany(e => e.donThuoc)
                .WithRequired(e => e.phieuKetQua)
                .HasForeignKey(e => new { e.ID_PhieuKetQua, e.ID_PhieuKhamBenh })
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.ID_NhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.ID_BenhNhan)
                .IsFixedLength()
                .IsUnicode(false);


            modelBuilder.Entity<PhieuNhapThuoc>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapThuoc>()
                .Property(e => e.ID_NhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapThuoc>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Thuoc>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.GiaNhap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.GiaBan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.ID_LoaiThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .HasMany(e => e.CT_donThuoc)
                .WithRequired(e => e.thuoc)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.ID_PhieuKetQua)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.ID_PhieuKhamBenh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DonThuoc>()
                .HasMany(e => e.CT_hoaDon)
                .WithRequired(e => e.donThuoc)
                .HasForeignKey(e => new { e.ID_DonThuoc, e.ID_PhieuKetQua, e.ID_PhieuKhamBenh })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonThuoc>()
                .HasMany(e => e.CT_donThuoc)
                .WithRequired(e => e.donThuoc)
                .HasForeignKey(e => new { e.ID_DonThuoc, e.ID_PhieuKetQua, e.ID_PhieuKhamBenh });
        }
    }
}
