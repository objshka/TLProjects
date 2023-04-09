using Hotels.Domain.Reservations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotels.Infrastructure.Data.Reservations;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable("Reservation");

        builder.HasKey(x => new { x.RoomId, x.CheckInDate });

        builder.HasOne(x => x.Room)
            .WithMany()
            .HasForeignKey(x => x.RoomId);
    }
}