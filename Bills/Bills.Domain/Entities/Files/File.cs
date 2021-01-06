using Bills.Domain.Enums;

namespace Bills.Domain.Entities
{
    /// <summary>
    /// Abstraction of physical representation of the bill
    /// If it is part of a file collection, points to the next chunk to be rendered
    /// </summary>
    public class File
    {
        public int BillId { get; set; }
        public EBillType Type { get; set; }
        public bool IsChunk { get; set; }
        public int? ChunkIdentifier { get; set; }
        public int? Next { get; set; }
        public string Content { get; set; }
    }
}
