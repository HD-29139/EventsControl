namespace control_public_events.main
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person(string name, string address, int age)
        {
            this.Name = name;
            this.Address = address;
            this.Age = age;
        }
    }
}