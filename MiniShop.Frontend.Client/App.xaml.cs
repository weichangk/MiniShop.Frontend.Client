using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniShop.Frontend.Client.DbContexts;
using MiniShop.Frontend.Client.ViewModels;
using MiniShop.Frontend.Client.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MiniShop.Frontend.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CashierDeskView, CashierDeskViewModel>();
            containerRegistry.RegisterForNavigation<CheckDealView, CheckDealViewModel>();
            containerRegistry.RegisterForNavigation<CheckStockView, CheckStockViewModel>();
            containerRegistry.RegisterForNavigation<SettingView, SettingViewModel>();
        }


        protected override IContainerExtension CreateContainerExtension()
        {
            var serviceCollection = new ServiceCollection();

            //register configuration
            IConfigurationBuilder cfgBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            IConfiguration configuration = cfgBuilder.Build();
            serviceCollection.AddSingleton<IConfiguration>(configuration);

            //register logger
            var serilogLogger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)// 将配置传给 Serilog 的提供程序 
                .Enrich.FromLogContext()//记录相关上下文信息 
                .WriteTo.File("")
                .CreateLogger();
            serviceCollection.AddSingleton<ILogger>(serilogLogger);

            //register ORM
            serviceCollection.AddChimp<AppDbContext>(opt => opt.UseLazyLoadingProxies().UseSqlite($@"DataSource={Environment.CurrentDirectory}\Data\Shop.db"));
            using (var context = serviceCollection.BuildServiceProvider().GetService<AppDbContext>())
            {
                context.Database.Migrate();
            }
            //AutoMapper
            serviceCollection.AddAutoMapper(typeof(Dtos.Profiles.AutoMapperProfiles).Assembly);

            return new DryIocContainerExtension(new Container(CreateContainerRules()).WithDependencyInjectionAdapter(serviceCollection));
        }
    }
}
