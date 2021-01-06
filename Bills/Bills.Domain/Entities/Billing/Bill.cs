using Bills.Domain.ValueObjects;

namespace Bills.Domain
{
    /// <summary>
    /// Represents the basic bill properties
    /// </summary>
    public abstract class Bill
    {
        public decimal TotalToPay { get; private set; }
        public Document RecipientIdentification { get; private set; }
        public Address RecipientAddress { get; private set; }
    }
}
