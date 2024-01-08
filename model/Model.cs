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
                .Property(e => e.ID)
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
                .Property(e => e.MABN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiThuoc>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiThuoc>()
                .HasMany(e => e.Thuocs)
                .WithRequired(e => e.LoaiThuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MANhaCungCap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MANhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MADT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MACV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuKhamBenhs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuNhapThuocs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHANQUYEN>()
                .HasMany(e => e.TaiKhoans)
                .WithRequired(e => e.PHANQUYEN)
                .HasForeignKey(e => e.QUYENTK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHANQUYEN>()
                .HasMany(e => e.TaiKhoans1)
                .WithRequired(e => e.PHANQUYEN1)
                .HasForeignKey(e => e.QUYENTK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .Property(e => e.MAPCLS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .Property(e => e.MABN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .HasMany(e => e.CT_HoaDon)
                .WithRequired(e => e.PHIEUCANLAMSANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .HasMany(e => e.CT_SDDV)
                .WithRequired(e => e.PHIEUCANLAMSANG)
                .HasForeignKey(e => e.MAPCLS);

            modelBuilder.Entity<PHIEUCANLAMSANG>()
                .HasMany(e => e.CT_SDDV1)
                .WithRequired(e => e.PHIEUCANLAMSANG1)
                .HasForeignKey(e => e.MAPCLS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuKetQua>()
                .Property(e => e.MAPHIEUKQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKetQua>()
                .Property(e => e.MABS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKetQua>()
                .Property(e => e.MAPHIEUKB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKetQua>()
                .HasMany(e => e.DonThuocs)
                .WithRequired(e => e.PhieuKetQua)
                .HasForeignKey(e => new { e.MAPHIEUKQ, e.MAPHIEUKB })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.MAPHIEUKB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.MAPK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.MALOAIK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.MANhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.MABN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapThuoc>()
                .Property(e => e.MAPNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapThuoc>()
                .Property(e => e.MANhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapThuoc>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHONGKHAM>()
                .Property(e => e.MAPK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONGKHAM>()
                .HasMany(e => e.BACSies)
                .WithRequired(e => e.PHONGKHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGKHAM>()
                .HasMany(e => e.PhieuKhamBenhs)
                .WithRequired(e => e.PHONGKHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanB>()
                .Property(e => e.MABS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanB>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNhanVien>()
                .Property(e => e.MANhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNhanVien>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.MAThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.DONGIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .HasMany(e => e.CT_DonThuoc)
                .WithRequired(e => e.Thuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.MADonThuoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.MAPHIEUKQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.MAPHIEUKB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.TONGTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DonThuoc>()
                .HasMany(e => e.CT_HoaDon)
                .WithRequired(e => e.DonThuoc)
                .HasForeignKey(e => new { e.MADonThuoc, e.MAPHIEUKQ, e.MAPHIEUKB })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonThuoc>()
                .HasMany(e => e.CT_DonThuoc)
                .WithRequired(e => e.DonThuoc)
                .HasForeignKey(e => new { e.MADonThuoc, e.MAPHIEUKQ, e.MAPHIEUKB });
        }
    }
}
