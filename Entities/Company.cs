using AbstractMethods2.Entities;

namespace AbstractMethods2.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualincome, int numberOfEmployees) : base(name, annualincome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double CalculateTax()
        {
            if (NumberOfEmployees > 10) 
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
