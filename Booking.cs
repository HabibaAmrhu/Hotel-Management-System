using System;
using System.Collections.Generic;


internal class Booking1
{
    public Queue<Guest> GuestQueue;
    public Booking1()
    {
        GuestQueue = new Queue<Guest>();
    }

    public void GuestBooking()
    {
        Console.WriteLine("Enter Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter Phone: ");
        int phone = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Check-in Date (DD/MM/YYYY): ");
        string checkInDate = Console.ReadLine();
        Console.WriteLine("Enter Check-out Date (DD/MM/YYYY): ");
        string checkOutDate = Console.ReadLine();
        Console.WriteLine("Successfully!");

        Guest guest = new Guest(name, email, phone);
        GuestQueue.Enqueue(guest);
    }
    public void PrintGuests()
    {
        Console.WriteLine("Guests:");
        foreach (Guest guest in GuestQueue)
        {
            Console.WriteLine($"Name: {guest.Name}, Email: {guest.Email}, Phone: {guest.Phone}");
        }
    }
}
