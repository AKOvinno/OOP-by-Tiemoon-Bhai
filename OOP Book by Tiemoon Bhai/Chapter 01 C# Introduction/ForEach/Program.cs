double[] salaries = new[] { 25000.50, 45050.75, 24900, 56000 };
double totalSalary = 0;

foreach (double salaryAmount in salaries)
{
    totalSalary += salaryAmount;
}
Console.WriteLine("Total Salary Amount: " + totalSalary);
Console.WriteLine("Average Salary: " + (totalSalary / 4));