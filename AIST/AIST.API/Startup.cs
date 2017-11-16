using AIST.DataAccess.AISTDatabaseContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AIST.API
{
    public class Startup
    {
        private DbContextOptionsBuilder<DataAccessDbContext> optionsBuilder;
        private string connectionString = "Server=???;Database=AISTDB;User Id=???; Password=???;Trusted_Connection=True;MultipleActiveResultSets=true";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            optionsBuilder = new DbContextOptionsBuilder<DataAccessDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            services.AddDbContext<DataAccessDbContext>(opt => opt.UseSqlServer(connectionString));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
