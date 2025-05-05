using System.Drawing;

namespace control_public_events.main
{
    public class Event
    {
        public string Name { get; set; }
        public string Local { get; set; }
        public double Value { get; set; }
        public List<Person> Participants { get; set; } = new List<Person>();

        public Event(string name, string local, double value)
        {
            this.Name = name;
            this.Local = local;
            this.Value = value;
        }

        public bool AddPerson(Person person)
        {
            if (Participants.Count >= 20)
            {
                Console.WriteLine("Full event!");
                return false;
            }
            Participants.Add(person);
            return true;
        }
    }
}