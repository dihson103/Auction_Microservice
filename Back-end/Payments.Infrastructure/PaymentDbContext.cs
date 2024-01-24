using Microsoft.EntityFrameworkCore;
using Payments.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Infrastructure
{
    public class PaymentDbContext : DbContext
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> option)
            : base(option)
        {

        }

        public DbSet<PaymentHistory> PaymentHistories { get; set; }
    }
}
