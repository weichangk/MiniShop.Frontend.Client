using MiniShop.Frontend.Client.Dtos;
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
        private ShopDto shopDto;

        public ShopDto ShopDto
        {
            get { return shopDto; }
            set { shopDto = value; RaisePropertyChanged(); }
        }

        public ShopViewModel()
        {
            ShopDto = new ShopDto()
            {
                ShopPreviousBillDto = new ShopPreviousBillDto(),
                ShopVipDto = new ShopVipDto(),
                ShopItemDtos = new ObservableCollection<ShopItemDto>(),
            };

            ShopDto.Amount = 123;
            shopDto.Number = 10;

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
                Id = 92,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
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
                Id = 2,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
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
                Id = 2,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
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
                Id = 2,
                Name = "哈哈哈",
                Code = "6699663355114",
                Price = 9999.99M,
                Number = 9999.99M,
                Amount = 1013.01M,
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

        }
    }
}
