using Hotels.Domain.Hotels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotels.Infrastructure.Data.Hotels;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        builder.ToTable("Hotel");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasMaxLength(200);
        builder.Property(x => x.Address).HasMaxLength(200);

        builder.HasMany(x => x.Rooms)
            .WithOne(x => x.Hotel)
            .HasForeignKey(x => x.HotelId);
    }
}