namespace MiniShop.Frontend.Client.Dtos
{
    public class ItemDto : BaseDto
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; OnPropertyChanged(); }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }
    }
}
