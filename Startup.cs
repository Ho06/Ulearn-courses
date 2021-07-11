using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.BL.Interface;
using ULearn.BL.Repository;
using ULearn.DataBase;
using ULearn.Mapper;
using ULearn.Models;

namespace ULearn
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
            services.AddControllersWithViews();
            services.AddAutoMapper(x => x.AddProfile(new ULearnMapper()));
            services.AddDbContextPool<Dbcontainner>(opt => opt.UseSqlServer(Configuration.GetConnectionString("conn")));
            services.AddControllersWithViews().AddNewtonsoftJson(opt =>
            {
                opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
            services.AddSession();
            services.AddControllersWithViews();
            //var con = Configuration.GetConnectionString("conn");
            //services.AddDbContext<ULearnContext>(options=>options.UseSqlServer(con));
            services.AddIdentity<IdentityUser, IdentityRole>()
             .AddDefaultTokenProviders()
             .AddDefaultUI()
             .AddEntityFrameworkStores<Dbcontainner>();

            // Scoped
            services.AddScoped<ICategoryRep, CategoryRep>();
            services.AddScoped<ICourseRep, CourseRep>();
            services.AddScoped<IStudentRep, StudentRep>();
            services.AddScoped<ILearnListRep, LearnListRep>();
            services.AddScoped<ILearnCrsRep, LearnCrsRep>();
            services.AddScoped<IVideoRep, VideoRep>();
            services.AddScoped<IVideoRep, VideoRep>();
            services.AddScoped<IWashListRep, WashListRep>();



            services.AddRazorPages();

            //services.AddAuthentication().AddFacebook(facebookOptions =>
            //{
            //    facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
            //    facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            //});
        }
        // Data Source=mra\sqlexpress;Initial Catalog=ULearn;Persist Security Info=True;User ID=sa;Password=***********
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            //strip
           

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
