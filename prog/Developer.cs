namespace prog
{
    class Developer : Worker
    {
        // base викликає конструктор класу Worker і передає йому параметр Name
        public Developer(string name, TimeSpan[] workday) : base(name)
        {
            this.Position = "Розробник";
            this.Workday = workday;
        }

        public override void FillWorkDay()
        {
            Call();
            WriteCode();
            Relax();
        }
    }

}