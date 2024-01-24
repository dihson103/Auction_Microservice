using AuctionItems.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionItems.Infrastructure
{
    public class AuctionItemDbContext : DbContext
    {
        public AuctionItemDbContext(DbContextOptions<AuctionItemDbContext> options)
            : base(options) { }

        public DbSet<AuctionItem> AuctionItems { get; set; }
    }
}
