namespace Task1
{
    internal class Apartment
    {
        #region Параметры
        string _address;
        int _roomsCount;
        double _square;
        #endregion

        #region Конструкторы
        public Apartment() : this("неизвестен", 0, 0) { }

        public Apartment(string address, int roomsCount, double square)
        {
            _address = address;
            _roomsCount = roomsCount;
            _square = square;
        }
        #endregion

        public void Print()
        {
            Console.WriteLine($"Адрес: {_address}, количество комнат - {_roomsCount}, площадь - {_square}");
        }

        #region Индексаторы
        public object? this[string index]
        {
            get
            {
                return index switch
                {
                    "Адрес" => _address,
                    "Количество комнат" => _roomsCount,
                    "Площадь" => _square,
                    _ => null
                };
            }
        }

        public char this[int index] => index < 0 || index >= _address.Length ? '\0' : _address[index];
        #endregion
    }
}
