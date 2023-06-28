namespace EmployeeWage1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Statement");
            int isPresent = 1;
            Random random = new Random();
            int employeeAttendence = random.Next(0, 2);
            if (employeeAttendence == isPresent)
            {
                Console.WriteLine("employee attendence is present");
            }
            else
            {
                Console.WriteLine("employee attendence is absent");
            }
        }
    }
}