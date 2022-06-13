﻿using Microsoft.Extensions.Configuration;
using MiniShop.Frontend.Client.Common;
using MiniShop.Frontend.Client.Dtos;
using MiniShop.Frontend.Client.Extensions;
using MiniShop.Frontend.Client.HttpApis;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Frontend.Client.ViewModels
{
    public class LoginViewModel : BindableBase, IDialogAware
    {
        public string Title { get; set; } = "Shop";

        public event Action<IDialogResult> RequestClose;

        private readonly IEventAggregator aggregator;
        private readonly IConfiguration configuration;
        private readonly IItemApi itemApi;
        private readonly ICategorieApi categorieApi;
        private readonly IUnitApi unitApi;

        public DelegateCommand<string> ExecuteCommand { get; private set; }

        public LoginViewModel(IEventAggregator aggregator, 
            IConfiguration configuration,
            IItemApi itemApi,
            ICategorieApi categorieApi,
            IUnitApi unitApi)
        {
            this.aggregator = aggregator;
            this.configuration = configuration;
            this.itemApi = itemApi;
            this.categorieApi = categorieApi;
            this.unitApi = unitApi;
            ExecuteCommand = new DelegateCommand<string>(Execute);
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            LoginOut();
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            
        }




        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(); }
        }

        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; RaisePropertyChanged(); }
        }

        private string progressBarVisibility = "Hidden";//Visible/Hidden

        public string ProgressBarVisibility
        {
            get { return progressBarVisibility; }
            set { progressBarVisibility = value; }
        }

        private int progressBarValue = 60;

        public int ProgressBarValue
        {
            get { return progressBarValue; }
            set { progressBarValue = value; }
        }

        private void Execute(string obj)
        {
            switch (obj)
            {
                case "Login": Login(); break;
                case "LoginOut": LoginOut(); break;
            }
        }

        private async void Login()
        {
            UserDto user = new UserDto
            {
                UserName = UserName,
                PassWord = PassWord,
            };
            string error = "";
            bool loginSuccess = await LoginApi.AccessTokenAsync(user, configuration, error);
            if (loginSuccess)
            {
                ProgressBarVisibility = "Visible";

                progressBarValue = 10;
                await DownloadCategorieData();
                progressBarValue = 20;
                await DownloadUnitData();
                progressBarValue = 30;
                await DownloadItemDataAsync();
                progressBarValue = 40;

                RequestClose?.Invoke(new DialogResult(ButtonResult.OK));

            }
            else
            {
                //登录失败提示...
                aggregator.SendMessage(error, "Login");
            }

        }

        private void LoginOut()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.No));
        }

        private async Task DownloadCategorieData()
        {
            var result = await ExecuteApi.ExecuteApiAsync(() => { return categorieApi.GetListAllByShopIdAsync(UserInfo.ShopId); });
        }

        private async Task DownloadUnitData()
        {
            var result = await ExecuteApi.ExecuteApiAsync(() => { return unitApi.GetListAllByShopIdAsync(UserInfo.ShopId); });
        }

        private async Task DownloadItemDataAsync()
        {
            var result = await ExecuteApi.ExecuteApiAsync(() => { return itemApi.GetListAllByShopIdAsync(UserInfo.ShopId); });
        }
    }
}
