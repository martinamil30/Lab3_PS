namespace UserLogin
{
    public class PR
    {
        public delegate void ErrorHandling(string message);
        public static void Main(string[] args)
        {
            ErrorHandling errHandler = DeclareError;
            UserData.resetUserData();
            string Password, Username;

            Console.WriteLine("Enter username");
            Username = Console.ReadLine();
            Console.WriteLine("Enter password");
            Password = Console.ReadLine();
            LoginValidation validation = new LoginValidation(Username, Password, DeclareError);

            User user = new();

            bool isValid = validation.validateUserInput(ref user);

            if (isValid)
            {
                int Role = (int)user.Role;
                switch (Role)
                {
                    case 0:
                        Console.WriteLine("This user is anonymous");
                        Console.WriteLine("Username : " + user.Username);
                        Console.WriteLine("Password : " + user.Password);
                        Console.WriteLine("Faculty number : " + user.FacNum);
                        Console.WriteLine("Role: " + user.Role);
                        break;
                    case 1:
                        Console.WriteLine("This user is an admin");
                        Console.WriteLine("Username : " + user.Username);
                        Console.WriteLine("Password : " + user.Password);
                        Console.WriteLine("Faculty number : " + user.FacNum);
                        Console.WriteLine("Role: " + user.Role);
                        AdminFuncs();
                        break;
                    case 2:
                        Console.WriteLine("This user is an inspector");
                        Console.WriteLine("Username : " + user.Username);
                        Console.WriteLine("Password : " + user.Password);
                        Console.WriteLine("Faculty number : " + user.FacNum);
                        Console.WriteLine("Role: " + user.Role);
                        break;
                    case 3:
                        Console.WriteLine("This user is a professor");
                        Console.WriteLine("Username : " + user.Username);
                        Console.WriteLine("Password : " + user.Password);
                        Console.WriteLine("Faculty number : " + user.FacNum);
                        Console.WriteLine("Role: " + user.Role);
                        break;
                    case 4:
                        Console.WriteLine("This user is a student");
                        Console.WriteLine("Username : " + user.Username);
                        Console.WriteLine("Password : " + user.Password);
                        Console.WriteLine("Faculty number : " + user.FacNum);
                        Console.WriteLine("Role: " + user.Role);
                        break;
                }
            }
        }
        public static void DeclareError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            Logger.LogLoginError(errorMessage);
        }


        public static void AdminFuncs()
        {
            int choice = 0;
            while (choice != -1)
            {
                Console.WriteLine("Choose an option.");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("1. Change a user's role.");
                Console.WriteLine("2. Change a user's activity.");
                Console.WriteLine("3. List all users.");
                Console.WriteLine("4. See all logs");
                Console.WriteLine("5. See all current logs");
                Console.WriteLine("6. See oldest log");
                Console.WriteLine("7. Certificate");


                choice = Int32.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 0:
                        choice = -1;
                        break;
                    case 1:
                        Console.WriteLine("Enter username and new role");
                        string Username = Console.ReadLine();
                        int Role = Int32.Parse(Console.ReadLine());
                        UserData.AssignUserRole(Username, (UserRoles)Role);
                        break;
                    case 2:
                        Console.WriteLine("Enter username and new date");
                        Username = Console.ReadLine();
                        DateTime date = setDate();
                        UserData.SetUserActiveTo(Username, date);
                        break;
                    case 3:
                        UserData.seeAllUsers();
                        break;
                    case 4:
                        Logger.VisualizeLogs();
                        break;
                    case 5:
                        Console.WriteLine("Enter filter for logs");
                        string filter = Console.ReadLine();
                        Logger.VisualizeCurrentLogs(filter);
                        Logger.CountLogs();
                        break;
                    case 6:
                        Logger.OldestLog();
                        break;
                    case 7:
                        UserData.PrepareCertificate();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }

        private static DateTime setDate()
        {
            int minMonth = 1, maxMonth = 12, minDay = 1, maxDay = 31;

            Console.WriteLine("Enter the year of the date in numerical:");
            int year = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month of the date:");
            int month = Int32.Parse(Console.ReadLine());

            if (month < minMonth || month > maxMonth)
            {
                Console.WriteLine("Invalid month. Enter a value within the 1-12 range");
                month = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the day of the date:");
            int day = Int32.Parse(Console.ReadLine());

            if (day < minDay || day > maxDay)
            {
                Console.WriteLine("Invalid month. Enter a value within the 1-12 range");
                month = Int32.Parse(Console.ReadLine());
            }

            return new DateTime(year, month, day);

        }
    }
}
