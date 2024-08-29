using System;
using AbstractMethods2.Entities;

namespace AbstractMethods2.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditure { get; set; }

        public Individual() { }

        public Individual(string name, double annualincome, double healthExpenditure) : base(name, annualincome) 
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double CalculateTax()
        {
            if (AnnualIncome >= 20000) 
            {
                return (AnnualIncome * 0.25) - (HealthExpenditure * 0.50);
            }
            else
            {
                return (AnnualIncome * 0.15) - (HealthExpenditure * 0.50);
            }
        }
    }
}
