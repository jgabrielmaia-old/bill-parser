namespace Bills.Domain.Entities
{
    public abstract class BillParser<T>
    {
        public T SupplyFormat { get; set; }

        public abstract Bill Parse();
    }
}
