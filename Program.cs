namespace EmployeeWage1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            int isPresent = 1;
            int empHrs = 0;
            int empWage = 0;
            const int EMP_RATE_PER_HR = 20;
            Random random = new Random();
            int employeeAttendence = random.Next(0, 2);
            if (employeeAttendence == isPresent)
            {
                Console.WriteLine("employee attendence is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("employee attendence is absent");
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage is:" + empWage);

        }
    }
}