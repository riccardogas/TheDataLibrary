using Microsoft.EntityFrameworkCore;
using System;
using TheDataLibrary.DBModels;

namespace TheDataLibrary.DBModels
{
    public class TheRightContext : TestContext
    {
        public TheRightContext()
        {
        }

        public TheRightContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

      
    }

}
