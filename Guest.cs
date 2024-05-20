using System;


public class Guest
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }

    public Guest(string name, string email, int phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
    }

    public void HotelInformation()
    {
        Console.WriteLine($" Guest name is : {Name}");
        Console.WriteLine($" Guest email is : {Email}");
        Console.WriteLine($" Guest phone is : {Phone}");
    }
}
