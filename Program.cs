using System;
using System.Globalization;
using System.Collections.Generic;
using AbstractMethods2.Entities;

namespace AbstractMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c): ");
                char answer = char.Parse(Console.ReadLine());

                if (answer == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditure: ");
                    double healthExpenditure = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    taxPayers.Add(new Individual(name, annualIncome, healthExpenditure));
                } else if (answer == 'c') {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    taxPayers.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }

            double totalTax = 0;

            Console.WriteLine();
            Console.WriteLine("TAXEX PAID");

            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer.Name + ": " + taxPayer.CalculateTax().ToString("F2", CultureInfo.InvariantCulture));
                totalTax = totalTax + taxPayer.CalculateTax();
            }

            Console.WriteLine();
            Console.WriteLine("Total Taxes: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
