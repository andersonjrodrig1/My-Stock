using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SistemaVenda.Dominio.Interface;
using SistemaVenda.Dominio.Repositorio;
using SistemaVenda.Dominio.Servicos;
using SistemaVenda.Interface;
using SistemaVenda.Repositorio;
using SistemaVenda.Repositorio.Repositorio;
using SistemaVenda.Servico;

namespace SistemaVenda
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var connectionString = Configuration.GetConnectionString("MyStock");

            services.AddDbContext<ApplicationDbContext>(options => options.UseLazyLoadingProxies().UseSqlServer(connectionString));

            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddScoped<IUsuarioServicoApp, UsuarioServicoApp>();
            services.AddScoped<ICategoriaServicoApp, CategoriaServicoApp>();

            services.AddScoped<IUsuarioServico, UsuarioServico>();
            services.AddScoped<ICategoriaServico, CategoriaServico>();

            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorioImpl>();
            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorioImpl>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
