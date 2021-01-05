using Bills.Domain.ValueObjects;

namespace Bills.Domain
{
    public abstract class Bill
    {
        public int TotalToPay { get; private set; }
        public Document RecipientIdentification { get; private set; }
        public Address RecipientAddress { get; private set; }
    }
}
