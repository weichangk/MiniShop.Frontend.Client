using MiniShop.Frontend.Client.Common;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Frontend.Client.ViewModels
{
    public class MainWindowModel : BindableBase
    {
        public MainWindowModel()
        {
            CreateMenuBar();
        }

        private ObservableCollection<MenuBar> menuBars;
        public ObservableCollection<MenuBar> MenuBars 
        {
            get { return menuBars;}
            set { menuBars = value; RaisePropertyChanged();}
        }

        void CreateMenuBar()
        {
            MenuBars.Add(new MenuBar { Icon = "Home", Title = "收银", NameSpace = "CashierView" });
            MenuBars.Add(new MenuBar { Icon = "FileArrowLeftRight", Title = "查交易", NameSpace = "CheckDealView" });
            MenuBars.Add(new MenuBar { Icon = "Vhs", Title = "查库存", NameSpace = "CheckStockView" });
            MenuBars.Add(new MenuBar { Icon = "Cog", Title = "设置", NameSpace = "SettingView" });
        }
    }
}
