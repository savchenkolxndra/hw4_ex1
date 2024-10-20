namespace prog
{
    class Manager : Worker
    {
        private Random randomNum;

        // base викликає конструктор класу Worker і передає йому параметр Name
        public Manager(string name, TimeSpan[] workday) : base(name)
        {
            Position = "Менеджер";
            randomNum = new Random();
            this.Workday = workday;
        }

        public override void FillWorkDay()
        {
            int callCount1 = randomNum.Next(1, 11);
            for (int i = 0; i < callCount1; i++)
            {
                Call();
            }

            Relax();

            int callCount2 = randomNum.Next(1, 6);
            for (int i = 0; i < callCount2; i++)
            {
                Call();
            }
        }
    }
}