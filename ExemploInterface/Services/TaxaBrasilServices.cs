namespace ExemploInterface.Services
{
    class TaxaBrasilServices : ITaxaService
    {
        public double Taxa(double amount) 
        {
            if (amount <= 100.0)
            {
                return amount * 0.2; 
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
