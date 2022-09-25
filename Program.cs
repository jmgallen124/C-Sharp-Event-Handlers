// Jeremy Gallen's sample program to demonstrate event handlers

// Overall namespace
namespace EventHandlers
{
    // Public delegate
    public delegate string MyDelegate(string str);
    // Main class
    class EventProgramExample
    {
        // Event declaration
        event MyDelegate MyEvent;

        // Event program sample
        public EventProgramExample()
        {
            // Add to event
            this.MyEvent += new MyDelegate(this.WelcomeUser);
        }

        // Method to welcome user
        public string WelcomeUser(string username)
        {
            return "Welcome, " + username + ".";
        }

        // Main method
        static void Main(string[] args)
        {
            // Create event sample and output
            EventProgramExample object1 = new EventProgramExample();
            string outcome = object1.MyEvent("Jeremy");
            Console.WriteLine(outcome);
        }
    }
}