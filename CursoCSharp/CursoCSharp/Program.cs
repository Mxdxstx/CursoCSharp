
using CursoCSharp;

Console.WriteLine("Curso de C#");
Console.WriteLine("===========");

Employee employee1 = new SalaryEmployee()
{
    Id = 11010,
    FirstName = "Angel",
    LastName = "Modesto",
    BirthDate = new Date(1999, 12, 2),
    HiringDate = new Date(2023, 3, 20),
    IsActive = true,
    Salary = 105000.50M
};
Employee employee2 = new HourlyEmployee()
{
    Id = 23123,
    FirstName = "Miguel",
    LastName = "Saucedo",
    BirthDate = new Date(2002, 12, 7),
    HiringDate = new Date(2023, 1, 2),
    IsActive = true,
    HourValue = 12456.56M,
    Hours = 123.5F
};
Employee employee3 = new CommissionEmployee()
{
    Id = 11010,
    FirstName = "Pedro",
    LastName = "Martinez",
    BirthDate = new Date(1985, 1, 7),
    HiringDate = new Date(2023, 3, 13),
    IsActive = true,
    Sales = 500000M,
    CommissionPercentaje = 0.05F
};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(1992, 12, 10),
    HiringDate = new Date(2021, 12, 15),
    IsActive = true,
    Base = 2500M,
    CommissionPercentaje = 0.012F,
    Sales = 350000M
};

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3,employee4
};

decimal payroll = 0;
foreach(Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                               ==================");
Console.WriteLine($"TOTAL                             {$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone14",
    Id = 1,
    Price = 250000M,
    Quantity = 1
};
Invoice invoice2 = new Invoice()
{
    Description = "Carne premium",
    Id = 2,
    Price = 300,
    Quantity = 2.345F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);

Console.ReadLine();