using Bills.Domain.Enums;

namespace Bills.Domain.Entities
{
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
