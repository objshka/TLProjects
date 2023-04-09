using Hotels.Domain.Hotels;

namespace Hotels.Domain.Rooms;

public class Room
{
    public Room () {}
    public Room(int hotelId, int number, int price, bool isOccupied, Hotel hotel)
    {
        HotelId = hotelId; Number = number; Price = price; IsOccupied = isOccupied; Hotel = hotel;
    } 
    public int Id { get; private set; } 
    public int HotelId { get; private set; } 
    public int Number { get; private set; } 
    public int Price { get; private set; } 
    public bool IsOccupied { private get; set; }
    public Hotel Hotel { get; private set; }
}