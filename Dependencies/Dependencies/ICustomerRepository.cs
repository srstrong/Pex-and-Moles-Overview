namespace Dependencies
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int customerId);
    }
}