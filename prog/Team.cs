namespace prog
{
    class Team
    {
        public string TeamName;
        public List<Worker> Employees = new List<Worker>();
        // конструктор тім
        public Team(string teamName, List<Worker> employee)
        {
            this.TeamName = teamName;
            if (employee.Count > 0)
            {
                this.Employees = employee;
            }
        }
        public void AddEmployee(Worker employee)
        {
            this.Employees.Add(employee);
        }

        public void TeamInfo()
        {
            Console.WriteLine($"Назва команди: {TeamName}");
            Console.WriteLine($"Члени {TeamName}: ");
            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine($"  {i + 1}) Ім'я - {Employees[i].Name}, позиція - {Employees[i].Position}," +
                    $" робочий час - від {Employees[i].Workday[0]} до {Employees[i].Workday[1]};");
            }
        }
    }
}