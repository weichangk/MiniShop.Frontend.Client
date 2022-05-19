using MiniShop.Frontend.Client.Common;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Frontend.Client.ViewModels
{
    public class CashierOperViewModel : BindableBase
    {
        public CashierOperViewModel()
        {
            CreateCashierOperBar();
            CashierOperCommand = new DelegateCommand<CashierOperBar>(CashierOper);
        }

        private void CashierOper(CashierOperBar obj)
        {
            if (obj == null || string.IsNullOrEmpty(obj.NameSpace))
                return;
        }

        public DelegateCommand<CashierOperBar> CashierOperCommand { get; }


        private ObservableCollection<CashierOperBar> cashierOperBars;
        public ObservableCollection<CashierOperBar> CashierOperBars
        {
            get { return cashierOperBars; }
            set { cashierOperBars = value; RaisePropertyChanged(); }
        }

        void CreateCashierOperBar()
        {
            cashierOperBars = new ObservableCollection<CashierOperBar>();
            cashierOperBars.Add(new CashierOperBar { Icon = "Home", Title = "结账", NameSpace = "CashierView" });
            cashierOperBars.Add(new CashierOperBar { Icon = "FileArrowLeftRight", Title = "会员", NameSpace = "CheckDealView" });
            cashierOperBars.Add(new CashierOperBar { Icon = "Vhs", Title = "优惠", NameSpace = "CheckStockView" });
            cashierOperBars.Add(new CashierOperBar { Icon = "Cog", Title = "退货", NameSpace = "SettingView" });
            cashierOperBars.Add(new CashierOperBar { Icon = "Cog", Title = "挂单", NameSpace = "SettingView" });
            cashierOperBars.Add(new CashierOperBar { Icon = "Cog", Title = "赠送", NameSpace = "SettingView" });
            cashierOperBars.Add(new CashierOperBar { Icon = "Cog", Title = "修改", NameSpace = "SettingView" });
            cashierOperBars.Add(new CashierOperBar { Icon = "Cog", Title = "更多", NameSpace = "SettingView" });
        }

    }
}
