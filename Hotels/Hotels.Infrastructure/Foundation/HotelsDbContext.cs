using Hotels.Infrastructure.Data.Hotels;
using Hotels.Infrastructure.Data.Reservations;
using Hotels.Infrastructure.Data.Rooms;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Infrastructure.Foundation;

public class HotelsDbContext : DbContext
{
    public HotelsDbContext (DbContextOptions options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HotelConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReservationConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RoomConfiguration).Assembly);
    }
}