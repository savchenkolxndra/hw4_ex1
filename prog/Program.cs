namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Worker> members = new List<Worker>();

            Console.Write("Ви бажаєте створити команду? (так/ні): ");

            string answer = Console.ReadLine().ToLower();

            if (answer == "ні")
            {
                Console.WriteLine("Програму завершено.");
            }
            else if (answer == "так")
            {
                Console.Write("Введіть назву команди: ");
                string teamName = Console.ReadLine();
                List<Worker> employees = new List<Worker>();

                Console.Write($"Введіть кількість працівників команди {teamName}: ");
                int numberOfEmploees;
                Int32.TryParse(Console.ReadLine(), out numberOfEmploees);

                int i = 0;
                while(employees.Count < numberOfEmploees)
                {
                    i++;
                    Console.Write($"Оберіть позицію працівника #{i} (розробник/менеджер): ");
                    string position = Console.ReadLine().ToLower();
                    if (position == "розробник")
                    {
                        Console.Write("Ім'я: ");
                        string employeeName = Console.ReadLine();

                        TimeSpan[] workday = new TimeSpan[2];
                        Console.Write("Введіть початок робочого дня (гг:хх): ");
                        workday[0] = TimeSpan.Parse(Console.ReadLine());
                        Console.Write("Введіть кінець робочого дня (гг:хх): ");
                        workday[1] = TimeSpan.Parse(Console.ReadLine());

                        employees.Add(new Developer(employeeName, workday));
                    }
                    else if (position == "менеджер")
                    {
                        Console.Write("Ім'я: ");
                        string employeeName = Console.ReadLine();

                        TimeSpan[] workday = new TimeSpan[2];
                        Console.Write("Введіть початок робочого дня (гг:хх): ");
                        workday[0] = TimeSpan.Parse(Console.ReadLine());
                        Console.Write("Введіть кінець робочого дня (гг:хх): ");
                        workday[1] = TimeSpan.Parse(Console.ReadLine());

                        employees.Add(new Manager(employeeName, workday));
                    }
                    else
                    {
                        Console.WriteLine("Ви ввели неправильну позицію. Не вводьте більше неправильні дані =)");
                        i--;
                    }
                }

                Team newTeam = new Team(teamName, employees);
                newTeam.TeamInfo();

                Console.WriteLine();
                Console.WriteLine("Робочий день команди: ");

                foreach (var employee in newTeam.Employees)
                {
                    employee.FillWorkDay();
                }
            }
            else
            {
                Console.WriteLine("Ви ввели хибну відповідь. Так не можна!");
            }
        }
    }
}