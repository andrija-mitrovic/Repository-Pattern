using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.Repository
{
    public interface IPaymentRecordRepository
    {
        IEnumerable<PaymentRecord> GetAll();
        PaymentRecord GetById(int id);
        void Add(PaymentRecord paymentRecord);
        void Delete(int id);
        void Update(PaymentRecord paymentRecord);
    }
}
