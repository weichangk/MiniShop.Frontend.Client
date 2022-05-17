using MiniShop.Frontend.Client.Dtos;
using MiniShop.Frontend.Client.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Linq;

namespace MiniShop.Frontend.Client.ViewModels
{
    public class ItemsViewModel : BindableBase
    {
        IEventAggregator ea;
        public DelegateCommand<int?> SelectItemCommand { get; private set; }

        private ObservableCollection<ItemDto> itemDtos;
        public ObservableCollection<ItemDto> ItemDtos
        {
            get { return itemDtos; }
            set { itemDtos = value; RaisePropertyChanged(); }
        }

        private ShopItemDto selectItem;
        public ShopItemDto SelectItem
        {
            get { return selectItem; }
            set { selectItem = value; }
        }


        public ItemsViewModel(IEventAggregator ea)
        {
            
            ItemDtos = new ObservableCollection<ItemDto>
            {
                new ItemDto{ Id = 1, Code = "101", Name = "芙蓉王", Price = 1 },
                new ItemDto{ Id = 2, Code = "102", Name = "玉溪", Price = 2 },
                new ItemDto{ Id = 3, Code = "103", Name = "好日子", Price = 3 },
                new ItemDto{ Id = 4, Code = "104", Name = "红双喜", Price = 4 },
                new ItemDto{ Id = 5, Code = "105", Name = "七匹狼", Price = 5 },
                new ItemDto{ Id = 6, Code = "106", Name = "中华", Price = 6 },
                new ItemDto{ Id = 7, Code = "107", Name = "轿子", Price = 7 },
                new ItemDto{ Id = 8, Code = "108", Name = "利群", Price = 8 },
                new ItemDto{ Id = 9, Code = "109", Name = "真龙", Price = 9 },
                new ItemDto{ Id = 10, Code = "110", Name = "熊猫", Price = 10 },
                new ItemDto{ Id = 11, Code = "111", Name = "万宝路", Price = 11 },
                new ItemDto{ Id = 12, Code = "112", Name = "云烟", Price = 12 },
                new ItemDto{ Id = 13, Code = "113", Name = "黄鹤楼", Price = 13 },
                new ItemDto{ Id = 14, Code = "114", Name = "苹果", Price = 14 },
                new ItemDto{ Id = 15, Code = "115", Name = "香蕉", Price = 15 },
                new ItemDto{ Id = 16, Code = "116", Name = "雪梨", Price = 16 },
                new ItemDto{ Id = 17, Code = "117", Name = "西瓜", Price = 17 },
                new ItemDto{ Id = 18, Code = "118", Name = "芒果", Price = 18 },
                new ItemDto{ Id = 19, Code = "119", Name = "葡萄", Price = 19 },
                new ItemDto{ Id = 20, Code = "120", Name = "水蜜桃", Price = 20 },
                new ItemDto{ Id = 21, Code = "121", Name = "哈密瓜", Price = 21 },
                new ItemDto{ Id = 22, Code = "122", Name = "榴莲", Price = 22 },
                new ItemDto{ Id = 23, Code = "123", Name = "荔枝", Price = 23 },
                new ItemDto{ Id = 24, Code = "124", Name = "草莓", Price = 24 },
                new ItemDto{ Id = 25, Code = "125", Name = "火龙果", Price = 25 },
                new ItemDto{ Id = 26, Code = "126", Name = "三华李", Price = 26 },
                new ItemDto{ Id = 27, Code = "127", Name = "水果1", Price = 27 },
                new ItemDto{ Id = 28, Code = "128", Name = "水果2", Price = 28 },
                new ItemDto{ Id = 29, Code = "129", Name = "水果3", Price = 29 },
                new ItemDto{ Id = 30, Code = "130", Name = "水果4", Price = 30 },
                new ItemDto{ Id = 31, Code = "131", Name = "水果5", Price = 31 },
                new ItemDto{ Id = 32, Code = "132", Name = "水果6", Price = 32 },
                new ItemDto{ Id = 33, Code = "133", Name = "水果7", Price = 33 },
                new ItemDto{ Id = 34, Code = "134", Name = "水果8", Price = 34 },
                new ItemDto{ Id = 35, Code = "135", Name = "水果9", Price = 35 },
                new ItemDto{ Id = 36, Code = "136", Name = "水果10", Price = 36 },
                new ItemDto{ Id = 37, Code = "137", Name = "水果11", Price = 37 },
                new ItemDto{ Id = 38, Code = "138", Name = "水果12", Price = 38 },
                new ItemDto{ Id = 39, Code = "139", Name = "水果13", Price = 39 },
                new ItemDto{ Id = 40, Code = "140", Name = "水果14", Price = 40 },
                new ItemDto{ Id = 41, Code = "141", Name = "水果15", Price = 41 },
                new ItemDto{ Id = 42, Code = "142", Name = "水果16", Price = 42 },
            };

            this.ea = ea;
            SelectItemCommand = new DelegateCommand<int?>(SendItem);
        }

        private void SendItem(int? id)
        {
            ItemDto selectItem = ItemDtos.ToList().FirstOrDefault(i => i.Id == id);
            if (selectItem != null)
            {
                ShopItemDto shopItemDto = new ShopItemDto
                {
                    Id = selectItem.Id,
                    Code = selectItem.Code,
                    Name = selectItem.Name, 
                    Price = selectItem.Price,                
                    Number = 1,
                    Amount = selectItem.Price,
                };
                ea.GetEvent<ItemSentToShopEvent>().Publish(shopItemDto);
            }
            
        }
    }
}
