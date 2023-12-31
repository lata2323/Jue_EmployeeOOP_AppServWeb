﻿// See https://aka.ms/new-console-template for more information
using EmployeeOOP.Classes;

try
{
    int day, month, year, hours;
    string firstName, lastName;
    decimal salary, commissionPercentaje, sales, hourValue;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    #region SalaryEmployee
    //Código para SalaryEmployee
    /*Console.Write("Ingresar nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };

    Console.WriteLine(salaryEmployee);*/
    #endregion

    #region CommissionEmployee
    //Código para CommissionEmployee
    /*Console.Write("Ingresar nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar el porcentaje de la comisión: ");
    commissionPercentaje = Decimal.Parse(Console.ReadLine());

    Console.Write("Ingresar el valor de las ventas: ");
    sales = Decimal.Parse(Console.ReadLine());

    CommissionEmployee commissionEmployee = new CommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        CommissionPercentaje = commissionPercentaje,
        Sales = sales,
    };

    Console.WriteLine(commissionEmployee);*/

    #endregion

    #region HourlyEmployee

    Console.Write("Ingresar nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar las horas laboradas: ");
    hours = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el valor de la hora: ");
    hourValue = Decimal.Parse(Console.ReadLine());

    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Hours = hours,
        HourValue = hourValue,
    };

    Console.WriteLine(hourlyEmployee);

    #endregion
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}