using MiniShop.Frontend.Client.ViewModels;
using MiniShop.Frontend.Client.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
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
            containerRegistry.RegisterForNavigation<CashierView, CashierViewModel>();
            containerRegistry.RegisterForNavigation<ShopView, ShopViewModel>();
            containerRegistry.RegisterForNavigation<CategoryView, CategoryViewModel>();
            containerRegistry.RegisterForNavigation<ItemsView, ItemsViewModel>();

            containerRegistry.RegisterForNavigation<CheckDealView, CheckDealViewModel>();
            containerRegistry.RegisterForNavigation<CheckStockView, CheckStockViewModel>();
            containerRegistry.RegisterForNavigation<SettingView, SettingViewModel>();
        }
    }
}
