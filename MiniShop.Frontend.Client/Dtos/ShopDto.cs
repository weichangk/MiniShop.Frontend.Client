using System.Collections.ObjectModel;

namespace MiniShop.Frontend.Client.Dtos
{
    public class ShopDto : BaseDto
    {
        private ObservableCollection<ShopItemDto> shopItemDtos;
        public ObservableCollection<ShopItemDto> ShopItemDtos
        {
            get { return shopItemDtos; }
            set { shopItemDtos = value; OnPropertyChanged(); }
        }

        private ShopPreviousBillDto shopPreviousBillDto;
        public ShopPreviousBillDto ShopPreviousBillDto
        {
            get { return shopPreviousBillDto; }
            set { shopPreviousBillDto = value; OnPropertyChanged(); }
        }

        private ShopVipDto shopVipDto;
        public ShopVipDto ShopVipDto
        {
            get { return shopVipDto; }
            set { shopVipDto = value; OnPropertyChanged(); }
        }

        private decimal number;
        public decimal Number
        {
            get { return number; }
            set { number = value; OnPropertyChanged(); }
        }

        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; OnPropertyChanged(); }
        }
    }
}
