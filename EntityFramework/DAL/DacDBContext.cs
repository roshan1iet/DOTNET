
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using EntityFramework.Models;


namespace EntityFramework.DAL
{
    public class DacDBContext : DbContext
    {

        public DbSet<Employee> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //a Service for - To read appsettings.json config file
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            string connectionString = config.GetConnectionString("conStr");

            //Databse Provider Service Register
            optionsBuilder.UseSqlServer(connectionString);
        }

        public Employee GetEmployeeById(int id)
        {
            var idParam=new SqlParameter("@Id",id);
            return employees.FromSqlRaw("EXEC GetEmployeeById @Id", idParam).AsEnumerable().FirstOrDefault();



        }

        public List<Employee> GetEmployeesByAddressStartWith(string Startletter)
        {
            var startLetterParam=new SqlParameter("@StartLetter", Startletter);
            return employees.FromSqlRaw("EXEC GetEmployeeByAddressStartWith@Startletter",startLetterParam).AsEnumerable().ToList();
        }

    }
    





    
}
