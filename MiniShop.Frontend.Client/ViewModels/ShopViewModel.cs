using MiniShop.Frontend.Client.Dtos;
using MiniShop.Frontend.Client.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Frontend.Client.ViewModels
{
    public class ShopViewModel : BindableBase
    {
        IEventAggregator ea;

        public DelegateCommand<string> ExecuteCommand { get; private set; }

        private ShopDto shopDto;
        public ShopDto ShopDto
        {
            get { return shopDto; }
            set { shopDto = value; RaisePropertyChanged(); }
        }

        public ShopViewModel(IEventAggregator ea)
        {
            #region datainit
            ShopDto = new ShopDto()
            {
                ShopPreviousBillDto = new ShopPreviousBillDto(),
                ShopVipDto = new ShopVipDto(),
                ShopItemDtos = new ObservableCollection<ShopItemDto>(),
            };

            ShopDto.Amount = 123;
            ShopDto.Number = 10;

            ShopDto.ShopPreviousBillDto.BillNo = "1111111111111";
            ShopDto.ShopPreviousBillDto.Receivable = 1;
            ShopDto.ShopPreviousBillDto.Realreceivable = 1;
            ShopDto.ShopPreviousBillDto.GiveChange = 1;

            ShopDto.ShopVipDto.Name = "张三";
            ShopDto.ShopVipDto.Phone = "188888888888";
            ShopDto.ShopVipDto.Remain = 100;
            ShopDto.ShopVipDto.Integral = 1000;

            ShopDto.ShopItemDtos.Add(new ShopItemDto { 
                Id = 1,
                Name = "哈哈哈",
                Code = "1234567890123",
                Price = 10,
                Number = 1,
                Amount = 10,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 2,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 3,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 4,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 5,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 6,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 7,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 8,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 9,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 10,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 11,
                Name = "哈哈哈",
                Code = "1234567890123",
                Price = 10,
                Number = 1,
                Amount = 10,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 12,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 13,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 14,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 15,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 16,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 17,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 18,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 19,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 20,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 21,
                Name = "哈哈哈",
                Code = "1234567890123",
                Price = 10,
                Number = 1,
                Amount = 10,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 22,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 23,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 24,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 25,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 26,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 27,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 28,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 29,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            ShopDto.ShopItemDtos.Add(new ShopItemDto
            {
                Id = 30,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
            });
            #endregion

            this.ea = ea;
            ExecuteCommand = new DelegateCommand<string>(Execute);
            this.ea.GetEvent<ItemSentToShopEvent>().Subscribe(ItemReceived);
        }


        private void Execute(string obj)
        {
            switch (obj)
            {
                case "AllCancel": AllCancel(); break;
                case "PageUp": PageUp(); break;
                case "PageDown": PageDown(); break;
                case "Vip": Vip(); break;
                case "SettleAccounts": SettleAccounts(); break;
            }
        }

        private void AllCancel()
        {
            ShopDto.ShopItemDtos.Clear();
        }

        private void PageUp()
        { 
        }

        private void PageDown()
        {
        }

        private void Vip()
        {
        }

        private void SettleAccounts()
        {
        }

        private void ItemReceived(ShopItemDto item)
        {
            ShopDto.ShopItemDtos.Add(item);
        }
    }
}
