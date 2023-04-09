using Hotels.Domain.Rooms;

namespace Hotels.Domain.Reservations;

public class Reservation
{
    public Reservation () {}
    public Reservation(int roomId, Room room, DateTime checkInDate, DateTime checkOutDate)
    {
        RoomId = roomId;
        Room = room;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
    }

    public int RoomId { get; private set; }
    public Room Room { get; private set; }
    public DateTime CheckInDate { get; private set; }
    public DateTime CheckOutDate { get; private set; }
}