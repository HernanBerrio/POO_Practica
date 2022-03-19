using POO_Practica;


Console.WriteLine("Programacion orienrada a objetos !");
Console.WriteLine("==================================");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M //Se le pone M al final representa money-----------------------------------
};
//Console.WriteLine(employee1);
//Console.WriteLine("=================================================================");


Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1985, 6, 23),
    HiringDate = new Date(2022, 3, 15),
    IsActive = true,
    Sales = 320000000M,
    CommisionPercentaje = 0.03F
};
//Console.WriteLine(employee2);
//Console.WriteLine("=================================================================");

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date(1990, 7, 25),
    HiringDate = new Date(2020, 11, 11),
    IsActive = true,
    HourValue = 123456.56M,
    Hours = 123.5F
};
//Console.WriteLine(employee3);
//Console.WriteLine("=================================================================");

Employee employee4 = new BaseCommissionEmploye()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(1988, 7, 25),
    HiringDate = new Date(2020, 3, 18),
    IsActive = true,
    Base = 846678.45M,
    Sales = 58000000M,
    CommisionPercentaje = 0.015F

};
//Console.WriteLine(employee4);
//Console.WriteLine("=================================================================");

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("                               ==================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
