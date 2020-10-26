using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewPrepApp.Data;
using InterviewPrepApp.Models;
using InterviewPrepApp.Models.Interface;
using InterviewPrepApp.Models.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace InterviewPrepApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Config = configuration;
        }

        public IConfiguration Config { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<QuestionsDbContext>(options =>
            {
                options.UseSqlServer(Config.GetConnectionString("DefaultConnection"));
            });

            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<QuestionsDbContext>()
                    .AddDefaultTokenProviders();

            services.AddControllers(options =>
            {
                options.Filters.Add(new AuthorizeFilter());
            });


            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Config["JWTIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Config["JWTKey"]))
                };
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("NiccoOnly", policy => policy.RequireRole(ApplicationRoles.Nicco));
                options.AddPolicy("Admins", policy => policy.RequireRole(ApplicationRoles.Nicco, ApplicationRoles.Admin));
                options.AddPolicy("Contributors", policy => policy.RequireRole(ApplicationRoles.Nicco, ApplicationRoles.Admin, ApplicationRoles.Contributor));
            });

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 3;
            });

            services.AddTransient<ITechnicalQ, TechnicalQRepository>();
            services.AddTransient<IBehavioralQ, BehavioralQRepository>();
            services.AddTransient<IWhiteboardQ, WhiteboardQRepository>();
            services.AddTransient<ITraversal, TraversalRepository>();
            services.AddTransient<IQuiz, QuizRepository>();
            services.AddTransient<IComment, CommentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseRouting();

            app.UseCors("AllowAll");

            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            RoleInitializer.SeedRoles(serviceProvider, userManager, Config);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
