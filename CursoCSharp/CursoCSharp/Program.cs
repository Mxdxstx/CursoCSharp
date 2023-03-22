
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
Employee employee2 = new CommissionEmployee()
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
Console.WriteLine(employee1);
Console.WriteLine(employee2);

Console.ReadLine();