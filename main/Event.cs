namespace control_public_events.main
{
    public class Event
    {
        public string Name { get; set; } = string.Empty;
        public string Local { get; set; } = string.Empty;
        public double Value { get; set; }
        public List<Person> Participants { get; set; } = new List<Person>();

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