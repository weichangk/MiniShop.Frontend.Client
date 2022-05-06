using MiniShop.Frontend.Client.Dtos;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace MiniShop.Frontend.Client.ViewModels
{
    public class CategoryViewModel : BindableBase
    {
        private ObservableCollection<CategoryDto> categoryDtos;
        public ObservableCollection<CategoryDto> CategoryDtos
        {
            get { return categoryDtos; }
            set { categoryDtos = value; RaisePropertyChanged(); }
        }

        public CategoryViewModel()
        {
            CategoryDtos = new ObservableCollection<CategoryDto>
            {
                new CategoryDto{ Id = 1, Code = "101", Name = "水果" },
                new CategoryDto{ Id = 2, Code = "101", Name = "手机" },
                new CategoryDto{ Id = 3, Code = "101", Name = "烟" },
                new CategoryDto{ Id = 4, Code = "101", Name = "酒" },
                new CategoryDto{ Id = 5, Code = "101", Name = "猪肉" },
                new CategoryDto{ Id = 6, Code = "101", Name = "水果1" },
                new CategoryDto{ Id = 7, Code = "101", Name = "水果2" },
                new CategoryDto{ Id = 8, Code = "101", Name = "水果3" },
                new CategoryDto{ Id = 9, Code = "101", Name = "水果4" },
                new CategoryDto{ Id = 10, Code = "101", Name = "水果5" },
                new CategoryDto{ Id = 11, Code = "101", Name = "水果6" },
                new CategoryDto{ Id = 12, Code = "101", Name = "水果7" },
                new CategoryDto{ Id = 13, Code = "101", Name = "水果8" },
                new CategoryDto{ Id = 14, Code = "101", Name = "水果9" },
                new CategoryDto{ Id = 15, Code = "101", Name = "水果10" },
                new CategoryDto{ Id = 15, Code = "101", Name = "水果11" },
                new CategoryDto{ Id = 15, Code = "101", Name = "水果12" },
                new CategoryDto{ Id = 15, Code = "101", Name = "水果13" },
                new CategoryDto{ Id = 15, Code = "101", Name = "水果14" },
                new CategoryDto{ Id = 15, Code = "101", Name = "水果15" },
                new CategoryDto{ Id = 15, Code = "101", Name = "水果16" },
            };
        }
    }
}
