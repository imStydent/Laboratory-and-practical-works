namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> authors = new();

            int hitCounter = 0;

            authors.Add("А.С. Пушкин", "Россия");
            authors.Add("Инбали Изерлес", "Израиль");
            authors.Add("Л.Н. Толстой", "Россия");

            Console.WriteLine("Введите количество авторов, которое вы хотите добавить: ");
            int authorsCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя автора и страну проживания");
            for (int i = 0; i < authorsCount; i++)
                authors.Add(Console.ReadLine(), Console.ReadLine());

            foreach (var item in authors)
                Console.WriteLine($"Автор: {item.Key}, страна проживания: {item.Value}");

            Console.WriteLine("Введите ФИО автора");
            string name = Console.ReadLine();

            Console.WriteLine("Введите страну проживания автора");
            string country = Console.ReadLine();

            if (authors.ContainsKey(name))
                Console.WriteLine($"Указанный вами автор {name} живёт в стране {authors[name]}");
            else
                Console.WriteLine("Автор не найден");
            Console.WriteLine();

            foreach (var item in authors)
            {
                if (country == item.Value)
                    hitCounter++;
            }

            Console.WriteLine($"Количество совпадений по стране {country} - {hitCounter}");
            Console.WriteLine();

            authors.Remove(name);
            foreach (var item in authors)
                Console.WriteLine($"Автор: {item.Key}, страна проживания: {item.Value}");
        }
    }
}
