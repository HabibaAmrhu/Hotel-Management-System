using System;
using System.Threading;
using HotelManagement;
using HotelManagement1;


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Hotel");
        Booking1 booking = new Booking1();
        Random random = new Random();
        while (true)
        {
            Console.WriteLine("1) Booking");
            Console.WriteLine("2) More Information");
            Console.WriteLine("3) Guests");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                ProcessBooking(booking, random);
            }
            else if (choice == 2)
            {
                ProcessHotelInformation();
            }
            else if (choice == 3)
            {
                booking.PrintGuests();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
    static int ReadIntegerInput()
    {
        int choice = 0;
        string input = "";
        bool isValid = true;
        while (true)
        {
            int key = int.Parse(Console.ReadLine());
            if (key >= '0' && key <= '9')
            {
                input += key;
                Console.Write(key);
            }
            else
            {
                isValid = false;
                break;
            }
        }

        if (isValid && input != "")
        {
            choice = int.Parse(input);
        }
        else
        {
            choice = -1;
        }

        return choice;
    }

    static void ProcessBooking(Booking1 booking, Random random)
    {
        int sin = 100;
        int dou = 150;
        int tri = 250;
        Console.WriteLine("Booking");
        booking.GuestBooking();

        Console.WriteLine("How many rooms do you want?");
        int rooms = ReadIntegerInput();


        Console.WriteLine("What is the type of the room (Single,Double, Triple)");
        string roomtype = Console.ReadLine();

        Console.WriteLine("How many days are you willing to stay?");
        int days = Convert.ToInt32(Console.ReadLine());
        int res;
        if (roomtype == "Single" || roomtype == "single" || roomtype == "SINGLE")
        {
            res = days * sin;
            Console.WriteLine("Cost is: " + res);
        }
        else if (roomtype == "Double" || roomtype=="double" || roomtype == "DOUBLE")
        {
            res = days * dou;
            Console.WriteLine("Cost is: " + res);
        }
        else if (roomtype == "Triple" || roomtype == "triple" || roomtype == "TRIPLE")
        {
            res =days * tri;
            Console.WriteLine("Cost is: " + res);
        }

        Console.WriteLine("Processing, please wait...");
        Thread.Sleep(2000);

        Room room = new Room(random.Next(0, 100), true, random.Next(5000, 15000), $"{rooms} rooms and free WIFI");
        room.DisplayRoomDetails(booking.GuestQueue.Peek());

        Console.WriteLine("Thank you for booking Hotel <3");
        Console.WriteLine("Do you want to book again? (Y/N)");

        int K1 = int.Parse(Console.ReadLine());
        if (K1 != 'Y')
        {
            return;
        }
    }
    static void ProcessHotelInformation()
    {
        Console.WriteLine("More Information About Hotel");
        Hotel hotel = new Hotel();
        hotel.HotelInformation();
    }
}
