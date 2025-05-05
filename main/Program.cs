using control_public_events.main;

class Program
{
    static List<Event> events = new List<Event>();

    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("\t");
            Console.WriteLine("1. Register Event");
            Console.WriteLine("2. Register Person in Event");
            Console.WriteLine("3. List Events");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose...");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    EventRegister();
                    break;
                case "2":
                    PersonRegister();
                    break;
                case "3":
                    ListEvents();
                    break;
                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }


        static void EventRegister()
        {
            Event newEvent = new Event();

            Console.WriteLine("Event Name: ");
            newEvent.Name = Console.ReadLine();

            Console.WriteLine("Event Local: ");
            newEvent.Local = Console.ReadLine();

            Console.WriteLine("Is the event paid? (y/n): ");
            var paid = Console.ReadLine();

            if (paid == "y")
            {
                Console.WriteLine("Event Value: ");
                newEvent.Value = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                newEvent.Value = 0;
            }

            events.Add(newEvent);
            Console.WriteLine("Event registered successfully!");


        }

        static void PersonRegister()
        {
            if (events.Count == 0)
            {
                Console.WriteLine("No events registered.");
                return;
            }

            Console.WriteLine("Available events:");
            for (int i = 0; i < events.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {events[i].Name}");
                Console.WriteLine($"{events[i].Participants.Count}|20 Peoples");
            }

            Console.WriteLine("Choose the event by number: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            if (index < 0 || index >= events.Count)
            {
                Console.WriteLine($"Invalid Event{index}");
                return;
            }

            Person newPerson = new Person();

            Console.WriteLine("Participant Name: ");
            newPerson.Name = Console.ReadLine();

            Console.WriteLine("Participant Address: ");
            newPerson.Address = Console.ReadLine();

            Console.WriteLine("Participant Age: ");
            newPerson.Age = Convert.ToInt32(Console.ReadLine());

            if (events[index].AddPerson(newPerson))
            {
                Console.WriteLine($"Person registered for the event{events[index].Name}");
            }
        }

        static void ListEvents()
        {
            foreach (var newEvent in events)
            {
                Console.WriteLine($"Event Name: {newEvent.Name} | Event Local: {newEvent.Local} | Event Value: R${newEvent.Value}");
                Console.WriteLine($"Participants ({newEvent.Participants.Count}20):");
                foreach (var person in newEvent.Participants)
                {
                    Console.WriteLine($"- {person.Name} {person.Age} years Address: {person.Address}");
                }
            }
        }

    }
}
