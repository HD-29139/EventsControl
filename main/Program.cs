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
                    // PersonRegister();
                    break;
                case "3":
                    // ListEvents();
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
        
    }
}
