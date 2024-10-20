namespace prog
{
    abstract class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public TimeSpan[] Workday = new TimeSpan[2];

        public Worker(string name)
        {
            this.Name = name;

        }

        public void Call()
        {
            Console.WriteLine($"{Name} is making a call.");
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing code.");
        }

        public void Relax()
        {
            Console.WriteLine($"{Name} is relaxing.");
        }

        public abstract void FillWorkDay();
    }
}