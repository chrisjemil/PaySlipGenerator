namespace PaySlipGenerator.Services
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}