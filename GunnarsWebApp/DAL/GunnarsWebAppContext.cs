using GunnarsWebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GunnarsWebApp.DAL
{
    public class GunnarsWebAppContext : DbContext
    {
        public GunnarsWebAppContext() : base("GunnarsWebAppContext")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public System.Data.Entity.DbSet<GunnarsWebApp.Models.SubmissionModel> SubmissionModels { get; set; }
    }
}
