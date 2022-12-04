using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para criar Migrações
            //Data Source=B2C-SPMP-17;Initial Catalog=API_DDD;Integrated Security=True

            var connectionString = "Data Source=B2C-SPMP-17;Initial Catalog=API_DDD;Integrated Security=True;Trust Server Certificate=true";
            //var connectionString = "Server=B2C-SPMP-17;Initial Catalog=API_DDD1;TrustServerCertificate=false; EnableRetryOnFailure;  User ID=sa;Password=qwe@1234";
            //var connectionString = "Server = B2C - SPMP - 17.com; Database = API_DDD1; user id = sa; Password = qwe@1234";
            //var connectionString = "data source=localhost;initial catalog = API_DDD; persist security info = True;Integrated Security = SSPI; ";
            //var connectionString = "Data Source = B2C-SPMP-17;Initial Catalog = API_DDD;Integrated Security = True";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);

             
        }
    }
}
