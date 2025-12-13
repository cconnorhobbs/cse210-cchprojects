using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("100 College Ave", "Rexburg", "ID", "USA");
        Address address2 = new Address("50 Main St", "Salt Lake City", "UT", "USA");
        Address address3 = new Address("200 Park Blvd", "Boise", "ID", "USA");

        events.Add(new Lecture(
            "Software Engineering Talk",
            "Best practices in modern software design",
            "April 10, 2025",
            "6:00 PM",
            address1,
            "Dr. Jane Smith",
            150));

        events.Add(new Reception(
            "Alumni Networking Night",
            "Meet and connect with alumni",
            "May 5, 2025",
            "7:00 PM",
            address2,
            "rsvp@events.com"));

        events.Add(new OutdoorGathering(
            "Summer Tech Picnic",
            "Relax and enjoy tech discussions outdoors",
            "June 20, 2025",
            "12:00 PM",
            address3,
            "Sunny, 75°F"));

        foreach (Event ev in events)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine(ev.GetStandardDetails());

            Console.WriteLine("\nFULL DETAILS");
            Console.WriteLine(ev.GetFullDetails());

            Console.WriteLine("\nSHORT DESCRIPTION");
            Console.WriteLine(ev.GetShortDescription());
        }
    }
}
