using MiniShop.Frontend.Client.Common;
using MiniShop.Frontend.Client.Extensions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Frontend.Client.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel(IRegionManager regionManager)
        {
            CreateMenuBar();
            this.regionManager = regionManager;
            NavigateCommand = new DelegateCommand<MenuBar>(Navigate);
            GoBackCommand = new DelegateCommand(() =>
            {
                if(journal != null && journal.CanGoBack)
                    journal.GoBack();
            });
            GoForwardCommand = new DelegateCommand(() => {
                if (journal != null && journal.CanGoForward)
                    journal.GoForward();
            });
        }

        private void Navigate(MenuBar obj)
        {
            if (obj == null || string.IsNullOrEmpty(obj.NameSpace))
                return;     
            regionManager.Regions[PrismManager.MainViewRegionName].RequestNavigate(obj.NameSpace, back => {
                journal = back.Context.NavigationService.Journal;
            });
        }

        public DelegateCommand<MenuBar> NavigateCommand { get; }
        public DelegateCommand GoBackCommand { get; }
        public DelegateCommand GoForwardCommand { get; }

        private readonly IRegionManager regionManager;
        private IRegionNavigationJournal journal;

        private ObservableCollection<MenuBar> menuBars;
        public ObservableCollection<MenuBar> MenuBars 
        {
            get { return menuBars;}
            set { menuBars = value; RaisePropertyChanged();}
        }

        void CreateMenuBar()
        {
            MenuBars = new ObservableCollection<MenuBar>();
            MenuBars.Add(new MenuBar { Icon = "Home", Title = "收银", NameSpace = "CashierView" });
            MenuBars.Add(new MenuBar { Icon = "FileArrowLeftRight", Title = "查交易", NameSpace = "CheckDealView" });
            MenuBars.Add(new MenuBar { Icon = "Vhs", Title = "查库存", NameSpace = "CheckStockView" });
            MenuBars.Add(new MenuBar { Icon = "Cog", Title = "设置", NameSpace = "SettingView" });
        }
    }
}
