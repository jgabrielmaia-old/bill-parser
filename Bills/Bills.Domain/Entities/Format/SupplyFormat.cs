using System.Collections.Generic;

namespace Bills.Domain.Entities
{
    /// <summary>
    /// Generic schema to represent a supply format of a specific type of bill
    /// If it is part of a larger schema, indicates which one is the next
    /// </summary>
    public class SupplyFormat
    {
        public Dictionary<string, string> Schema { get; set; }

        public bool IsChunk { get; set; }

        public int ChunkIdentifier { get; set; }

        public int? Next { get; set; }

    }
}
