using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeFristProje.Models.Mapping
{
    public class kullanicilarMap : EntityTypeConfiguration<kullanicilar>
    {
        public kullanicilarMap()
        {
            // Primary Key
            this.HasKey(t => new { t.kullaniciAdi, t.sifre });

            // Properties
            this.Property(t => t.kullaniciAdi)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.sifre)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.sirket)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("kullanicilar");
            this.Property(t => t.kullaniciAdi).HasColumnName("kullaniciAdi");
            this.Property(t => t.sifre).HasColumnName("sifre");
            this.Property(t => t.sirket).HasColumnName("sirket");
        }
    }
}
