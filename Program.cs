namespace EmployeeWage1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            int empHrs = 0;
            int day = 1;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int empWage = 0;
            int totalWage = 0;
            const int EMP_RATE_PER_HR = 20;
            const int NUMBER_OF_WORKING_DAYS = 20;

            Random random = new Random();
            for (day = 1; day < NUMBER_OF_WORKING_DAYS; day++)
            {
                int employeeAttendence = random.Next(0, 3);
                switch (employeeAttendence)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                //UC2
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Employee wage for day{0} is:{1}", day, empWage);
                totalWage += empWage;
            }
            Console.WriteLine("TotalWage for {0} days is:{1}", (day - 1), totalWage);

        }
    }
}