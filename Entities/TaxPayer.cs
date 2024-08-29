namespace AbstractMethods2.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayer() { }

        protected TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double CalculateTax();
    }
}
