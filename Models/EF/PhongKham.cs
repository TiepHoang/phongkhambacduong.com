namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PhongKham : DbContext
    {
        public PhongKham()
            : base("name=PhongKham")
        {
        }

        public virtual DbSet<BacSi> BacSis { get; set; }
        public virtual DbSet<CoSoVatChat> CoSoVatChats { get; set; }
        public virtual DbSet<CTCoSoVatChat> CTCoSoVatChats { get; set; }
        public virtual DbSet<DiaChi> DiaChis { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<GopY> Gopies { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Slogan> Slogans { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoSoVatChat>()
                .HasMany(e => e.CTCoSoVatChats)
                .WithOptional(e => e.CoSoVatChat)
                .HasForeignKey(e => e.ID_CoSoVatChat);

            modelBuilder.Entity<DiaChi>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<DiaChi>()
                .Property(e => e.Hotline)
                .IsUnicode(false);

            modelBuilder.Entity<GopY>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<Slogan>()
                .Property(e => e.itemGioiThieu)
                .IsUnicode(false);

            modelBuilder.Entity<Slogan>()
                .Property(e => e.ImageGioiThieu)
                .IsUnicode(false);

            modelBuilder.Entity<Slogan>()
                .Property(e => e.ImagePage)
                .IsUnicode(false);

            modelBuilder.Entity<Slogan>()
                .Property(e => e.SloganPage)
                .IsUnicode(false);
        }
    }
}
