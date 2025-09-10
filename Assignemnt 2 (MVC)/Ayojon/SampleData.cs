using Ayojon.Models;

namespace Ayojon
{
    public static class SampleData
    {


        public static List<Event> getAllEvents()
        {
            List<Event> events = new List<Event>();
            Event event1 = new Event()
            {
                id = 1,
                name = "Hero Alam vaiyer Biye",
                description = "Hero Khan weds Angel Priya on Saturday",
                date = new DateTime(2024, 12, 14, 10, 0, 0),
                address = "Banani, Dhaka",
                assignedUser = 2

            };

            Event event2 = new Event()
            {
                id = 2,
                name = "John Doe's Birthday Bash",
                description = "Celebrate John's 30th birthday with us!",
                date = new DateTime(2024, 11, 20, 19, 0, 0),
                address = "123 Party St, Fun City",
                assignedUser = 3
            };

            Event event3 = new Event()
            {
                id = 3,
                name = "Tech Conference 2024",
                description = "Join us for a day of tech talks and networking.",
                date = new DateTime(2025, 10, 5, 9, 0, 0),
                address = "Convention Center, Tech City",
                assignedUser = 1
            };

            Event event4 = new Event()
            {
                id = 4,
                name = "Wedding of Alice and Bob",
                description = "Alice and Bob are tying the knot! Join us for the celebration.",
                date = new DateTime(2025, 9, 15, 15, 0, 0),
                address = "Rose Garden, Love Town",
                assignedUser = 4
            };

            events.Add(event1);
            events.Add(event2);
            events.Add(event3);
            events.Add(event4);
            return events;
        }

        public static List<User> getAllUsers()
        {
            List<User> users = new List<User>();
            User user1 = new User()
            {
                Id = 1,
                FirstName = "Ajhar",
                LastName = "Hossain",
                ContactNumber = "0172222",
                Email = "aj@gmail.com",
                UserType = 1

            };

            User user2 = new User()
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe",
                ContactNumber = "0173333",
                Email = "JohnD@gmail.com",
                UserType = 2

            };

            User user3 = new User()
            {
                Id = 3,
                FirstName = "Alice",
                LastName = "Smith",
                ContactNumber = "0174444",
                Email = "Alice@gmail.com",
                UserType = 3
            };

            User user4 = new User()
            {
                Id = 4,
                FirstName = "Bob",
                LastName = "Johnson",
                ContactNumber = "0175555",
                Email = "bobson@gmail.com",
                UserType = 4
            };


            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            return users;
        }
    }
}
