namespace MiniShop.Frontend.Client.Dtos
{
    public class CategoryDto : BaseDto
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

    }
}
