using QubixCinema.DataAccess;
using QubixCinema.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QubixCinema.Business.Services
{
    public class RegisterService
    {
        private readonly QubixCinemaContext _context;

        public RegisterService(QubixCinemaContext context)
        {
            _context = context;
        }

        public List<Register> GetAllTransactions()
        {
            return _context.Registers.OrderByDescending(r => r.TransactionDate).ToList();
        }

        public void AddTransaction(decimal amount, string description)
        {
            var entry = new Register
            {
                Amount = amount,
                Description = description,
                TransactionDate = DateTime.Now
            };

            _context.Registers.Add(entry);
            _context.SaveChanges();
        }

        public decimal GetDailyRevenue()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            return _context.Registers
                .Where(r => r.TransactionDate >= today && r.TransactionDate < tomorrow)
                .Select(r => (decimal?)r.Amount)
                .DefaultIfEmpty(0)
                .Sum() ?? 0;
        }

        public decimal GetTotalRevenue()
        {
            return _context.Registers
                .Select(r => (decimal?)r.Amount)
                .DefaultIfEmpty(0)
                .Sum() ?? 0;
        }

        public string CloseDay()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            
            var transactions = _context.Registers
                .Where(r => r.TransactionDate >= today && r.TransactionDate < tomorrow)
                .ToList();

            decimal totalDailyRevenue = transactions.Select(t => t.Amount).Sum();
            int totalDailyCount = transactions.Count;

            string closingDescription = $"Daily Closing - Revenue: ${totalDailyRevenue:F2} - Transactions: {totalDailyCount}";

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Add a closing entry (amount is 0 as it's a summary record)
                    var closingEntry = new Register
                    {
                        Amount = 0,
                        Description = closingDescription,
                        TransactionDate = DateTime.Now
                    };

                    _context.Registers.Add(closingEntry);
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }

            return closingDescription;
        }
    }
}
