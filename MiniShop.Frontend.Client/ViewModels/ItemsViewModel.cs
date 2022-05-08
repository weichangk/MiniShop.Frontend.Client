using MiniShop.Frontend.Client.Dtos;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace MiniShop.Frontend.Client.ViewModels
{
    public class ItemsViewModel : BindableBase
    {
        private ObservableCollection<ItemDto> itemDtos;
        public ObservableCollection<ItemDto> ItemDtos
        {
            get { return itemDtos; }
            set { itemDtos = value; RaisePropertyChanged(); }
        }

        public ItemsViewModel()
        {
            ItemDtos = new ObservableCollection<ItemDto>
            {
                new ItemDto{ Id = 1, Code = "101", Name = "水果" },
                new ItemDto{ Id = 2, Code = "101", Name = "手机" },
                new ItemDto{ Id = 3, Code = "101", Name = "烟" },
                new ItemDto{ Id = 4, Code = "101", Name = "酒" },
                new ItemDto{ Id = 5, Code = "101", Name = "猪肉" },
                new ItemDto{ Id = 6, Code = "101", Name = "水果1" },
                new ItemDto{ Id = 7, Code = "101", Name = "水果2" },
                new ItemDto{ Id = 8, Code = "101", Name = "水果3" },
                new ItemDto{ Id = 9, Code = "101", Name = "水果4" },
                new ItemDto{ Id = 10, Code = "101", Name = "水果5" },
                new ItemDto{ Id = 11, Code = "101", Name = "水果6" },
                new ItemDto{ Id = 12, Code = "101", Name = "水果7" },
                new ItemDto{ Id = 13, Code = "101", Name = "水果8" },
                new ItemDto{ Id = 14, Code = "101", Name = "水果9" },
                new ItemDto{ Id = 15, Code = "101", Name = "水果10" },
                new ItemDto{ Id = 15, Code = "101", Name = "水果11" },
                new ItemDto{ Id = 15, Code = "101", Name = "水果12" },
                new ItemDto{ Id = 15, Code = "101", Name = "水果13" },
                new ItemDto{ Id = 15, Code = "101", Name = "水果14" },
                new ItemDto{ Id = 15, Code = "101", Name = "水果15" },
                new ItemDto{ Id = 15, Code = "101", Name = "水果16" },
            };
        }
    }
}
