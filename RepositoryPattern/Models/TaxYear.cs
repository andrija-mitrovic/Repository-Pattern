using System.Collections.Generic;

namespace RepositoryPattern.Models
{
    public class TaxYear
    {
        public int Id { get; set; }
        public string YearOfTax { get; set; }
        public IEnumerable<PaymentRecord> PaymentRecords { get; set; }
    }
}