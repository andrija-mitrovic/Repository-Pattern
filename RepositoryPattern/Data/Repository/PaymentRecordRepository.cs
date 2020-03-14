using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.Repository
{
    public class PaymentRecordRepository : IPaymentRecordRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(PaymentRecord paymentRecord)
        {
            _context.PaymentRecords.Add(paymentRecord);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var paymentRecord = GetById(id);
            _context.PaymentRecords.Remove(paymentRecord);
        }

        public IEnumerable<PaymentRecord> GetAll() => _context.PaymentRecords.ToList();

        public PaymentRecord GetById(int id) => _context.PaymentRecords.Find(id);

        public void Update(PaymentRecord paymentRecord)
        {
            _context.PaymentRecords.Update(paymentRecord);
            _context.SaveChanges();
        }
    }
}
