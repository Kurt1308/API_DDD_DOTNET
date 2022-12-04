using Data.Context;
using Data.Repository;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>)); 
            //serviceCollection.AddDbContext<MyContext>(options => options.UseSqlServer("Server=B2C-SPMP-17;Initial Catalog=API_DDD1;EnableRetryOnFailure; TrustServerCertificate=true; User ID=sa;Password=qwe@1234"));
            //serviceCollection.AddDbContext<MyContext>(options => options.UseSqlServer("Server=B2C-SPMP-17;Initial Catalog=API_DDD1; UseSqlServer; TrustServerCertificate=true; User ID=sa;Password=qwe@1234"));
            serviceCollection.AddDbContext<MyContext>(options => options.UseSqlServer("Data Source=B2C-SPMP-17;Initial Catalog=API_DDD;Integrated Security=True;Trust Server Certificate=true"));
        }
    }
}
