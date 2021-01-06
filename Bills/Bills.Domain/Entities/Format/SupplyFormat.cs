using System.Collections.Generic;

namespace Bills.Domain.Entities
{
    public class SupplyFormat
    {
        public Dictionary<string, string> Schema { get; set; }

        public bool IsChunk { get; set; }

        public int ChunkIdentifier { get; set; }
    }
}
