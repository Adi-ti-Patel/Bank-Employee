using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class PaymentDetailContext : DbContext
    {

        public PaymentDetailContext(DbContextOptions options) : base(options)
        { }

        public DbSet<PaymentDetail> PaymentDetail { get; set; }
    }
}
