namespace Ayojon.Models
{
    public class Event
    {
       // name, description, date, address, assigned user is neededd

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; } 
        public DateTime date { get; set; }
        public string address { get; set; }
        public int assignedUser { get; set; }

    }
}
