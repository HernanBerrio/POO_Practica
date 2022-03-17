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
Console.WriteLine(employee1);
Console.WriteLine("=================================================================");


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
Console.WriteLine(employee2);
Console.WriteLine("=================================================================");