using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Room
{

    public int Number { get; set; }
    public int Type { get; set; }
    public bool IsAvailable { get; set; }
    public decimal Price { get; set; }
    public string Amenities { get; set; }

    public Room(int number, bool isAvailable, decimal price, string amenities)
    {
        Number = number;
        IsAvailable = isAvailable;
        Price = price;
        Amenities = amenities;
    }

    public void DisplayRoomDetails(Guest guest)
    {
        Console.WriteLine($"Room Number: {Number}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Amenities: {Amenities}");
        Console.WriteLine($"Guest Name: {guest.Name}");
        Console.WriteLine($"Guest Email: {guest.Email}");
    }
}

