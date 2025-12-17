using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("100 Flower St", "San Francisco", "CA", "USA");
        Address receptionAddress = new Address("2000 Central Ave", "New York", "NY", "USA");
        Address outdoorAddress = new Address("Serra Park", "Denver", "CO", "USA");

        Event[] events =
        {
            new Lecture(
                "Tech Summit",
                "Trends in AI and cloud computing",
                new DateTime(2025, 2, 15, 10, 0, 0),
                lectureAddress,
                "Dr. Ana Mendes",
                150),
            new Reception(
                "Networking Cocktail",
                "Meetup with local entrepreneurs",
                new DateTime(2025, 3, 5, 19, 30, 0),
                receptionAddress,
                "rsvp@eventos.com"),
            new OutdoorGathering(
                "Summer Festival",
                "Live music and regional food",
                new DateTime(2025, 1, 25, 16, 0, 0),
                outdoorAddress,
                "Clear skies with light breeze")
        };

        foreach (Event eventItem in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(eventItem.StandardDetails());
            Console.WriteLine();

            Console.WriteLine("----- Full Details -----");
            Console.WriteLine(eventItem.FullDetails());
            Console.WriteLine();

            Console.WriteLine("----- Short Description -----");
            Console.WriteLine(eventItem.ShortDescription());
            Console.WriteLine();
        }
    }
}