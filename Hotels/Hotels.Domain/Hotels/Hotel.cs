using Hotels.Domain.Rooms;

namespace Hotels.Domain.Hotels;

public class Hotel
{
    public Hotel () {}
    public Hotel(int id, string name, string address, List<Room> rooms)
    {
        Id = id;
        Name = name;
        Address = address;
        Rooms = rooms;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Address { get; private set; }
    public List<Room> Rooms { get; private set; }
}