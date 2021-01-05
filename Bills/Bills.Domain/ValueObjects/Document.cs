using Bills.Domain.Enums;
using System;

namespace Bills.Domain.ValueObjects
{
    /// <summary>
    /// Identification document for a person or company
    /// </summary>
    public class Document
    {
        private const int CnpjLength = 14;
        private const int CpfLength = 11;

        public EDocumentType Type { get; set; }

        public string Number { get; set; }

        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            if (!IsValid())
                throw new Exception("Invalid document.");
        }

        private bool IsValid()
        {
            if (Type == EDocumentType.Cnpj && Number.Length == CnpjLength)
                return true;

            if (Type == EDocumentType.Cpf && Number.Length == CpfLength)
                return true;

            return false;
        }
    }
}
