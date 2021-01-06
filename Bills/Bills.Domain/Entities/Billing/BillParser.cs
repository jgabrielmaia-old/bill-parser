namespace Bills.Domain.Entities
{
    /// <summary>
    /// Parses a Bill given a supply format type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BillParser<T>
    {
        public T SupplyFormat { get; set; }

        public abstract Bill Parse();
    }
}
