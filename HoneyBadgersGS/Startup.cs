using HoneyBadgers._0.BusinessLogic;
using HoneyBadgers._0.Data;
using HoneyBadgers._0.DataLayers;
using HoneyBadgers._0.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HoneyBadgers._0
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

<<<<<<< HEAD
		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));
			//add the context for the honeybadger database
			services.AddDbContext<HoneyBadgerContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("HoneyBadgersDBConnection")));
=======
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            //add the context for the honeybadger database
            services.AddDbContext<HoneyBadgerDBContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("HoneyBadgersDBConnection")));
>>>>>>> Sprint-3

            services.AddDefaultIdentity<ApplicationUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentityServer()
                .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

            services.AddAuthentication()
                .AddIdentityServerJwt();
            //Transient Services
            //Game
            services.AddTransient<IGameDal, GameDal>();
            services.AddTransient<IGameLogic, GameLogic>();
            //Profile
            services.AddTransient<IProfileDal, ProfileDal>();
            services.AddTransient<IProfileLogic, ProfileLogic>();
            //Reviews
            services.AddTransient<IReviewDal, ReviewDal>();
            services.AddTransient<IReviewLogic, ReviewLogic>();
            //Cart
            services.AddTransient<ICartDal, CartDal>();
            services.AddTransient<ICartLogic, CartLogic>();
<<<<<<< HEAD
			//Wishlist
			services.AddTransient<IWishlistDal, WishlistDal>();
			services.AddTransient<IWishlistLogic, WishlistLogic>();
			//Events
			services.AddTransient<IEventDal, EventDal>();
			services.AddTransient<IEventLogic, EventLogic>();
			//Friend List
			services.AddTransient<IFriendListDal, FriendListDal>();
			services.AddTransient<IFriendListLogic, FriendListLogic>();
            //Account
            //services.AddTransient<IAccountLogic, AccountLogic>();

            //Order
            services.AddTransient<IOrderDal, OrderDal>();
            services.AddTransient<IOrderLogic, OrderLogic>();

            services.AddControllersWithViews();
			services.AddRazorPages();
=======
            //Wishlist
            services.AddTransient<IWishlistDal, WishlistDal>();
            services.AddTransient<IWishlistLogic, WishlistLogic>();
            //Events
            services.AddTransient<IEventDal, EventDal>();
            services.AddTransient<IEventLogic, EventLogic>();
            //Friend List
            services.AddTransient<IFriendshipDal, FriendshipDal>();
            services.AddTransient<IFriendshipLogic, FriendshipLogic>();
            //Account
            services.AddTransient<IAccountDal, AccountDal>();
            services.AddTransient<IAccountLogic, AccountLogic>();
>>>>>>> Sprint-3

            services.AddControllersWithViews();
            services.AddRazorPages();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseIdentityServer();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
