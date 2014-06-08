namespace ShapeBankAndException.Bank
{
    public class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
