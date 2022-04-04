// See https://aka.ms/new-console-template for more information


using SalesSystem;

Console.WriteLine("=============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Paula",
    LastName = "chocano",
    BirthDate = new Date(1990, 01, 22),
    HiringDate = new Date(1990, 01, 22),
    IsActive = true,
    Salary = 1825369
};

Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 1010,
    FirstName = "Lucia",
    LastName = "Mendieta",
    BirthDate = new Date(1996, 01, 22),
    HiringDate = new Date(2021, 01, 1),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};

Console.WriteLine(employee2);