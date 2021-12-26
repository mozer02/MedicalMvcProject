using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MdContext : DbContext
    {
        public DbSet<StockStatus> StockStatuses { get; set; }
        public DbSet<BillEntry> BillEntries { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Currents> Currents { get; set; }
        public DbSet<CurrentGroups> CurrentGroups { get; set; }
        public DbSet<Citys> Citys { get; set; }
        public DbSet<CurrentTitles> CurrentTitles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockStatus>()
                .MapToStoredProcedures();
            modelBuilder.Entity<BillEntry>()
                .MapToStoredProcedures();
            modelBuilder.Entity<BillDetail>()
                .MapToStoredProcedures();
            modelBuilder.Entity<Product>()
                .MapToStoredProcedures();
            modelBuilder.Entity<EmployeeDetail>()
                .MapToStoredProcedures();
            modelBuilder.Entity<Departments>()
                .MapToStoredProcedures();
            modelBuilder.Entity<Currents>()
                .MapToStoredProcedures();
            modelBuilder.Entity<CurrentGroups>()
                .MapToStoredProcedures();
            modelBuilder.Entity<Citys>()
                .MapToStoredProcedures();
            modelBuilder.Entity<CurrentTitles>()
                .MapToStoredProcedures();
        }
    }
}
