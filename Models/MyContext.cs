using Microsoft.EntityFrameworkCore; 
    namespace BankAccount.Models
    {
        public class MyContext : DbContext
        {
            public MyContext(DbContextOptions options) : base(options) { }
            
						// This is where the models go
            public DbSet<User> Users {get;set;}

            public DbSet<Transaction> Transactions {get;set;}
        }
    }