namespace Task1
{
    struct Apartment
    {
        private string _address;
        private int _roomsCount;
        private double _square;
        public House house;

        public Apartment() : this("Неизвестен", 0, 0) { }

        public Apartment(string address, int roomsCount, double square)
        {
            Address = address;
            RoomsCount = roomsCount;
            Square = square;
            house = House.PrivateHouse;
        }

        public void Print()
        {
            Console.WriteLine($"Адрес - {Address}, количество комнат - {RoomsCount}, площадь - {Square}, вид - {house}");
        }

        #region Свойства
        public string Address
        {
            get => _address;
            set
            {
                value = value.Trim();
                if (_address != value && value != "")
                    _address = value;
            }
        }

        public int RoomsCount
        {
            get => _roomsCount;
            set
            {
                if (value > 0)
                    _roomsCount = value;
            }
        }

        public double Square
        {
            get => _square;
            set
            {
                if (value > 0)
                    _square = value;
            }
        }
        #endregion
    }
}
