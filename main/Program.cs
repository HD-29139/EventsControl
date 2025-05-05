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

    
    }
}
